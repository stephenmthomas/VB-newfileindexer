<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.DirBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.DirWatch = New System.IO.FileSystemWatcher()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.cmdDir = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbOnTop = New System.Windows.Forms.CheckBox()
        Me.cbSettings = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbExtension = New System.Windows.Forms.CheckBox()
        Me.rbPlaceholder = New System.Windows.Forms.RadioButton()
        Me.rbStraight = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.cmdDown2 = New System.Windows.Forms.Button()
        Me.cmdUp2 = New System.Windows.Forms.Button()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.cmdDebug = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        CType(Me.DirWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirBrowse
        '
        '
        'DirWatch
        '
        Me.DirWatch.EnableRaisingEvents = True
        Me.DirWatch.SynchronizingObject = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directory"
        '
        'txtDir
        '
        Me.txtDir.Enabled = False
        Me.txtDir.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(7, 19)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(399, 16)
        Me.txtDir.TabIndex = 0
        Me.txtDir.Text = "C:\Windows\"
        '
        'cmdDir
        '
        Me.cmdDir.Location = New System.Drawing.Point(267, 61)
        Me.cmdDir.Name = "cmdDir"
        Me.cmdDir.Size = New System.Drawing.Size(157, 22)
        Me.cmdDir.TabIndex = 1
        Me.cmdDir.Text = "Select Directory"
        Me.cmdDir.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(12, 61)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(157, 22)
        Me.cmdOptions.TabIndex = 2
        Me.cmdOptions.Text = "Toggle Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDebug)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 175)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbOnTop)
        Me.GroupBox5.Controls.Add(Me.cbSettings)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 109)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(219, 59)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "General Options"
        '
        'cbOnTop
        '
        Me.cbOnTop.AutoSize = True
        Me.cbOnTop.Location = New System.Drawing.Point(6, 38)
        Me.cbOnTop.Name = "cbOnTop"
        Me.cbOnTop.Size = New System.Drawing.Size(115, 15)
        Me.cbOnTop.TabIndex = 3
        Me.cbOnTop.Text = "Always On Top"
        Me.cbOnTop.UseVisualStyleBackColor = True
        '
        'cbSettings
        '
        Me.cbSettings.AutoSize = True
        Me.cbSettings.Location = New System.Drawing.Point(6, 17)
        Me.cbSettings.Name = "cbSettings"
        Me.cbSettings.Size = New System.Drawing.Size(143, 15)
        Me.cbSettings.TabIndex = 2
        Me.cbSettings.Text = "Remember Settings"
        Me.cbSettings.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExtension)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblSuffix)
        Me.GroupBox4.Controls.Add(Me.cbExtension)
        Me.GroupBox4.Controls.Add(Me.rbPlaceholder)
        Me.GroupBox4.Controls.Add(Me.rbStraight)
        Me.GroupBox4.Location = New System.Drawing.Point(232, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 117)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Suffix Options"
        '
        'cbExtension
        '
        Me.cbExtension.AutoSize = True
        Me.cbExtension.Location = New System.Drawing.Point(12, 64)
        Me.cbExtension.Name = "cbExtension"
        Me.cbExtension.Size = New System.Drawing.Size(150, 15)
        Me.cbExtension.TabIndex = 2
        Me.cbExtension.Text = "Maintain Extension"
        Me.cbExtension.UseVisualStyleBackColor = True
        '
        'rbPlaceholder
        '
        Me.rbPlaceholder.AutoSize = True
        Me.rbPlaceholder.Checked = True
        Me.rbPlaceholder.Location = New System.Drawing.Point(12, 43)
        Me.rbPlaceholder.Name = "rbPlaceholder"
        Me.rbPlaceholder.Size = New System.Drawing.Size(156, 15)
        Me.rbPlaceholder.TabIndex = 1
        Me.rbPlaceholder.TabStop = True
        Me.rbPlaceholder.Text = "Placeholder Numeric"
        Me.rbPlaceholder.UseVisualStyleBackColor = True
        '
        'rbStraight
        '
        Me.rbStraight.AutoSize = True
        Me.rbStraight.Location = New System.Drawing.Point(12, 22)
        Me.rbStraight.Name = "rbStraight"
        Me.rbStraight.Size = New System.Drawing.Size(135, 15)
        Me.rbStraight.TabIndex = 0
        Me.rbStraight.Text = "Straight Numeric"
        Me.rbStraight.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdDown)
        Me.GroupBox3.Controls.Add(Me.cmdUp)
        Me.GroupBox3.Controls.Add(Me.txtIndex)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtPrefix)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 86)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prefix Options"
        '
        'cmdDown
        '
        Me.cmdDown.Location = New System.Drawing.Point(101, 60)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(25, 19)
        Me.cmdDown.TabIndex = 7
        Me.cmdDown.Text = "<"
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.Location = New System.Drawing.Point(188, 60)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(25, 19)
        Me.cmdUp.TabIndex = 6
        Me.cmdUp.Text = ">"
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(132, 60)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(50, 18)
        Me.txtIndex.TabIndex = 5
        Me.txtIndex.Text = "00"
        Me.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 11)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "'#' Index:"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(101, 24)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(112, 18)
        Me.txtPrefix.TabIndex = 3
        Me.txtPrefix.Text = "#_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 11)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File Prefix:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDebug)
        Me.GroupBox6.Location = New System.Drawing.Point(451, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(311, 263)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Debug"
        '
        'txtDebug
        '
        Me.txtDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDebug.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebug.Location = New System.Drawing.Point(3, 14)
        Me.txtDebug.Multiline = True
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDebug.Size = New System.Drawing.Size(305, 246)
        Me.txtDebug.TabIndex = 0
        Me.txtDebug.WordWrap = False
        '
        'cmdDown2
        '
        Me.cmdDown2.Location = New System.Drawing.Point(180, 64)
        Me.cmdDown2.Name = "cmdDown2"
        Me.cmdDown2.Size = New System.Drawing.Size(25, 19)
        Me.cmdDown2.TabIndex = 9
        Me.cmdDown2.Text = "<"
        Me.cmdDown2.UseVisualStyleBackColor = True
        '
        'cmdUp2
        '
        Me.cmdUp2.Location = New System.Drawing.Point(236, 63)
        Me.cmdUp2.Name = "cmdUp2"
        Me.cmdUp2.Size = New System.Drawing.Size(25, 19)
        Me.cmdUp2.TabIndex = 8
        Me.cmdUp2.Text = ">"
        Me.cmdUp2.UseVisualStyleBackColor = True
        '
        'lblIndex
        '
        Me.lblIndex.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblIndex.Location = New System.Drawing.Point(206, 64)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(28, 18)
        Me.lblIndex.TabIndex = 10
        Me.lblIndex.Text = "00"
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSuffix
        '
        Me.lblSuffix.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuffix.ForeColor = System.Drawing.Color.Maroon
        Me.lblSuffix.Location = New System.Drawing.Point(119, -3)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(43, 18)
        Me.lblSuffix.TabIndex = 11
        Me.lblSuffix.Text = "00"
        Me.lblSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdDebug
        '
        Me.cmdDebug.Location = New System.Drawing.Point(232, 140)
        Me.cmdDebug.Name = "cmdDebug"
        Me.cmdDebug.Size = New System.Drawing.Size(169, 22)
        Me.cmdDebug.TabIndex = 10
        Me.cmdDebug.Text = "Toggle Debug Box"
        Me.cmdDebug.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 11)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Use Extension:"
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(119, 85)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(45, 18)
        Me.txtExtension.TabIndex = 13
        Me.txtExtension.Text = ".jpg"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 286)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.cmdDown2)
        Me.Controls.Add(Me.cmdUp2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "N.F.I. - v.2"
        CType(Me.DirWatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DirBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DirWatch As System.IO.FileSystemWatcher
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOptions As System.Windows.Forms.Button
    Friend WithEvents cmdDir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDown As System.Windows.Forms.Button
    Friend WithEvents cmdUp As System.Windows.Forms.Button
    Friend WithEvents txtIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbExtension As System.Windows.Forms.CheckBox
    Friend WithEvents rbPlaceholder As System.Windows.Forms.RadioButton
    Friend WithEvents rbStraight As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSettings As System.Windows.Forms.CheckBox
    Friend WithEvents cbOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDebug As System.Windows.Forms.TextBox
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents cmdDown2 As System.Windows.Forms.Button
    Friend WithEvents cmdUp2 As System.Windows.Forms.Button
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents cmdDebug As System.Windows.Forms.Button
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
