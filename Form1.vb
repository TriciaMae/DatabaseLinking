Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub SklCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SklCombo.SelectedIndexChanged
        'populating textbox with values from selected combobox
        Dim MySqlConn As New MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=;database=csas"
        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand

        Try
            'open the database connection
            MySqlConn.Open()

            'write the query for the database
            Dim query As String = "select * from csas.send where school = '" & SklCombo.Text & "'
            and id = '" & idCombo.Text & "'"

            'pass the query to mysql command
            command = New MySqlCommand(query, MySqlConn)

            'execute the command
            reader = command.ExecuteReader

            'show all the data in a specific column in the database to the combobox
            While reader.Read
                'populating the textbox with the data according to the selected ID. If the column
                'has numbers as data, use getint32
                'txtLvl.Text = reader.GetString("lvl")
                txtCp.Text = reader.GetString("cp_num")
                txtLvl.Text = reader.GetString("lvl")

            End While

            'close the database connection
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'linking database values to combobox
        Dim MySqlConn As New MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=;database=csas"
        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand

        Try
            'open the database connection
            MySqlConn.Open()

            'write the query for the database
            Dim query As String = "select * from csas.send"

            'pass the query to mysql command
            command = New MySqlCommand(query, MySqlConn)

            'execute the command
            reader = command.ExecuteReader

            'show all the data in a specific column in the database to the combobox
            While reader.Read
                'linking database values to combobox
                Dim skl = reader.GetString("school")
                Dim ide = reader.GetInt32("id")

                'loading combobox with database values
                SklCombo.Items.Add(skl)
                idCombo.Items.Add(ide)
            End While

            'close the database connection
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class
