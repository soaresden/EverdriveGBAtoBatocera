Imports System.IO
Imports System.Globalization
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBASD.Text = My.Settings.everdriveletter
        BatoceraPath.Text = My.Settings.batocerauserpath
        GBAtoBato.Visible = False
        BatotoGBA.Visible = False
        CalculateDelta.Visible = False
        RefreshBatocera.Visible = False
    End Sub
    Private Sub GBASD_TextChanged(sender As Object, e As EventArgs) Handles GBASD.TextChanged
        If GBASD.Text.Length > 1 Then
            My.Settings.everdriveletter = GBASD.Text
            My.Settings.Save()
        End If
    End Sub
    Private Sub BatoceraPath_TextChanged(sender As Object, e As EventArgs) Handles BatoceraPath.TextChanged
        If BatoceraPath.Text.Length > 1 Then
            My.Settings.batocerauserpath = BatoceraPath.Text
            My.Settings.Save()
        End If
    End Sub
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

        RefreshBatocera.Visible = True
    End Sub

    Private Sub RefreshBatocera_Click(sender As Object, e As EventArgs) Handles RefreshBatocera.Click
        'Go to SD older 
        Dim batocerasavepath As String = Path.Combine(BatoceraPath.Text, "saves", "gba")

        'Safely Clearing Grid
        BatoceraTab.Columns.Clear()
        On Error Resume Next
        BatoceraTab.Rows.Clear()
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

        Dim di As New IO.DirectoryInfo(batocerasavepath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.srm")
        Dim fi As IO.FileInfo

        countfiles = aryFi.Length

        For Each fi In aryFi
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
        BatoceraTab.DataSource = table

        'Width for columns
        BatoceraTab.RowHeadersWidth = 25
        BatoceraTab.Columns("SaveFile").Width = 240
        BatoceraTab.Columns("Last Updated").Width = 100
        'Hiding les colonnes
        BatoceraTab.Columns("Path").Visible = False

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Last Updated desc"

        CalculateDelta.Visible = True
    End Sub
    Private Sub CalculateDelta_Click(sender As Object, e As EventArgs) Handles CalculateDelta.Click
        Call CompletingListBoxes()
        GBAtoBato.Visible = True
        BatotoGBA.Visible = True
    End Sub
    Private Sub CompletingListBoxes()
        'cleaning listboxes
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()

        ListBox3.ClearSelected()
        ListBox4.ClearSelected()

        Dim destinationpath As String

        For i = 0 To EverdriveTab.Rows.Count - 2
            Dim savefilegba As String = EverdriveTab.Rows(i).Cells(EverdriveTab.Columns("SaveFile").Index).Value
            Dim lastupdatedgba As String = Replace(EverdriveTab.Rows(i).Cells(EverdriveTab.Columns("Last Updated").Index).Value, "-", "")
            Dim pathgba As String = EverdriveTab.Rows(i).Cells(EverdriveTab.Columns("Path").Index).Value
            Dim filenamesrm As String = Path.GetFileNameWithoutExtension(pathgba) & ".srm"

            'search for it on the other tab
            destinationpath = Path.Combine(BatoceraPath.Text, "saves", "gba", filenamesrm)

            'adding to listboxes
            ListBox1.Items.Add(pathgba)
            ListBox2.Items.Add(destinationpath)

        Next

        For j = 0 To BatoceraTab.Rows.Count - 2
            Dim savefilebato As String = BatoceraTab.Rows(j).Cells(BatoceraTab.Columns("SaveFile").Index).Value
            Dim lastupdatedbato As String = Replace(BatoceraTab.Rows(j).Cells(BatoceraTab.Columns("Last Updated").Index).Value, "-", "")
            Dim pathbato As String = BatoceraTab.Rows(j).Cells(BatoceraTab.Columns("Path").Index).Value
            Dim savefilename As String = Path.GetFileNameWithoutExtension(savefilebato)

            'search for existing file
            Dim di As New IO.DirectoryInfo(Path.Combine(GBASD.Text, "GBASYS", "save"))
            Dim aryFi As IO.FileInfo() = di.GetFiles(savefilename & ".*")
            Dim fi As IO.FileInfo
            Dim extension As String
            Dim findfilepath As String

            Dim countfiles = aryFi.Length
            If countfiles = 0 Then extension = ".srm"

            For Each fi In aryFi
                extension = fi.Extension
            Next


            destinationpath = Path.Combine(GBASD.Text, "GBASYS", "save", savefilename & extension)

            'adding to listboxes
            ListBox3.Items.Add(pathbato)
            ListBox4.Items.Add(destinationpath)
        Next

        'Checking if Already add

        For item = 0 To ListBox2.Items.Count - 1
            If System.IO.File.Exists(ListBox2.Items(item)) Then
                ListBox2.SetSelected(item, True)
            End If
        Next


        For item = 0 To ListBox4.Items.Count - 1
            If System.IO.File.Exists(ListBox4.Items(item)) Then
                ListBox4.SetSelected(item, True)
            End If
        Next

    End Sub

    Private Sub listBox2_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        If e.Index < 0 Then Return
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then e = New DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State Xor DrawItemState.Selected, e.ForeColor, Color.Red)
        e.DrawBackground()
        e.Graphics.DrawString(ListBox2.Items(e.Index).ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub GBAtoBato_Click(sender As Object, e As EventArgs) Handles GBAtoBato.Click
        If MsgBox("Are you sure you want to copy all your files from left to right ?", vbYesNo) = vbNo Then Exit Sub

        Dim sourcefile As String
        Dim destinationfile As String

        For i = 0 To ListBox1.Items.Count
            sourcefile = ListBox1.Items(i)
            destinationfile = ListBox2.Items(i)
            FileCopy(sourcefile, destinationfile)
        Next

        MsgBox("Finished")
        Process.Start(Path.Combine(BatoceraPath.Text, "saves", "gba"))
    End Sub

    Private Sub BatotoGBA_Click(sender As Object, e As EventArgs) Handles BatotoGBA.Click
        If MsgBox("Are you sure you want to copy all your files from left to right ?", vbYesNo) = vbNo Then Exit Sub

        Dim sourcefile As String
        Dim destinationfile As String

        For i = 0 To ListBox3.Items.Count
            sourcefile = ListBox3.Items(i)
            destinationfile = ListBox4.Items(i)
            FileCopy(sourcefile, destinationfile)
        Next

        MsgBox("Finished")
        Process.Start(Path.Combine(GBASD.Text, "GBASYS", "save"))
    End Sub
End Class
