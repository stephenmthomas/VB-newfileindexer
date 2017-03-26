Public Class frmNFI
    Dim NNDirection As Integer
    Private Sub cmdDirSel_Click(sender As Object, e As EventArgs) Handles cmdDirSel.Click
        Browser1.ShowDialog()
        txtDir.Text = Browser1.SelectedPath

        If txtDir.Text <> "" Then
            cmdToggle.Enabled = True
            cmdOptions.Enabled = True
            'lbControl.Items.AddRange(IO.Directory.GetFiles(txtDir.Text))
        End If

    End Sub

    Private Sub cmdToggle_Click(sender As Object, e As EventArgs) Handles cmdToggle.Click



        If Timer.Enabled = False Then
            lbControl.Items.AddRange(IO.Directory.GetFiles(txtDir.Text))
            Timer.Enabled = True
            Status1.Text = "ON - NFI is running!"
            cmdToggle.Text = "Stop Scanning"
        ElseIf Timer.Enabled = True Then
            lbControl.Items.Clear()
            Timer.Enabled = False
            Status1.Text = "OFF - NFI is not running."
            cmdToggle.Text = "Start Scanning"
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If cmdOptions.Text = "Show Options" Then
            cmdOptions.Text = "Hide Options"
            Me.Height = 355
            Me.Width = 450
        ElseIf cmdOptions.Text = "Hide Options" Then
            cmdOptions.Text = "Show Options"
            Me.Height = 125
        End If
    End Sub


    Private Sub cmdHelpScan_Click(sender As Object, e As EventArgs) Handles cmdHelpScan.Click
        MsgBox("The Scan Interval is how frequently NFI checks the directory for incoming files.  The lower the value, the faster NFI scans the directory.  100 is default.  You can see the status/ping of scans by looking at the status bar.")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim targetF As System.IO.FileInfo
        Dim NewName As String
        Dim FileSuffix As String
        Dim FileExtension As String
        Dim FilePrefix As String

        Dim nSuffix As Int32

        lbScanned.Items.Clear()
        lbScanned.Items.AddRange(IO.Directory.GetFiles(txtDir.Text))
        pings.Text = Val(pings.Text) + 1

        nSuffix = Val(tsSuffix.Text)

        If rbPlaceholder.Checked = True Then
            FileSuffix = nSuffix.ToString("D4")
        Else
            FileSuffix = tsSuffix.Text
        End If


        FilePrefix = Replace(txtPrefix.Text, "#", txtNN.Text)


        Dim list1 = From li In lbControl.Items Select li
        Dim list2 = From li In lbScanned.Items Select li
        Dim list3 = list1.Except(list2).Union(list2.Except(list1))
        txtDif.Text = String.Join(Environment.NewLine, list3)
