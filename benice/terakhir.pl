% =========================================================
% SISTEM PAKAR STATUS SPT TAHUNAN 
% =========================================================

:- dynamic observation/1.

mulai_spt :-
    retractall(observation(_)),
    init_spt,
    ask_all_questions,
    
    ( aturan_kewajiban_lapor(Kewajiban) -> 
        nl, write('>>> HASIL ANALISIS KEWAJIBAN & STATUS SPT <<<'), nl,
        write('-------------------------------------------'), nl,
        
        ( Kewajiban = tidak_wajib_lapor -> 
            nl, write('KEWAJIBAN LAPOR: TIDAK WAJIB LAPOR'), nl,
            jawaban_kewajiban(Kewajiban),
            ( ada(punya_penghasilan) -> 
                nl, write('PERINGATAN: Penghasilan terdeteksi. Jika penghasilan Anda di atas PTKP, Anda seharusnya mendaftarkan NPWP.'), nl
            ; true )
        ; 
            nl, write('KEWAJIBAN LELAPORAN: WAJIB LAPOR (karena memiliki NPWP aktif)'), nl,
            jawaban_kewajiban(Kewajiban),
            
            ( aturan_status(Status) -> 
                status_teks(Status, StatusTeks), 
                nl, write('PREDIKSI STATUS SPT: '), write(StatusTeks), nl,
                write('-------------------------------------------'), nl,
                jawaban_spt(Status),
                nl
            ; write('ERROR: Tidak dapat menentukan status prediksi.'), nl )
        ),
        nl,
        print_catatan
    ; write('ERROR: Tidak dapat menentukan kewajiban lapor.'), nl ).

init_spt :-
    nl, write('========================================================'), nl,
    write(' SISTEM PAKAR STATUS SPT TAHUNAN '), nl,
    write('========================================================'), nl,
    write('Jawab pertanyaan berikut dengan y (ya) atau t (tidak).'), nl, nl.

% =========================================================
% INPUT ENGINE BARU 
% =========================================================

ask_all_questions :-
    % Urutan 7 pertanyaan baru
    Questions = [punya_npwp, punya_penghasilan, sumber_penghasilan_ganda, resign_tengah_tahun, gaji_fluktuatif, ada_bukti_zakat, terlambat_lapor],
    iterate_questions(Questions).

iterate_questions([]).
iterate_questions([Obs | Sisa]) :-
    ( skip_question(Obs) ->
        skip_message(Obs),
        nl,
        iterate_questions(Sisa)
    ; 
        % Tanyakan Pertanyaan
        pertanyaan_spt(_, Obs, Teks), 
        write(Teks), nl,
        write('Jawab (y/t): '),
        read_line_to_string(user_input, Input0),
        normalize_space(string(Input), Input0),
        string_lower(Input, LowerInput),

        ( LowerInput = "y" ->
            assertz(observation(Obs))
        ; 
            true
        ),
        nl,
        iterate_questions(Sisa)
    ).

% =========================================================
% PERTANYAAN 
% =========================================================

pertanyaan_spt('Q1', punya_npwp, '1. Apakah Anda memiliki Nomor Pokok Wajib Pajak (NPWP) yang masih aktif?').
pertanyaan_spt('Q2', punya_penghasilan, '2. Apakah Anda menerima Gaji atau Penghasilan selama tahun pajak ini?').
pertanyaan_spt('Q3', sumber_penghasilan_ganda, '3. Apakah Anda memiliki lebih dari SATU sumber penghasilan (termasuk freelance, honorarium, atau bisnis)?').
pertanyaan_spt('Q4', resign_tengah_tahun, '4. Apakah Anda mulai bekerja atau berhenti/resign di pertengahan tahun pajak?').
pertanyaan_spt('Q5', gaji_fluktuatif, '5. Apakah ada penerimaan bonus besar, THR, atau kenaikan gaji mendadak dalam setahun?').
pertanyaan_spt('Q6', ada_bukti_zakat, '6. Apakah Anda memiliki bukti pembayaran Zakat atau sumbangan keagamaan wajib yang sah?').
pertanyaan_spt('Q7', terlambat_lapor, '7. Apakah Anda akan melaporkan SPT Tahunan setelah batas waktu tanggal 31 Maret?').

% =========================================================
% RULE LOGIKA SKIP
% =========================================================

ada(X) :- observation(X).
tidak_ada(X) :- \+ observation(X).

% LOGIKA SKIP 7 PERTANYAAN
% Q3, Q4, Q5, Q6 dilewati JIKA Q2 = TIDAK
skip_question(sumber_penghasilan_ganda) :- \+ ada(punya_penghasilan).
skip_question(resign_tengah_tahun) :- \+ ada(punya_penghasilan).
skip_question(gaji_fluktuatif) :- \+ ada(punya_penghasilan).
skip_question(ada_bukti_zakat) :- \+ ada(punya_penghasilan).

% Q7 dilewati JIKA Q1 = TIDAK
skip_question(terlambat_lapor) :- \+ ada(punya_npwp).


% Pesan Skip
skip_message(sumber_penghasilan_ganda) :- write('Q3 dilewati karena Q2 = Tidak (Tidak ada penghasilan).').
skip_message(resign_tengah_tahun) :- write('Q4 dilewati karena Q2 = Tidak (Tidak ada penghasilan).').
skip_message(gaji_fluktuatif) :- write('Q5 dilewati karena Q2 = Tidak (Tidak ada penghasilan).').
skip_message(ada_bukti_zakat) :- write('Q6 dilewati karena Q2 = Tidak (Tidak ada penghasilan).').
skip_message(terlambat_lapor) :- write('Q7 dilewati karena Q1 = Tidak (Tidak wajib lapor).').

