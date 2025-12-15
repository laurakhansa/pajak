Imports PdfSharp.Fonts
Imports System.IO

Public Class SimpleFontResolver
    Implements IFontResolver

    Public Function ResolveTypeface(familyName As String, isBold As Boolean, isItalic As Boolean) As FontResolverInfo Implements IFontResolver.ResolveTypeface
        ' Kita hanya handle Arial untuk sekarang demi kesederhanaan
        If familyName.ToLower().Contains("arial") Then
            If isBold And isItalic Then Return New FontResolverInfo("ArialBoldItalic")
            If isBold Then Return New FontResolverInfo("ArialBold")
            If isItalic Then Return New FontResolverInfo("ArialItalic")
            Return New FontResolverInfo("Arial")
        End If
        
        ' Fallback ke Arial Regular
        Return New FontResolverInfo("Arial")
    End Function

    Public Function GetFont(faceName As String) As Byte() Implements IFontResolver.GetFont
        Try
            Select Case faceName
                Case "Arial"
                    Return File.ReadAllBytes("C:\Windows\Fonts\arial.ttf")
                Case "ArialBold"
                    Return File.ReadAllBytes("C:\Windows\Fonts\arialbd.ttf")
                Case "ArialItalic"
                    Return File.ReadAllBytes("C:\Windows\Fonts\ariali.ttf")
                Case "ArialBoldItalic"
                    Return File.ReadAllBytes("C:\Windows\Fonts\arialbi.ttf")
            End Select
        Catch ex As Exception
            ' Fallback jika file spesifik tidak ketemu, coba arial.ttf
            Try
                Return File.ReadAllBytes("C:\Windows\Fonts\arial.ttf")
            Catch
                 Return Nothing
            End Try
        End Try
        Return Nothing
    End Function
End Class
