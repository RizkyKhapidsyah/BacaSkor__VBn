Public Class Form1

    Private Sub tombolBaca_Click(sender As Object, e As EventArgs) Handles tombolBaca.Click
        'prosedur ini membaca skor ujian, kemudian menghitung dan
        'menampilkan rerata
        Dim intBanyakSkor As Integer    'banyak skor ujian
        Dim dblSkorUjian As Double      'memuat skor ujian
        Dim dblTotal As Double = 0      'akumulator, diinisialisasi dengan 0
        Dim dblRerata As Double         'rerata dari skor-skor ujian
        Dim strMasukan As String        'memuat masukan user
        Dim intHitung As Integer = 1    'variabel pencacah, diinisialisasi dengan 1

        'meminta user memasukkan banyak skor ujian
        strMasukan = InputBox("Berapa banyak skor ujian yang ingin direratakan?")

        'mengkonversi masukan menjadi sebuah integer
        If Integer.TryParse(strMasukan, intBanyakSkor) Then

            'membaca skor-skor ujian
            Do Until intHitung > intBanyakSkor
                'meminta user untuk memasukkan skor ujian
                strMasukan = InputBox("Masukkan skor ujian " &
                intHitung.ToString())

                'mengkonversi masukan menjadi sebuah Double
                If Double.TryParse(strMasukan, dblSkorUjian) Then

                    'menambahkan skor pada akumulator
                    dblTotal += dblSkorUjian

                    'menambah 1 pada pencacah
                    intHitung += 1
                Else
                    'skor ujian tak-valid
                    MessageBox.Show("Masukkan skor ujian numerik.")
                End If
            Loop

            'menghitung dan menampilkan rerata
            If intBanyakSkor > 0 Then
                dblRerata = dblTotal / intBanyakSkor
                labelRerata.Text = dblRerata.ToString()
            End If

        Else
            'nilai tak valid dari banyak skor ujian
            MessageBox.Show("Masukkan nilai integer untuk banyak skor ujian.")
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class