ExistError:
        If txtDif.Text <> "" Then
            targetF = My.Computer.FileSystem.GetFileInfo(txtDif.Text)
            tsRenamed.Text = Val(tsRenamed.Text) + 1

            If cbExtension.Checked = True Then
                FileExtension = targetF.Extension
                NewName = FilePrefix & FileSuffix & FileExtension
            Else
                NewName = FilePrefix & FileSuffix
            End If

            txtRen.Text = NewName

            If System.IO.File.Exists(txtDir.Text & "\" & NewName) Then 'if the file already exists
                If rbPlaceholder.Checked = True Then
                    nSuffix = Val(FileSuffix) + 1
                    FileSuffix = nSuffix.ToString("D4")
                    tsSuffix.Text = FileSuffix
                Else
                    FileSuffix = Val(FileSuffix) + 1
                    tsSuffix.Text = FileSuffix
                End If
                GoTo ExistError
            Else 'if the file does not exist
                My.Computer.FileSystem.RenameFile(targetF.FullName, NewName)
            End If

            lbControl.Items.Clear()
            lbControl.Items.AddRange(IO.Directory.GetFiles(txtDir.Text))

        End If


    End Sub

    Private Sub cmdHelpPrefix_Click(sender As Object, e As EventArgs) Handles cmdHelpPrefix.Click
        MsgBox("The file prefix is what all new incoming files will have as their name.  Include an underscores or spaces here as appropriate.  The suffix is attached immediately after the prefix.  Please use characters that are appropriate for file naming conventions.")
    End Sub

    Private Sub cmdSetSpeed_Click(sender As Object, e As EventArgs) Handles cmdSetSpeed.Click
        Timer.Interval = txtSpeed.Text
        If rbSingle.Checked = True Then
            tsSuffix.Text = "0"
        ElseIf rbPlaceholder.Checked = True Then
            tsSuffix.Text = "0000"
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click
        If Me.Width = 450 Then
            Me.Width = 890
        Else
            Me.Width = 450
        End If
    End Sub


    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtNN.Text) + 1
        SuffixIndex = pSuffix.ToString("D2")

        txtNN.Text = SuffixIndex

    End Sub

    Private Sub txtNN_TextChanged(sender As Object, e As EventArgs) Handles txtNN.TextChanged
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtNN.Text)
        SuffixIndex = pSuffix.ToString("D2")

        If SuffixIndex >= 100 Then
            SuffixIndex = "99"
            TimerNN.Enabled = False
            TimerNN2.Enabled = False
        ElseIf SuffixIndex <= 0 Then
            SuffixIndex = "00"
            TimerNN.Enabled = False
            TimerNN2.Enabled = False
        End If

        txtNN.Text = SuffixIndex
    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtNN.Text) - 1
        SuffixIndex = pSuffix.ToString("D2")

        txtNN.Text = SuffixIndex
    End Sub

    Private Sub cmdUp_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdUp.MouseDown
        NNDirection = 1
        TimerNN.Enabled = True
    End Sub

    Private Sub TimerNN_Tick(sender As Object, e As EventArgs) Handles TimerNN.Tick
        Dim pSuffix As Int32
        Dim SuffixIndex As String



        If NNDirection = 1 Then
            pSuffix = Val(txtNN.Text) + 1
            SuffixIndex = pSuffix.ToString("D2")
            txtNN.Text = SuffixIndex
        ElseIf NNDirection = 0 Then
            pSuffix = Val(txtNN.Text) - 1
            SuffixIndex = pSuffix.ToString("D2")
            txtNN.Text = SuffixIndex
        End If

        TimerNN2.Enabled = True
        TimerNN.Enabled = False

    End Sub

    Private Sub cmdUp_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdUp.MouseUp
        TimerNN.Enabled = False
        TimerNN2.Enabled = False
    End Sub

    Private Sub cmdDown_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdDown.MouseDown
        NNDirection = 0
        TimerNN.Enabled = True
    End Sub

    Private Sub cmdDown_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdDown.MouseUp
        TimerNN.Enabled = False
        TimerNN2.Enabled = False
    End Sub

    Private Sub TimerNN2_Tick(sender As Object, e As EventArgs) Handles TimerNN2.Tick
        Dim pSuffix As Int32
        Dim SuffixIndex As String



        If NNDirection = 1 Then
            pSuffix = Val(txtNN.Text) + 1
            SuffixIndex = pSuffix.ToString("D2")
            txtNN.Text = SuffixIndex
        ElseIf NNDirection = 0 Then
            pSuffix = Val(txtNN.Text) - 1
            SuffixIndex = pSuffix.ToString("D2")
            txtNN.Text = SuffixIndex
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(Replace(txtPrefix.Text, "#", txtNN.Text))
    End Sub

    Private Sub frmNFI_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'Delimiter: |
        'Index
        '	0	Directory		txtDirectory.text
        '	1	Prefix			txtPrefix.text
        '	2	# Index			txtNN.text
        '	3	Suffix			0 for straight, 1 for placeholder
        '	4	Maint. Ext		0 for no,	1 for yes
        '	5	Scan Int		numeric	
        '	6	Recall Set		0 for no, 1 for yes
        If cbSave.Checked = True Then
            PrefSave()
        End If
    End Sub
    Private Sub PrefSave()
        Dim SaveString As String
        Dim nString(6) As String


        nString(0) = txtDir.Text
        nString(1) = txtPrefix.Text
        nString(2) = txtNN.Text
        nString(3) = rbPlaceholder.Checked
        nString(4) = cbExtension.Checked
        nString(5) = txtSpeed.Text
        nString(6) = cbSave.Checked

        SaveString = ""

        For n = 0 To 6
            SaveString = SaveString & nString(n) & "|"
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\config.dat", SaveString, False)
    End Sub
    Private Sub PrefLoad()
        Dim LoadData As String
        Dim nLoad(6) As String

        LoadData = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\config.dat")
        nLoad = LoadData.Split("|")


        If nLoad(6) = "True" Then
            cbSave.Checked = True

            txtDir.Text = nLoad(0)
            Browser1.SelectedPath = nLoad(0)
            txtPrefix.Text = nLoad(1)
            txtNN.Text = nLoad(2)
            txtSpeed.Text = nLoad(5)

            If nLoad(3) = "True" Then
                rbPlaceholder.Checked = True
            Else
                rbSingle.Checked = True
            End If
            If nLoad(4) = "True" Then
                cbExtension.Checked = True
            Else
                cbExtension.Checked = False
            End If
        Else
            cbSave.Checked = False
        End If


    End Sub

    Private Sub frmNFI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrefLoad()
    End Sub

    Private Sub TimerCB_Tick(sender As Object, e As EventArgs) Handles TimerCB.Tick
        On Error Resume Next

        Dim CurrentCB As String ' = My.Computer.Clipboard.GetText()
        Dim CBArray() As String
        Dim cbCount As Integer
        Dim NewCB As String

        CurrentCB = My.Computer.Clipboard.GetText()

        If CurrentCB <> txtCBNew.Text Then
            CBArray = CurrentCB.Split("/")

            cbCount = Str(txtN.Text)

            NewCB = txtCBPre.Text & CBArray(cbCount) & txtCBSuf.Text
            My.Computer.Clipboard.SetText(NewCB)
            txtCBNew.Text = NewCB
            If frmBrowse.Visible = True Then
                frmBrowse.wb.Navigate(NewCB)
            End If
        End If




    End Sub

    Private Sub cmdCBH_Click(sender As Object, e As EventArgs) Handles cmdCBH.Click
        Dim CurrentCB As String = My.Computer.Clipboard.GetText()
        txtCBOld.Text = CurrentCB

        If TimerCB.Enabled = True Then
            TimerCB.Enabled = False
        Else
            TimerCB.Enabled = True

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TimerCB2_Tick(sender As Object, e As EventArgs) Handles TimerCB2.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBrowse.Show()

    End Sub
End Class
