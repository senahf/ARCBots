<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlatStatusBar1 = New ARCBots_API_v4.FlatStatusBar()
        Me.FormSkin1 = New ARCBots_API_v4.FormSkin()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrawinRectangle12 = New ARCBots_API_v4.DrawinRectangle()
        Me.FlatButton4 = New ARCBots_API_v4.FlatButton()
        Me.FlatLabel7 = New ARCBots_API_v4.FlatLabel()
        Me.FlatToggle2 = New ARCBots_API_v4.FlatToggle()
        Me.FlatMini2 = New ARCBots_API_v4.FlatMini()
        Me.FlatClose2 = New ARCBots_API_v4.FlatClose()
        Me.FlatTextBox4 = New ARCBots_API_v4.FlatTextBox()
        Me.FlatLabel6 = New ARCBots_API_v4.FlatLabel()
        Me.FlatTextBox3 = New ARCBots_API_v4.FlatTextBox()
        Me.FlatLabel5 = New ARCBots_API_v4.FlatLabel()
        Me.DrawinRectangle11 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle10 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle9 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle8 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle7 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle6 = New ARCBots_API_v4.DrawinRectangle()
        Me.FlatButton2 = New ARCBots_API_v4.FlatButton()
        Me.DrawinRectangle5 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle4 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle3 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle2 = New ARCBots_API_v4.DrawinRectangle()
        Me.DrawinRectangle1 = New ARCBots_API_v4.DrawinRectangle()
        Me.FlatButton1 = New ARCBots_API_v4.FlatButton()
        Me.FlatMini1 = New ARCBots_API_v4.FlatMini()
        Me.FlatClose1 = New ARCBots_API_v4.FlatClose()
        Me.FlatToggle1 = New ARCBots_API_v4.FlatToggle()
        Me.FlatLabel4 = New ARCBots_API_v4.FlatLabel()
        Me.FlatLabel3 = New ARCBots_API_v4.FlatLabel()
        Me.FlatLabel2 = New ARCBots_API_v4.FlatLabel()
        Me.FlatButton3 = New ARCBots_API_v4.FlatButton()
        Me.FlatTextBox2 = New ARCBots_API_v4.FlatTextBox()
        Me.FlatLabel1 = New ARCBots_API_v4.FlatLabel()
        Me.FlatTextBox1 = New ARCBots_API_v4.FlatTextBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ARCBots Quick Tools v4"
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 231)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = True
        Me.FlatStatusBar1.Size = New System.Drawing.Size(507, 23)
        Me.FlatStatusBar1.TabIndex = 1
        Me.FlatStatusBar1.Text = "ARCBots is currently UP! Please enter your details and press Submit"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle12)
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel7)
        Me.FormSkin1.Controls.Add(Me.FlatToggle2)
        Me.FormSkin1.Controls.Add(Me.FlatMini2)
        Me.FormSkin1.Controls.Add(Me.FlatClose2)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle11)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle10)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle9)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle8)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle7)
        Me.FormSkin1.Controls.Add(Me.DrawinRectangle6)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(507, 254)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "ARCBots Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Choose Color!"
        '
        'DrawinRectangle12
        '
        Me.DrawinRectangle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle12.Location = New System.Drawing.Point(166, 185)
        Me.DrawinRectangle12.Name = "DrawinRectangle12"
        Me.DrawinRectangle12.Selection = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DrawinRectangle12.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle12.TabIndex = 20
        Me.DrawinRectangle12.Text = "DrawinRectangle12"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(438, 3)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(18, 18)
        Me.FlatButton4.TabIndex = 19
        Me.FlatButton4.Text = "."
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(3, 126)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(115, 25)
        Me.FlatLabel7.TabIndex = 18
        Me.FlatLabel7.Text = "Remember:*"
        '
        'FlatToggle2
        '
        Me.FlatToggle2.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle2.Checked = False
        Me.FlatToggle2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle2.Location = New System.Drawing.Point(124, 126)
        Me.FlatToggle2.Name = "FlatToggle2"
        Me.FlatToggle2.Options = ARCBots_API_v4.FlatToggle._Options.Style3
        Me.FlatToggle2.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle2.TabIndex = 17
        Me.FlatToggle2.Text = "FlatToggle2"
        '
        'FlatMini2
        '
        Me.FlatMini2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini2.BackColor = System.Drawing.Color.White
        Me.FlatMini2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini2.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini2.Location = New System.Drawing.Point(462, 3)
        Me.FlatMini2.Name = "FlatMini2"
        Me.FlatMini2.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini2.TabIndex = 16
        Me.FlatMini2.Text = "FlatMini2"
        Me.FlatMini2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose2
        '
        Me.FlatClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose2.BackColor = System.Drawing.Color.White
        Me.FlatClose2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose2.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose2.Location = New System.Drawing.Point(486, 3)
        Me.FlatClose2.Name = "FlatClose2"
        Me.FlatClose2.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose2.TabIndex = 15
        Me.FlatClose2.Text = "FlatClose2"
        Me.FlatClose2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox4
        '
        Me.FlatTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox4.Location = New System.Drawing.Point(124, 91)
        Me.FlatTextBox4.MaxLength = 32767
        Me.FlatTextBox4.Multiline = False
        Me.FlatTextBox4.Name = "FlatTextBox4"
        Me.FlatTextBox4.ReadOnly = False
        Me.FlatTextBox4.Size = New System.Drawing.Size(374, 29)
        Me.FlatTextBox4.TabIndex = 14
        Me.FlatTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox4.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox4.UseSystemPasswordChar = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(31, 91)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(87, 25)
        Me.FlatLabel6.TabIndex = 13
        Me.FlatLabel6.Text = "API Key:*"
        '
        'FlatTextBox3
        '
        Me.FlatTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox3.Location = New System.Drawing.Point(124, 56)
        Me.FlatTextBox3.MaxLength = 32767
        Me.FlatTextBox3.Multiline = False
        Me.FlatTextBox3.Name = "FlatTextBox3"
        Me.FlatTextBox3.ReadOnly = False
        Me.FlatTextBox3.Size = New System.Drawing.Size(371, 29)
        Me.FlatTextBox3.TabIndex = 12
        Me.FlatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox3.TextColor = System.Drawing.Color.Silver
        Me.FlatTextBox3.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(9, 56)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(109, 25)
        Me.FlatLabel5.TabIndex = 11
        Me.FlatLabel5.Text = "Username:*"
        '
        'DrawinRectangle11
        '
        Me.DrawinRectangle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle11.Location = New System.Drawing.Point(88, 185)
        Me.DrawinRectangle11.Name = "DrawinRectangle11"
        Me.DrawinRectangle11.Selection = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.DrawinRectangle11.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle11.TabIndex = 8
        Me.DrawinRectangle11.Text = "DrawinRectangle11"
        '
        'DrawinRectangle10
        '
        Me.DrawinRectangle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle10.Location = New System.Drawing.Point(10, 185)
        Me.DrawinRectangle10.Name = "DrawinRectangle10"
        Me.DrawinRectangle10.Selection = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.DrawinRectangle10.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle10.TabIndex = 7
        Me.DrawinRectangle10.Text = "DrawinRectangle10"
        '
        'DrawinRectangle9
        '
        Me.DrawinRectangle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle9.Location = New System.Drawing.Point(62, 185)
        Me.DrawinRectangle9.Name = "DrawinRectangle9"
        Me.DrawinRectangle9.Selection = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DrawinRectangle9.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle9.TabIndex = 6
        Me.DrawinRectangle9.Text = "DrawinRectangle9"
        '
        'DrawinRectangle8
        '
        Me.DrawinRectangle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle8.Location = New System.Drawing.Point(140, 185)
        Me.DrawinRectangle8.Name = "DrawinRectangle8"
        Me.DrawinRectangle8.Selection = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DrawinRectangle8.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle8.TabIndex = 5
        Me.DrawinRectangle8.Text = "DrawinRectangle8"
        '
        'DrawinRectangle7
        '
        Me.DrawinRectangle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle7.Location = New System.Drawing.Point(36, 185)
        Me.DrawinRectangle7.Name = "DrawinRectangle7"
        Me.DrawinRectangle7.Selection = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.DrawinRectangle7.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle7.TabIndex = 4
        Me.DrawinRectangle7.Text = "DrawinRectangle7"
        '
        'DrawinRectangle6
        '
        Me.DrawinRectangle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle6.Location = New System.Drawing.Point(114, 185)
        Me.DrawinRectangle6.Name = "DrawinRectangle6"
        Me.DrawinRectangle6.Selection = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.DrawinRectangle6.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle6.TabIndex = 3
        Me.DrawinRectangle6.Text = "DrawinRectangle6"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(389, 193)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = True
        Me.FlatButton2.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton2.TabIndex = 2
        Me.FlatButton2.Text = "Submit"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DrawinRectangle5
        '
        Me.DrawinRectangle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle5.Location = New System.Drawing.Point(116, 185)
        Me.DrawinRectangle5.Name = "DrawinRectangle5"
        Me.DrawinRectangle5.Selection = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DrawinRectangle5.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle5.TabIndex = 20
        Me.DrawinRectangle5.Text = "DrawinRectangle5"
        '
        'DrawinRectangle4
        '
        Me.DrawinRectangle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle4.Location = New System.Drawing.Point(11, 185)
        Me.DrawinRectangle4.Name = "DrawinRectangle4"
        Me.DrawinRectangle4.Selection = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DrawinRectangle4.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle4.TabIndex = 19
        Me.DrawinRectangle4.Text = "DrawinRectangle4"
        '
        'DrawinRectangle3
        '
        Me.DrawinRectangle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle3.Location = New System.Drawing.Point(63, 185)
        Me.DrawinRectangle3.Name = "DrawinRectangle3"
        Me.DrawinRectangle3.Selection = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DrawinRectangle3.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle3.TabIndex = 18
        Me.DrawinRectangle3.Text = "DrawinRectangle3"
        '
        'DrawinRectangle2
        '
        Me.DrawinRectangle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle2.Location = New System.Drawing.Point(37, 185)
        Me.DrawinRectangle2.Name = "DrawinRectangle2"
        Me.DrawinRectangle2.Selection = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DrawinRectangle2.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle2.TabIndex = 16
        Me.DrawinRectangle2.Text = "DrawinRectangle2"
        '
        'DrawinRectangle1
        '
        Me.DrawinRectangle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DrawinRectangle1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DrawinRectangle1.Location = New System.Drawing.Point(89, 185)
        Me.DrawinRectangle1.Name = "DrawinRectangle1"
        Me.DrawinRectangle1.Selection = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DrawinRectangle1.Size = New System.Drawing.Size(20, 40)
        Me.DrawinRectangle1.TabIndex = 2
        Me.DrawinRectangle1.Text = "DrawinRectangle1"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(438, 3)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(18, 18)
        Me.FlatButton1.TabIndex = 15
        Me.FlatButton1.Text = "."
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(462, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 14
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(486, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 13
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatToggle1
        '
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = True
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(115, 135)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = ARCBots_API_v4.FlatToggle._Options.Style3
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 12
        Me.FlatToggle1.Text = "FlatToggle1"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(12, 138)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(97, 21)
        Me.FlatLabel4.TabIndex = 11
        Me.FlatLabel4.Text = "Remember:*"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(13, 170)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(101, 13)
        Me.FlatLabel3.TabIndex = 10
        Me.FlatLabel3.Text = "* = Required Field"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(66, 100)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(43, 21)
        Me.FlatLabel2.TabIndex = 9
        Me.FlatLabel2.Text = "API:*"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(389, 193)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = True
        Me.FlatButton3.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton3.TabIndex = 7
        Me.FlatButton3.Text = "Submit"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(116, 100)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(379, 29)
        Me.FlatTextBox2.TabIndex = 5
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(19, 65)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(91, 21)
        Me.FlatLabel1.TabIndex = 4
        Me.FlatLabel1.Text = "Username:*"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(116, 57)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(379, 29)
        Me.FlatTextBox1.TabIndex = 3
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(507, 254)
        Me.Controls.Add(Me.FlatStatusBar1)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatTextBox1 As ARCBots_API_v4.FlatTextBox
    Friend WithEvents FlatLabel1 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatTextBox2 As ARCBots_API_v4.FlatTextBox
    Friend WithEvents FlatButton3 As ARCBots_API_v4.FlatButton
    Friend WithEvents FlatLabel2 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatLabel3 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatLabel4 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatToggle1 As ARCBots_API_v4.FlatToggle
    Friend WithEvents FlatClose1 As ARCBots_API_v4.FlatClose
    Friend WithEvents FlatMini1 As ARCBots_API_v4.FlatMini
    Friend WithEvents FormSkin1 As ARCBots_API_v4.FormSkin
    Friend WithEvents FlatStatusBar1 As ARCBots_API_v4.FlatStatusBar
    Friend WithEvents FlatButton1 As ARCBots_API_v4.FlatButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents DrawinRectangle1 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle4 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle3 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle2 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle5 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FlatTextBox4 As ARCBots_API_v4.FlatTextBox
    Friend WithEvents FlatLabel6 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatLabel5 As ARCBots_API_v4.FlatLabel
    Friend WithEvents DrawinRectangle11 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle10 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle9 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle8 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle7 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents DrawinRectangle6 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents FlatButton2 As ARCBots_API_v4.FlatButton
    Friend WithEvents FlatLabel7 As ARCBots_API_v4.FlatLabel
    Friend WithEvents FlatToggle2 As ARCBots_API_v4.FlatToggle
    Friend WithEvents FlatMini2 As ARCBots_API_v4.FlatMini
    Friend WithEvents FlatClose2 As ARCBots_API_v4.FlatClose
    Friend WithEvents FlatButton4 As ARCBots_API_v4.FlatButton
    Private WithEvents FlatTextBox3 As ARCBots_API_v4.FlatTextBox
    Friend WithEvents DrawinRectangle12 As ARCBots_API_v4.DrawinRectangle
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