% =========================================================
% ATURAN STATUS 
% =========================================================

% ATURAN KEWAJIBAN LAPOR
aturan_kewajiban_lapor(wajib_lapor) :-
    ada(punya_npwp), !.
aturan_kewajiban_lapor(tidak_wajib_lapor) :-
    tidak_ada(punya_npwp), !.

% ATURAN PREDIKSI STATUS SPT
% 1. KURANG BAYAR (Dipicu oleh Multi-Sumber)
aturan_status(kurang_bayar) :-
    ada(sumber_penghasilan_ganda), !. 

% 2. LEBIH BAYAR (Dipicu oleh Fluktuasi, Zakat, atau Resign)
aturan_status(lebih_bayar) :-
    ada(gaji_fluktuatif), !. 

aturan_status(lebih_bayar) :-
    ada(ada_bukti_zakat), !.

aturan_status(lebih_bayar) :-
    ada(resign_tengah_tahun), !.

% 3. NIHIL (Kasus Standar)
aturan_status(nihil) :-
    \+ ada(punya_penghasilan), !.

aturan_status(nihil) :-
    \+ ada(sumber_penghasilan_ganda), 
    \+ ada(gaji_fluktuatif),   
    \+ ada(ada_bukti_zakat),
    \+ ada(resign_tengah_tahun), !.

% Fallback
aturan_status(nihil).

% =========================================================
% OUTPUT TEKS 
% =========================================================

status_teks(nihil, 'NIHIL / AMAN').
status_teks(kurang_bayar, 'KURANG BAYAR / RISIKO TINGGI').
status_teks(lebih_bayar, 'LEBIH BAYAR / KLAIM PENGEMBALIAN').

jawaban_kewajiban(wajib_lapor) :-
    ( \+ ada(punya_penghasilan) -> 
        write('CATATAN: Anda wajib lapor status Nihil karena memiliki NPWP aktif.'), nl
    ; true ).
jawaban_kewajiban(tidak_wajib_lapor) :-
    write('Penjelasan: Anda tidak memiliki kewajiban untuk melapor SPT Tahunan PPh Orang Pribadi.'), nl.

jawaban_spt(nihil) :-
    write('### PANDUAN: PELAPORAN STANDARD (NIHIL) ###'), nl,
    write('Profil Anda menunjukkan kondisi stabil (1 pemberi kerja). Potongan pajak kantor sudah impas.'), nl,
    write('Langkah Anda di Korteks (UR-3.0/FR-3.0):'), nl,
    write('* Akses Data: Login Korteks untuk melihat data PPh 21 yang sudah terisi otomatis.'), nl,
    write('* Verifikasi: Periksa dan Setujui data pemotongan tersebut.'), nl,
    write('* Submit: Segera laporkan SPT Tahunan Anda dengan status NIHIL (Nol).'), nl.

jawaban_spt(kurang_bayar) :-
    write('### PANDUAN: RISIKO KURANG BAYAR & MULTI-SUMBER ###'), nl,
    write('Anda terdeteksi memiliki sumber penghasilan ganda/masalah administrasi, memicu Kurang Bayar.'), nl,
    write('Tindakan Wajib (BR-1.0/UR-4.0):**'), nl,
    write('* Kumpulkan: Pastikan semua bukti potong dari multi-sumber telah digabungkan.'), nl,
    write('* Pelunasan: Anda WAJIB melunasi kekurangan pajak sebelum submit.'), nl,
    write('* e-Billing: Gunakan fungsi Buat Kode Billing (FR-4.0) langsung dari antarmuka SPT.'), nl,
    write('* Blokir: Sistem akan memblokir submission SPT jika pelunasan belum diverifikasi.'), nl.

jawaban_spt(lebih_bayar) :-
    write('### PANDUAN: KLAIM PENGEMBALIAN KELEBIHAN BAYAR ###'), nl,
    write('Terdeteksi kondisi Fluktuasi Gaji, Zakat, atau Resign yang menyebabkan pajak terpotong lebih besar (LEBIH BAYAR).'), nl,
    write('Tindakan Prioritas (UR-6.0):'), nl,
    write('* Klaim: Anda berhak menagih kelebihan potongan ini kepada Pemberi Kerja (Menangani Pengembalian Lebih Bayar).'), nl,
    write('* Kompensasi: Pemberi Kerja wajib mengkompensasi atau mengembalikan uang kelebihan bayar tersebut.'), nl,
    write('* Lapor Akhir: Setelah kelebihan bayar diselesaikan, laporkan SPT Anda dengan status NIHIL.'), nl.

print_catatan :-
    nl, write('--- Catatan Tambahan (Risiko Administratif) ---'), nl,
    ( ada(ada_bukti_zakat) -> 
        write('* CATATAN ZAKAT: Klaim zakat adalah pengurang penghasilan kena pajak.'), nl
    ; true ),
    ( ada(terlambat_lapor) -> 
        write('* CATATAN DENDA: Anda akan dikenakan denda administrasi keterlambatan lapor sebesar Rp 100.000.'), nl
    ; true ).