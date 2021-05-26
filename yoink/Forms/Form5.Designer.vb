<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.formName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.firstName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lastName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.mId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.phoneNum = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.studCourse = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.loadTable = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mIdLabel = New System.Windows.Forms.Label()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.campusStats = New System.Windows.Forms.Label()
        Me.campusEntry = New Bunifu.Framework.UI.BunifuDropdown()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'formName
        '
        Me.formName.AutoSize = True
        Me.formName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formName.Location = New System.Drawing.Point(10, 7)
        Me.formName.Name = "formName"
        Me.formName.Size = New System.Drawing.Size(180, 20)
        Me.formName.TabIndex = 16
        Me.formName.Text = "Student Details Form"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 36)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(818, 187)
        Me.DataGridView1.TabIndex = 18
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
        Me.IconButton1.Location = New System.Drawing.Point(842, 11)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(19, 20)
        Me.IconButton1.TabIndex = 17
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'firstName
        '
        Me.firstName.BackColor = System.Drawing.Color.White
        Me.firstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.ForeColor = System.Drawing.SystemColors.GrayText
        Me.firstName.HintForeColor = System.Drawing.Color.Empty
        Me.firstName.HintText = ""
        Me.firstName.isPassword = False
        Me.firstName.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.firstName.LineIdleColor = System.Drawing.Color.Gray
        Me.firstName.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.firstName.LineThickness = 4
        Me.firstName.Location = New System.Drawing.Point(26, 250)
        Me.firstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(226, 26)
        Me.firstName.TabIndex = 19
        Me.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lastName
        '
        Me.lastName.BackColor = System.Drawing.Color.White
        Me.lastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lastName.HintForeColor = System.Drawing.Color.Empty
        Me.lastName.HintText = ""
        Me.lastName.isPassword = False
        Me.lastName.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.lastName.LineIdleColor = System.Drawing.Color.Gray
        Me.lastName.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.lastName.LineThickness = 4
        Me.lastName.Location = New System.Drawing.Point(260, 250)
        Me.lastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(226, 26)
        Me.lastName.TabIndex = 20
        Me.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'mId
        '
        Me.mId.BackColor = System.Drawing.Color.White
        Me.mId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mId.ForeColor = System.Drawing.SystemColors.GrayText
        Me.mId.HintForeColor = System.Drawing.Color.Empty
        Me.mId.HintText = ""
        Me.mId.isPassword = False
        Me.mId.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.mId.LineIdleColor = System.Drawing.Color.Gray
        Me.mId.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.mId.LineThickness = 4
        Me.mId.Location = New System.Drawing.Point(26, 301)
        Me.mId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mId.Name = "mId"
        Me.mId.Size = New System.Drawing.Size(226, 26)
        Me.mId.TabIndex = 21
        Me.mId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'phoneNum
        '
        Me.phoneNum.BackColor = System.Drawing.Color.White
        Me.phoneNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNum.ForeColor = System.Drawing.SystemColors.GrayText
        Me.phoneNum.HintForeColor = System.Drawing.Color.Empty
        Me.phoneNum.HintText = ""
        Me.phoneNum.isPassword = False
        Me.phoneNum.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.phoneNum.LineIdleColor = System.Drawing.Color.Gray
        Me.phoneNum.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.phoneNum.LineThickness = 4
        Me.phoneNum.Location = New System.Drawing.Point(260, 301)
        Me.phoneNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.phoneNum.Name = "phoneNum"
        Me.phoneNum.Size = New System.Drawing.Size(226, 26)
        Me.phoneNum.TabIndex = 22
        Me.phoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'studCourse
        '
        Me.studCourse.BackColor = System.Drawing.Color.White
        Me.studCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studCourse.ForeColor = System.Drawing.SystemColors.GrayText
        Me.studCourse.HintForeColor = System.Drawing.Color.Empty
        Me.studCourse.HintText = ""
        Me.studCourse.isPassword = False
        Me.studCourse.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.studCourse.LineIdleColor = System.Drawing.Color.Gray
        Me.studCourse.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.studCourse.LineThickness = 4
        Me.studCourse.Location = New System.Drawing.Point(26, 352)
        Me.studCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studCourse.Name = "studCourse"
        Me.studCourse.Size = New System.Drawing.Size(226, 26)
        Me.studCourse.TabIndex = 23
        Me.studCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'loadTable
        '
        Me.loadTable.ActiveBorderThickness = 1
        Me.loadTable.ActiveCornerRadius = 20
        Me.loadTable.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.loadTable.ActiveForecolor = System.Drawing.Color.Transparent
        Me.loadTable.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.loadTable.BackColor = System.Drawing.Color.White
        Me.loadTable.BackgroundImage = CType(resources.GetObject("loadTable.BackgroundImage"), System.Drawing.Image)
        Me.loadTable.ButtonText = "Load Table"
        Me.loadTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadTable.ForeColor = System.Drawing.Color.SteelBlue
        Me.loadTable.IdleBorderThickness = 1
        Me.loadTable.IdleCornerRadius = 20
        Me.loadTable.IdleFillColor = System.Drawing.Color.Transparent
        Me.loadTable.IdleForecolor = System.Drawing.Color.Gray
        Me.loadTable.IdleLineColor = System.Drawing.Color.Gray
        Me.loadTable.Location = New System.Drawing.Point(709, 230)
        Me.loadTable.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.loadTable.Name = "loadTable"
        Me.loadTable.Size = New System.Drawing.Size(135, 42)
        Me.loadTable.TabIndex = 25
        Me.loadTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(23, 230)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(45, 15)
        Me.nameLabel.TabIndex = 26
        Me.nameLabel.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Phone"
        '
        'mIdLabel
        '
        Me.mIdLabel.AutoSize = True
        Me.mIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mIdLabel.Location = New System.Drawing.Point(23, 281)
        Me.mIdLabel.Name = "mIdLabel"
        Me.mIdLabel.Size = New System.Drawing.Size(65, 15)
        Me.mIdLabel.TabIndex = 37
        Me.mIdLabel.Text = "Matric ID"
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(23, 332)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(52, 15)
        Me.courseLabel.TabIndex = 38
        Me.courseLabel.Text = "Course"
        '
        'campusStats
        '
        Me.campusStats.AutoSize = True
        Me.campusStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campusStats.Location = New System.Drawing.Point(23, 383)
        Me.campusStats.Name = "campusStats"
        Me.campusStats.Size = New System.Drawing.Size(123, 15)
        Me.campusStats.TabIndex = 39
        Me.campusStats.Text = "Allowed to return?"
        '
        'campusEntry
        '
        Me.campusEntry.BackColor = System.Drawing.Color.Transparent
        Me.campusEntry.BorderRadius = 3
        Me.campusEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campusEntry.ForeColor = System.Drawing.Color.White
        Me.campusEntry.Items = New String() {"allowed", "denied"}
        Me.campusEntry.Location = New System.Drawing.Point(26, 403)
        Me.campusEntry.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.campusEntry.Name = "campusEntry"
        Me.campusEntry.NomalColor = System.Drawing.Color.Gray
        Me.campusEntry.onHoverColor = System.Drawing.Color.SteelBlue
        Me.campusEntry.selectedIndex = 0
        Me.campusEntry.Size = New System.Drawing.Size(226, 26)
        Me.campusEntry.TabIndex = 40
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.campusEntry)
        Me.Controls.Add(Me.campusStats)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.mIdLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.loadTable)
        Me.Controls.Add(Me.studCourse)
        Me.Controls.Add(Me.phoneNum)
        Me.Controls.Add(Me.mId)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.formName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents formName As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents studCourse As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents phoneNum As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents mId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lastName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents firstName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents loadTable As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mIdLabel As Label
    Friend WithEvents campusStats As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents campusEntry As Bunifu.Framework.UI.BunifuDropdown
End Class
