Public Class frmMain
    Dim nSuffix As Int32

    Private Sub dBug(wut As String)
        txtDebug.Text = txtDebug.Text & wut & vbCrLf
    End Sub
    Private Sub frmMain_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If cbSettings.Checked = True Then
            PrefSave()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrefLoad()
        nSuffix = 0
        lblSuffix.Text = nSuffix
    End Sub

    Private Sub PrefSave()
        Dim SaveString As String
        Dim nString(6) As String


        nString(0) = cbSettings.Checked
        nString(1) = txtDir.Text
        nString(2) = txtPrefix.Text
        nString(3) = txtIndex.Text
        nString(4) = cbOnTop.Checked
        nString(5) = rbPlaceholder.Checked
        nString(6) = cbExtension.Checked

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

        If nLoad(0) = "True" Then
            cbSettings.Checked = True
            txtDir.Text = nLoad(1)
            DirBrowse.SelectedPath = nLoad(1)
            txtPrefix.Text = nLoad(2)
            txtIndex.Text = nLoad(3)

            If nLoad(4) = "True" Then
                cbOnTop.Checked = True
            Else
                cbOnTop.Checked = False
            End If

            If nLoad(5) = "True" Then
                rbPlaceholder.Checked = True
            Else
                rbStraight.Checked = True
            End If

            If nLoad(6) = "True" Then
                cbExtension.Checked = True
            Else
                cbExtension.Checked = False
            End If

        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmdDir_Click(sender As Object, e As EventArgs) Handles cmdDir.Click
        DirBrowse.ShowDialog()

        If DirBrowse.SelectedPath <> "" Then
            txtDir.Text = DirBrowse.SelectedPath
        Else
            txtDir.Text = "ERROR!"
        End If
    End Sub

    Private Sub cbOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles cbOnTop.CheckedChanged
        If cbOnTop.Checked = True Then
            Me.TopMost = True
        ElseIf cbOnTop.Checked = False Then
            Me.TopMost = False
        End If
    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click
        If Me.Width = 450 Then
            Me.Width = 790
        Else
            Me.Width = 450
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If Me.Height = 325 Then
            Me.Height = 130
            Me.Width = 450
        Else
            Me.Height = 325
            Me.Width = 450
        End If
    End Sub

    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtIndex.Text) + 1
        SuffixIndex = pSuffix.ToString("D2")

        txtIndex.Text = SuffixIndex
    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtIndex.Text) - 1
        SuffixIndex = pSuffix.ToString("D2")

        txtIndex.Text = SuffixIndex
    End Sub

    Private Sub txtIndex_TextChanged(sender As Object, e As EventArgs) Handles txtIndex.TextChanged
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtIndex.Text)
        SuffixIndex = pSuffix.ToString("D2")

        If SuffixIndex >= 100 Then
            SuffixIndex = "99"
        ElseIf SuffixIndex <= 0 Then
            SuffixIndex = "00"
        End If

        txtIndex.Text = SuffixIndex
        lblIndex.Text = SuffixIndex

        lblSuffix.Text = "0"
        nSuffix = 0

    End Sub

    Private Sub cmdUp2_Click(sender As Object, e As EventArgs) Handles cmdUp2.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtIndex.Text) + 1
        SuffixIndex = pSuffix.ToString("D2")

        txtIndex.Text = SuffixIndex
    End Sub

    Private Sub cmdDown2_Click(sender As Object, e As EventArgs) Handles cmdDown2.Click
        Dim pSuffix As Int32
        Dim SuffixIndex As String

        pSuffix = Val(txtIndex.Text) - 1
        SuffixIndex = pSuffix.ToString("D2")

        txtIndex.Text = SuffixIndex
    End Sub

    Private Sub DirBrowse_HelpRequest(sender As Object, e As EventArgs) Handles DirBrowse.HelpRequest

    End Sub

    Private Sub DirWatch_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles DirWatch.Changed

    End Sub

    Private Sub DirWatch_Created(sender As Object, e As IO.FileSystemEventArgs) Handles DirWatch.Created
        Dim targetF As System.IO.FileInfo
        Dim NewName As String
        Dim FileSuffix As String
        Dim FileExtension As String
        Dim FilePrefix As String
        Dim FileRen As String

        dBug("File: " & e.FullPath.ToString & " @ " & System.DateTime.Now)
        targetF = My.Computer.FileSystem.GetFileInfo(e.FullPath.ToString)


        If rbPlaceholder.Checked = True Then
            FileSuffix = nSuffix.ToString("D4")
        Else
            FileSuffix = nSuffix
        End If

        FilePrefix = Replace(txtPrefix.Text, "#", txtIndex.Text)
        FileExtension = targetF.Extension

ExistError:


        dBug("Target File: " & e.FullPath.ToString)

        If cbExtension.Checked = True Then
            NewName = FilePrefix & FileSuffix & FileExtension
        Else
            NewName = FilePrefix & FileSuffix & txtExtension.Text
        End If

        FileRen = NewName

        dBug("--Renaming to " & FileRen)
        If System.IO.File.Exists(targetF.FullName) Then 'if the Target exists
            If System.IO.File.Exists(txtDir.Text & "\" & NewName) Then 'if the renamed file already exists
                dBug("---Error! " & txtDir.Text & "\" & NewName & " already exists!")
                If rbPlaceholder.Checked = True Then
                    nSuffix = Val(FileSuffix) + 1
                    FileSuffix = nSuffix.ToString("D4")
                    lblSuffix.Text = FileSuffix
                Else
                    FileSuffix = Val(FileSuffix) + 1
                    lblSuffix.Text = FileSuffix
                End If
                GoTo ExistError
            Else 'if the renamed file does not exist
                My.Computer.FileSystem.RenameFile(targetF.FullName, NewName)
                If rbPlaceholder.Checked = True Then
                    nSuffix = Val(FileSuffix) + 1
                    FileSuffix = nSuffix.ToString("D4")
                    lblSuffix.Text = FileSuffix
                Else
                    FileSuffix = Val(FileSuffix) + 1
                    lblSuffix.Text = FileSuffix
                End If
                GoTo EndTheSub
            End If
        End If
EndTheSub:

    End Sub

    Private Sub txtDir_TextChanged(sender As Object, e As EventArgs) Handles txtDir.TextChanged
        On Error GoTo ErrorHappened
        DirWatch.Path = txtDir.Text
ErrorHappened:
        Return
    End Sub
End Class
