<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GBASD = New System.Windows.Forms.TextBox()
        Me.RefreshGBA = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EverdriveTab = New System.Windows.Forms.DataGridView()
        Me.BatoceraTab = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BatoceraPath = New System.Windows.Forms.TextBox()
        Me.RefreshBatocera = New System.Windows.Forms.Button()
        Me.GBAtoBato = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CalculateDelta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupGBA = New System.Windows.Forms.GroupBox()
        Me.GroupBatocera = New System.Windows.Forms.GroupBox()
        Me.BatotoGBA = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EverdriveTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatoceraTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGBA.SuspendLayout()
        Me.GroupBatocera.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBASD
        '
        Me.GBASD.Location = New System.Drawing.Point(213, 65)
        Me.GBASD.Name = "GBASD"
        Me.GBASD.Size = New System.Drawing.Size(27, 20)
        Me.GBASD.TabIndex = 0
        Me.GBASD.Text = "E:\"
        '
        'RefreshGBA
        '
        Me.RefreshGBA.Location = New System.Drawing.Point(167, 91)
        Me.RefreshGBA.Name = "RefreshGBA"
        Me.RefreshGBA.Size = New System.Drawing.Size(118, 35)
        Me.RefreshGBA.TabIndex = 1
        Me.RefreshGBA.Text = "Refresh Files"
        Me.RefreshGBA.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(725, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Everdrive GBA Saves to Batocera Sync v1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Drive Letter of your SD :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EverdriveTab
        '
        Me.EverdriveTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EverdriveTab.Location = New System.Drawing.Point(6, 12)
        Me.EverdriveTab.Name = "EverdriveTab"
        Me.EverdriveTab.Size = New System.Drawing.Size(392, 154)
        Me.EverdriveTab.TabIndex = 9
        '
        'BatoceraTab
        '
        Me.BatoceraTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatoceraTab.Location = New System.Drawing.Point(6, 15)
        Me.BatoceraTab.Name = "BatoceraTab"
        Me.BatoceraTab.Size = New System.Drawing.Size(392, 154)
        Me.BatoceraTab.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(612, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Main Batocera Path :"
        '
        'BatoceraPath
        '
        Me.BatoceraPath.Location = New System.Drawing.Point(339, 51)
        Me.BatoceraPath.Name = "BatoceraPath"
        Me.BatoceraPath.Size = New System.Drawing.Size(380, 20)
        Me.BatoceraPath.TabIndex = 11
        Me.BatoceraPath.Text = "D:\Documents\a-Emulation et Jeux\Recalbox et Batocera\PI4Hybrid\batocera\"
        Me.BatoceraPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RefreshBatocera
        '
        Me.RefreshBatocera.Location = New System.Drawing.Point(608, 91)
        Me.RefreshBatocera.Name = "RefreshBatocera"
        Me.RefreshBatocera.Size = New System.Drawing.Size(111, 35)
        Me.RefreshBatocera.TabIndex = 14
        Me.RefreshBatocera.Text = "Refresh Files"
        Me.RefreshBatocera.UseVisualStyleBackColor = True
        '
        'GBAtoBato
        '
        Me.GBAtoBato.Location = New System.Drawing.Point(98, 381)
        Me.GBAtoBato.Name = "GBAtoBato"
        Me.GBAtoBato.Size = New System.Drawing.Size(214, 30)
        Me.GBAtoBato.TabIndex = 15
        Me.GBAtoBato.Text = "Copy Everdrive Saves --> Batocera Saves"
        Me.GBAtoBato.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 189)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(184, 186)
        Me.ListBox1.TabIndex = 16
        '
        'CalculateDelta
        '
        Me.CalculateDelta.Location = New System.Drawing.Point(339, 91)
        Me.CalculateDelta.Name = "CalculateDelta"
        Me.CalculateDelta.Size = New System.Drawing.Size(164, 35)
        Me.CalculateDelta.TabIndex = 21
        Me.CalculateDelta.Text = "Filling Listboxes with Saves"
        Me.CalculateDelta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "FROM"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(214, 189)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(184, 186)
        Me.ListBox2.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "TO"
        '
        'GroupGBA
        '
        Me.GroupGBA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupGBA.Controls.Add(Me.EverdriveTab)
        Me.GroupGBA.Controls.Add(Me.GBAtoBato)
        Me.GroupGBA.Controls.Add(Me.ListBox1)
        Me.GroupGBA.Controls.Add(Me.Label5)
        Me.GroupGBA.Controls.Add(Me.ListBox2)
        Me.GroupGBA.Controls.Add(Me.Label6)
        Me.GroupGBA.Location = New System.Drawing.Point(17, 132)
        Me.GroupGBA.Name = "GroupGBA"
        Me.GroupGBA.Size = New System.Drawing.Size(405, 417)
        Me.GroupGBA.TabIndex = 34
        Me.GroupGBA.TabStop = False
        Me.GroupGBA.Text = "Everdrive to Batocera"
        '
        'GroupBatocera
        '
        Me.GroupBatocera.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBatocera.Controls.Add(Me.BatotoGBA)
        Me.GroupBatocera.Controls.Add(Me.ListBox3)
        Me.GroupBatocera.Controls.Add(Me.BatoceraTab)
        Me.GroupBatocera.Controls.Add(Me.Label7)
        Me.GroupBatocera.Controls.Add(Me.Label8)
        Me.GroupBatocera.Controls.Add(Me.ListBox4)
        Me.GroupBatocera.Location = New System.Drawing.Point(428, 132)
        Me.GroupBatocera.Name = "GroupBatocera"
        Me.GroupBatocera.Size = New System.Drawing.Size(405, 417)
        Me.GroupBatocera.TabIndex = 36
        Me.GroupBatocera.TabStop = False
        Me.GroupBatocera.Text = "Batocera to Everdrive"
        '
        'BatotoGBA
        '
        Me.BatotoGBA.Location = New System.Drawing.Point(95, 381)
        Me.BatotoGBA.Name = "BatotoGBA"
        Me.BatotoGBA.Size = New System.Drawing.Size(214, 27)
        Me.BatotoGBA.TabIndex = 25
        Me.BatotoGBA.Text = "Copy Batocera Saves --> Everdrive Saves"
        Me.BatotoGBA.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(6, 192)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox3.Size = New System.Drawing.Size(184, 186)
        Me.ListBox3.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "FROM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "TO"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(214, 192)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox4.Size = New System.Drawing.Size(184, 186)
        Me.ListBox4.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 553)
        Me.Controls.Add(Me.GroupBatocera)
        Me.Controls.Add(Me.GroupGBA)
        Me.Controls.Add(Me.CalculateDelta)
        Me.Controls.Add(Me.RefreshBatocera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BatoceraPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RefreshGBA)
        Me.Controls.Add(Me.GBASD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EverdriveTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatoceraTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGBA.ResumeLayout(False)
        Me.GroupGBA.PerformLayout()
        Me.GroupBatocera.ResumeLayout(False)
        Me.GroupBatocera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBASD As TextBox
    Friend WithEvents RefreshGBA As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EverdriveTab As DataGridView
    Friend WithEvents BatoceraTab As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BatoceraPath As TextBox
    Friend WithEvents RefreshBatocera As Button
    Friend WithEvents GBAtoBato As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CalculateDelta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupGBA As GroupBox
    Friend WithEvents GroupBatocera As GroupBox
    Friend WithEvents BatotoGBA As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox4 As ListBox
End Class
