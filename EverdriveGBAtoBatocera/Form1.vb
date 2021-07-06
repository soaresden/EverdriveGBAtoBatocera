Imports System.IO
Imports System.Globalization
Public Class Form1

    Private Sub RefreshGBA_Click(sender As Object, e As EventArgs) Handles RefreshGBA.Click
        'Go to SD older 
        Dim gbasavepath As String = Path.Combine(GBASD.Text, "GBASYS", "save")

        'Safely Clearing Grid
        EverdriveTab.Columns.Clear()
        On Error Resume Next
        EverdriveTab.Rows.Clear()
        On Error GoTo 0

        'Creating table
        Dim table As New DataTable()
        Dim dv As DataView
        Dim column As DataColumn

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "SaveFile"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Path"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Last Updated"
        End With
        table.Columns.Add(column)

        Dim extension As String
        Dim savefile As String
        Dim savepath As String
        Dim savelastupdated As String

        Dim countfiles As Integer

        Dim di As New IO.DirectoryInfo(gbasavepath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*")
        Dim fi As IO.FileInfo

        countfiles = aryFi.Length

        For Each fi In aryFi
            'if extension is txt 
            If fi.Extension = ".txt" Then GoTo nextfile

            If countfiles > 0 Then
                'getting infos
                savefile = fi.Name
                savepath = fi.FullName
                Dim lastupdated = fi.LastWriteTime

                savelastupdated = CDate(lastupdated).ToString("yyyyMMdd-HHmmss")

                'adding to table
                table.Rows.Add(savefile, savepath, savelastupdated)
            Else
                'no files !
                MsgBox("No Files !")
                Exit Sub
            End If
            'next file
nextfile:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        EverdriveTab.DataSource = table

        'Width for columns
        EverdriveTab.RowHeadersWidth = 25
        EverdriveTab.Columns("SaveFile").Width = 240
        EverdriveTab.Columns("Last Updated").Width = 100
        'Hiding les colonnes
        EverdriveTab.Columns("Path").Visible = False

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Last Updated desc"
    End Sub
End Class
