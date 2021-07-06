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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EverdriveTab = New System.Windows.Forms.DataGridView()
        Me.BatoceraTab = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BatoceraPath = New System.Windows.Forms.TextBox()
        Me.RefreshBatocera = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EverdriveTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatoceraTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBASD
        '
        Me.GBASD.Location = New System.Drawing.Point(129, 182)
        Me.GBASD.Name = "GBASD"
        Me.GBASD.Size = New System.Drawing.Size(27, 20)
        Me.GBASD.TabIndex = 0
        Me.GBASD.Text = "E:\"
        '
        'RefreshGBA
        '
        Me.RefreshGBA.Location = New System.Drawing.Point(28, 213)
        Me.RefreshGBA.Name = "RefreshGBA"
        Me.RefreshGBA.Size = New System.Drawing.Size(111, 23)
        Me.RefreshGBA.TabIndex = 1
        Me.RefreshGBA.Text = "Refresh Files"
        Me.RefreshGBA.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Everdrive GBA Saves to Batocera Sync"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Drive Letter of your SD :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Saves Files :"
        '
        'EverdriveTab
        '
        Me.EverdriveTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EverdriveTab.Location = New System.Drawing.Point(181, 52)
        Me.EverdriveTab.Name = "EverdriveTab"
        Me.EverdriveTab.Size = New System.Drawing.Size(392, 184)
        Me.EverdriveTab.TabIndex = 9
        '
        'BatoceraTab
        '
        Me.BatoceraTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatoceraTab.Location = New System.Drawing.Point(181, 254)
        Me.BatoceraTab.Name = "BatoceraTab"
        Me.BatoceraTab.Size = New System.Drawing.Size(392, 184)
        Me.BatoceraTab.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Main Batocera Path :"
        '
        'BatoceraPath
        '
        Me.BatoceraPath.Location = New System.Drawing.Point(12, 410)
        Me.BatoceraPath.Name = "BatoceraPath"
        Me.BatoceraPath.Size = New System.Drawing.Size(144, 20)
        Me.BatoceraPath.TabIndex = 11
        Me.BatoceraPath.Text = "D:\Documents\a-Emulation et Jeux\Recalbox et Batocera\PI4Hybrid\batocera\"
        '
        'RefreshBatocera
        '
        Me.RefreshBatocera.Location = New System.Drawing.Point(28, 436)
        Me.RefreshBatocera.Name = "RefreshBatocera"
        Me.RefreshBatocera.Size = New System.Drawing.Size(111, 23)
        Me.RefreshBatocera.TabIndex = 14
        Me.RefreshBatocera.Text = "Refresh Files"
        Me.RefreshBatocera.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(619, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Everdrive --> Batocera"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(619, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(204, 95)
        Me.ListBox1.TabIndex = 16
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(619, 213)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(204, 95)
        Me.ListBox2.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(619, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(204, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Batocera --> Everdrive"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(619, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(204, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Full Sync (Most Up to Date File)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(619, 343)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(204, 95)
        Me.ListBox3.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 496)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RefreshBatocera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BatoceraPath)
        Me.Controls.Add(Me.BatoceraTab)
        Me.Controls.Add(Me.EverdriveTab)
        Me.Controls.Add(Me.Label3)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBASD As TextBox
    Friend WithEvents RefreshGBA As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EverdriveTab As DataGridView
    Friend WithEvents BatoceraTab As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BatoceraPath As TextBox
    Friend WithEvents RefreshBatocera As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox3 As ListBox
End Class
