Imports System.Net.Http
Imports System.Text
Imports System.Collections.Generic
Imports Newtonsoft.Json
Imports System.Windows.Forms ' Untuk MsgBox

Public Class PrologClient

    ' Menggunakan PORT 8001 sesuai server Prolog yang berjalan
    Private Const ApiUrl As String = "http://127.0.0.1:8001/calculate_spt"
    Private Shared ReadOnly client As New HttpClient()

    Public Class SptResult
        Public Property kewajiban_lapor As String
        Public Property status_spt As String
    End Class

    Public Async Function GetSptStatus(ByVal qValues As List(Of Integer)) As Task(Of SptResult)

        Dim payload As Object = New With {.putih_data = qValues}
        Dim jsonContent As String = JsonConvert.SerializeObject(payload)

        Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync(ApiUrl, content)

            response.EnsureSuccessStatusCode()

            Dim responseString As String = Await response.Content.ReadAsStringAsync()
            Dim result As SptResult = JsonConvert.DeserializeObject(Of SptResult)(responseString)

            Return result

        Catch ex As HttpRequestException
            MsgBox("Error Koneksi ke Server Prolog. Pastikan server berjalan di port 8001. " & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Error API")
            Return New SptResult With {.kewajiban_lapor = "ERROR", .status_spt = "ERROR"}
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat memproses data: " & ex.Message, MsgBoxStyle.Critical, "Error Pemrosesan")
            Return New SptResult With {.kewajiban_lapor = "ERROR", .status_spt = "ERROR"}
        End Try
    End Function
End Class