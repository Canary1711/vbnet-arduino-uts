<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.lampTab = New System.Windows.Forms.TabPage()
        Me.lampDapur = New MetroFramework.Controls.MetroTile()
        Me.lampMandi = New MetroFramework.Controls.MetroTile()
        Me.lampKamar = New MetroFramework.Controls.MetroTile()
        Me.lampKamar2 = New MetroFramework.Controls.MetroTile()
        Me.windowTab = New System.Windows.Forms.TabPage()
        Me.curtainTab = New System.Windows.Forms.TabPage()
        Me.lampTamu = New MetroFramework.Controls.MetroTile()
        Me.btnAllLamp = New MetroFramework.Controls.MetroButton()
        Me.btnWindow = New MetroFramework.Controls.MetroButton()
        Me.btnDoor = New MetroFramework.Controls.MetroButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.lampTab.SuspendLayout()
        Me.windowTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.lampTab)
        Me.MetroTabControl1.Controls.Add(Me.windowTab)
        Me.MetroTabControl1.Controls.Add(Me.curtainTab)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(632, 384)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'lampTab
        '
        Me.lampTab.Controls.Add(Me.btnAllLamp)
        Me.lampTab.Controls.Add(Me.lampTamu)
        Me.lampTab.Controls.Add(Me.lampDapur)
        Me.lampTab.Controls.Add(Me.lampMandi)
        Me.lampTab.Controls.Add(Me.lampKamar)
        Me.lampTab.Controls.Add(Me.lampKamar2)
        Me.lampTab.Location = New System.Drawing.Point(4, 38)
        Me.lampTab.Name = "lampTab"
        Me.lampTab.Size = New System.Drawing.Size(624, 342)
        Me.lampTab.TabIndex = 0
        Me.lampTab.Text = "Lamp"
        '
        'lampDapur
        '
        Me.lampDapur.ActiveControl = Nothing
        Me.lampDapur.Location = New System.Drawing.Point(365, 30)
        Me.lampDapur.Name = "lampDapur"
        Me.lampDapur.Size = New System.Drawing.Size(240, 120)
        Me.lampDapur.TabIndex = 3
        Me.lampDapur.Text = "Dapur"
        Me.lampDapur.UseSelectable = True
        '
        'lampMandi
        '
        Me.lampMandi.ActiveControl = Nothing
        Me.lampMandi.Location = New System.Drawing.Point(18, 210)
        Me.lampMandi.Name = "lampMandi"
        Me.lampMandi.Size = New System.Drawing.Size(85, 85)
        Me.lampMandi.TabIndex = 2
        Me.lampMandi.Text = "Kamar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mandi"
        Me.lampMandi.UseSelectable = True
        '
        'lampKamar
        '
        Me.lampKamar.ActiveControl = Nothing
        Me.lampKamar.Location = New System.Drawing.Point(150, 30)
        Me.lampKamar.Name = "lampKamar"
        Me.lampKamar.Size = New System.Drawing.Size(120, 120)
        Me.lampKamar.TabIndex = 1
        Me.lampKamar.Text = "Kamar"
        Me.lampKamar.UseSelectable = True
        '
        'lampKamar2
        '
        Me.lampKamar2.ActiveControl = Nothing
        Me.lampKamar2.Location = New System.Drawing.Point(18, 30)
        Me.lampKamar2.Name = "lampKamar2"
        Me.lampKamar2.Size = New System.Drawing.Size(120, 120)
        Me.lampKamar2.TabIndex = 0
        Me.lampKamar2.Text = "Kamar 2"
        Me.lampKamar2.UseSelectable = True
        '
        'windowTab
        '
        Me.windowTab.Controls.Add(Me.btnDoor)
        Me.windowTab.Controls.Add(Me.PictureBox2)
        Me.windowTab.Controls.Add(Me.btnWindow)
        Me.windowTab.Controls.Add(Me.PictureBox1)
        Me.windowTab.Location = New System.Drawing.Point(4, 38)
        Me.windowTab.Name = "windowTab"
        Me.windowTab.Size = New System.Drawing.Size(624, 342)
        Me.windowTab.TabIndex = 1
        Me.windowTab.Text = "Window && Door"
        '
        'curtainTab
        '
        Me.curtainTab.Location = New System.Drawing.Point(4, 38)
        Me.curtainTab.Name = "curtainTab"
        Me.curtainTab.Size = New System.Drawing.Size(624, 342)
        Me.curtainTab.TabIndex = 2
        Me.curtainTab.Text = "Curtain"
        '
        'lampTamu
        '
        Me.lampTamu.ActiveControl = Nothing
        Me.lampTamu.Location = New System.Drawing.Point(365, 185)
        Me.lampTamu.Name = "lampTamu"
        Me.lampTamu.Size = New System.Drawing.Size(240, 112)
        Me.lampTamu.TabIndex = 4
        Me.lampTamu.Text = "Ruang Tamu"
        Me.lampTamu.UseSelectable = True
        '
        'btnAllLamp
        '
        Me.btnAllLamp.Location = New System.Drawing.Point(256, 316)
        Me.btnAllLamp.Name = "btnAllLamp"
        Me.btnAllLamp.Size = New System.Drawing.Size(88, 31)
        Me.btnAllLamp.TabIndex = 5
        Me.btnAllLamp.Text = "Turn All Lamp"
        Me.btnAllLamp.UseSelectable = True
        '
        'btnWindow
        '
        Me.btnWindow.Location = New System.Drawing.Point(200, 150)
        Me.btnWindow.Name = "btnWindow"
        Me.btnWindow.Size = New System.Drawing.Size(85, 35)
        Me.btnWindow.TabIndex = 1
        Me.btnWindow.Text = "Open"
        Me.btnWindow.UseSelectable = True
        '
        'btnDoor
        '
        Me.btnDoor.Location = New System.Drawing.Point(370, 150)
        Me.btnDoor.Name = "btnDoor"
        Me.btnDoor.Size = New System.Drawing.Size(85, 35)
        Me.btnDoor.TabIndex = 3
        Me.btnDoor.Text = "Open"
        Me.btnDoor.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.uts.My.Resources.Resources.icons8_door_208px
        Me.PictureBox2.Location = New System.Drawing.Point(350, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.uts.My.Resources.Resources.icons8_frozen_window_480px_2
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(180, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 470)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "Form1"
        Me.Text = "Smart Home"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.lampTab.ResumeLayout(False)
        Me.windowTab.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents lampTab As TabPage
    Friend WithEvents windowTab As TabPage
    Friend WithEvents curtainTab As TabPage
    Friend WithEvents lampKamar2 As MetroFramework.Controls.MetroTile
    Friend WithEvents lampKamar As MetroFramework.Controls.MetroTile
    Friend WithEvents lampMandi As MetroFramework.Controls.MetroTile
    Friend WithEvents lampDapur As MetroFramework.Controls.MetroTile
    Friend WithEvents lampTamu As MetroFramework.Controls.MetroTile
    Friend WithEvents btnAllLamp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnWindow As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDoor As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
