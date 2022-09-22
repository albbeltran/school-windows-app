'// Import libraries to connect to the database
Imports System.Data
Imports System.Data.OleDb

Module Connection_Base

    Public Route As String = Application.StartupPath '// Save the route in the debug folder

    '// Variable that makes the connection

    Public connection As New OleDbConnection

    Sub Link()
        Try

            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & vbLf &
            Route + "\Resources\Base_Main.accdb"
            connection.Open()

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

End Module