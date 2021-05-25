<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.msuLogo = New System.Windows.Forms.PictureBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.studentButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.usernameInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.passwordInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staffButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.msuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 24
        Me.IconButton1.Location = New System.Drawing.Point(294, 13)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(25, 25)
        Me.IconButton1.TabIndex = 13
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'msuLogo
        '
        Me.msuLogo.BackgroundImage = Global.yoink.My.Resources.Resources.MSU_black
        Me.msuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.msuLogo.Location = New System.Drawing.Point(75, 30)
        Me.msuLogo.Name = "msuLogo"
        Me.msuLogo.Size = New System.Drawing.Size(183, 80)
        Me.msuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.msuLogo.TabIndex = 14
        Me.msuLogo.TabStop = False
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(132, 113)
        Me.Label0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(68, 25)
        Me.Label0.TabIndex = 17
        Me.Label0.Text = "Hello!"
        '
        'studentButton
        '
        Me.studentButton.ActiveBorderThickness = 1
        Me.studentButton.ActiveCornerRadius = 20
        Me.studentButton.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.studentButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.studentButton.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.studentButton.BackColor = System.Drawing.Color.White
        Me.studentButton.BackgroundImage = CType(resources.GetObject("studentButton.BackgroundImage"), System.Drawing.Image)
        Me.studentButton.ButtonText = "I'm a student."
        Me.studentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.studentButton.IdleBorderThickness = 1
        Me.studentButton.IdleCornerRadius = 20
        Me.studentButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.studentButton.IdleForecolor = System.Drawing.Color.Gray
        Me.studentButton.IdleLineColor = System.Drawing.Color.Gray
        Me.studentButton.Location = New System.Drawing.Point(44, 156)
        Me.studentButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.studentButton.Name = "studentButton"
        Me.studentButton.Size = New System.Drawing.Size(245, 52)
        Me.studentButton.TabIndex = 18
        Me.studentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(22, 219)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(288, 14)
        Me.BunifuSeparator1.TabIndex = 19
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'usernameInput
        '
        Me.usernameInput.BackColor = System.Drawing.Color.White
        Me.usernameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.usernameInput.HintForeColor = System.Drawing.Color.Empty
        Me.usernameInput.HintText = ""
        Me.usernameInput.isPassword = False
        Me.usernameInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.usernameInput.LineIdleColor = System.Drawing.Color.Gray
        Me.usernameInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.usernameInput.LineThickness = 4
        Me.usernameInput.Location = New System.Drawing.Point(56, 290)
        Me.usernameInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.usernameInput.Name = "usernameInput"
        Me.usernameInput.Size = New System.Drawing.Size(220, 32)
        Me.usernameInput.TabIndex = 20
        Me.usernameInput.Text = "Username"
        Me.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordInput
        '
        Me.passwordInput.BackColor = System.Drawing.Color.White
        Me.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordInput.HintForeColor = System.Drawing.Color.Empty
        Me.passwordInput.HintText = ""
        Me.passwordInput.isPassword = True
        Me.passwordInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.passwordInput.LineIdleColor = System.Drawing.Color.Gray
        Me.passwordInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.passwordInput.LineThickness = 4
        Me.passwordInput.Location = New System.Drawing.Point(56, 344)
        Me.passwordInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(220, 32)
        Me.passwordInput.TabIndex = 21
        Me.passwordInput.Text = "Password"
        Me.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Staff Login"
        '
        'staffButton
        '
        Me.staffButton.ActiveBorderThickness = 1
        Me.staffButton.ActiveCornerRadius = 20
        Me.staffButton.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.staffButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.staffButton.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.staffButton.BackColor = System.Drawing.Color.White
        Me.staffButton.BackgroundImage = CType(resources.GetObject("staffButton.BackgroundImage"), System.Drawing.Image)
        Me.staffButton.ButtonText = "Login"
        Me.staffButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.staffButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.staffButton.IdleBorderThickness = 1
        Me.staffButton.IdleCornerRadius = 20
        Me.staffButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.staffButton.IdleForecolor = System.Drawing.Color.Gray
        Me.staffButton.IdleLineColor = System.Drawing.Color.Gray
        Me.staffButton.Location = New System.Drawing.Point(44, 388)
        Me.staffButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.staffButton.Name = "staffButton"
        Me.staffButton.Size = New System.Drawing.Size(245, 52)
        Me.staffButton.TabIndex = 23
        Me.staffButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 493)
        Me.Controls.Add(Me.staffButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordInput)
        Me.Controls.Add(Me.usernameInput)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.studentButton)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.msuLogo)
        Me.Controls.Add(Me.IconButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.msuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents msuLogo As PictureBox
    Friend WithEvents Label0 As Label
    Friend WithEvents studentButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents usernameInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents staffButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
