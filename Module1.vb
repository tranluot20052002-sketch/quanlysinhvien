Imports System.Data.SqlClient  ' thư viện làm việc với SQL Server

Module DBConnect
    ' Biến kết nối dùng chung
    Public conn As SqlConnection

    ' Hàm mở kết nối SQL
    Public Sub KetNoi()
        Try
            ' Chuỗi kết nối SQL Server
            Dim chuoi As String = "Data Source=DESKTOP-RV2Q53S\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Trust Server Certificate=True"
            conn = New SqlConnection(chuoi)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Kết nối thất bại: " & ex.Message)
        End Try
    End Sub

End Module
