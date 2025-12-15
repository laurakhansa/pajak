% =========================================================
% PREDICATE BARU UNTUK API
% Input: 7 Boolean (1=Y/true, 0=T/false)
% Output: Status SPT (atom: nihil, kurang_bayar, lebih_bayar)
% =========================================================

% Predikat utama yang akan dipanggil dari C#
get_spt_status(Q1, Q2, Q3, Q4, Q5, Q6, Q7, Kewajiban, Status) :-
    retractall(observation(_)),
    
    % 1. Masukkan semua input observasi
    assert_observation(Q1, punya_npwp),
    assert_observation(Q2, punya_penghasilan),
    assert_observation(Q3, sumber_penghasilan_ganda),
    assert_observation(Q4, resign_tengah_tahun),
    assert_observation(Q5, gaji_fluktuatif),
    assert_observation(Q6, ada_bukti_zakat),
    assert_observation(Q7, terlambat_lapor),
    
    % 2. Eksekusi aturan
    ( aturan_kewajiban_lapor(Kewajiban) ->
        % 3. Cek apakah wajib lapor
        ( Kewajiban = wajib_lapor -> 
            ( aturan_status(Status) -> true ; Status = 'ERROR_STATUS' )
        ; 
            Status = 'TIDAK_WAJIB_LAPOR' % Jika tidak wajib lapor, status tidak perlu dicari
        )
    ; 
        Kewajiban = 'ERROR_KEWAJIBAN',
        Status = 'ERROR_STATUS'
    ), !.
    
% Predikat pembantu untuk assertz
assert_observation(1, Fact) :- assertz(observation(Fact)).
assert_observation(0, _) :- true.