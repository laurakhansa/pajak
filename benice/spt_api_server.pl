:- use_module(library(http/http_server)).
:- use_module(library(http/http_json)).  % Change this to http_json
:- use_module(library(apply)).

:- [terakhir].      % Memuat aturan utama (ada/tidak_ada, aturan_status, dll.)
:- [terakhir_api].  % Memuat predikat get_spt_status

% Handler HTTP untuk perhitungan (TIDAK PERLU DIUBAH)
perhitungan_handler(Request) :-
    % 1. Baca data JSON dari request (input dari C#)
    http_read_json_dict(Request, Dict),
    
    % 2. Ekstrak nilai boolean (0 atau 1)
    P = Dict.putih_data,
    [Q1, Q2, Q3, Q4, Q5, Q6, Q7] = P,
    
    % 3. Jalankan predikat sistem pakar
    get_spt_status(Q1, Q2, Q3, Q4, Q5, Q6, Q7, KewajibanAtom, StatusAtom),
    
    % 4. Konversi atom Prolog ke String untuk JSON
    atom_string(KewajibanAtom, KewajibanString),
    atom_string(StatusAtom, StatusString),
    
    % 5. Buat respons JSON
    Response = json{
        kewajiban_lapor: KewajibanString,
        status_spt: StatusString
    },
    
    % 6. Kirim respons
    reply_json(Response).

% Definisikan endpoint dan jalankan server (TIDAK PERLU DIUBAH)
:- http_server(http_dispatch, [port(8000)]).
:- http_handler('/calculate_spt', perhitungan_handler, [method(post), id(spt_calculator)]).