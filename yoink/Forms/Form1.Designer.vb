<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returneeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(returneeForm))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.mIdLabel = New System.Windows.Forms.Label()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.fNameInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lNameInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.mIdInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.courseSelect = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.question1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.formName = New System.Windows.Forms.Label()
        Me.symptomCheck1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.symptom1 = New System.Windows.Forms.Label()
        Me.symptom2 = New System.Windows.Forms.Label()
        Me.symptomCheck2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.symptom3 = New System.Windows.Forms.Label()
        Me.symptomCheck3 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.symptom4 = New System.Windows.Forms.Label()
        Me.symptomCheck4 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.symptom5 = New System.Windows.Forms.Label()
        Me.symptomCheck5 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.question2 = New System.Windows.Forms.Label()
        Me.question2Switch = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.question2Yes = New System.Windows.Forms.Label()
        Me.question2No = New System.Windows.Forms.Label()
        Me.question3 = New System.Windows.Forms.Label()
        Me.question3No = New System.Windows.Forms.Label()
        Me.question3Yes = New System.Windows.Forms.Label()
        Me.question3Switch = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.phoneNum = New System.Windows.Forms.Label()
        Me.phoneNumInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.sendButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.clearButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bodyTemp = New System.Windows.Forms.Label()
        Me.bodyTempInput = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(49, 100)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(52, 18)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name"
        '
        'mIdLabel
        '
        Me.mIdLabel.AutoSize = True
        Me.mIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mIdLabel.Location = New System.Drawing.Point(49, 186)
        Me.mIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mIdLabel.Name = "mIdLabel"
        Me.mIdLabel.Size = New System.Drawing.Size(76, 18)
        Me.mIdLabel.TabIndex = 2
        Me.mIdLabel.Text = "Matric ID"
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(49, 358)
        Me.courseLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(63, 18)
        Me.courseLabel.TabIndex = 4
        Me.courseLabel.Text = "Course"
        '
        'fNameInput
        '
        Me.fNameInput.BackColor = System.Drawing.Color.White
        Me.fNameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.fNameInput.HintForeColor = System.Drawing.Color.Empty
        Me.fNameInput.HintText = ""
        Me.fNameInput.isPassword = False
        Me.fNameInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.fNameInput.LineIdleColor = System.Drawing.Color.Gray
        Me.fNameInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.fNameInput.LineThickness = 4
        Me.fNameInput.Location = New System.Drawing.Point(55, 132)
        Me.fNameInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.fNameInput.Name = "fNameInput"
        Me.fNameInput.Size = New System.Drawing.Size(220, 32)
        Me.fNameInput.TabIndex = 1
        Me.fNameInput.Text = "First"
        Me.fNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lNameInput
        '
        Me.lNameInput.BackColor = System.Drawing.Color.White
        Me.lNameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lNameInput.HintForeColor = System.Drawing.Color.Empty
        Me.lNameInput.HintText = ""
        Me.lNameInput.isPassword = False
        Me.lNameInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.lNameInput.LineIdleColor = System.Drawing.Color.Gray
        Me.lNameInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.lNameInput.LineThickness = 4
        Me.lNameInput.Location = New System.Drawing.Point(292, 132)
        Me.lNameInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lNameInput.Name = "lNameInput"
        Me.lNameInput.Size = New System.Drawing.Size(222, 32)
        Me.lNameInput.TabIndex = 2
        Me.lNameInput.Text = "Last"
        Me.lNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'mIdInput
        '
        Me.mIdInput.BackColor = System.Drawing.Color.White
        Me.mIdInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mIdInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mIdInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.mIdInput.HintForeColor = System.Drawing.Color.Empty
        Me.mIdInput.HintText = ""
        Me.mIdInput.isPassword = False
        Me.mIdInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.mIdInput.LineIdleColor = System.Drawing.Color.Gray
        Me.mIdInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.mIdInput.LineThickness = 4
        Me.mIdInput.Location = New System.Drawing.Point(55, 219)
        Me.mIdInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.mIdInput.Name = "mIdInput"
        Me.mIdInput.Size = New System.Drawing.Size(461, 32)
        Me.mIdInput.TabIndex = 3
        Me.mIdInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'courseSelect
        '
        Me.courseSelect.BackColor = System.Drawing.Color.Transparent
        Me.courseSelect.BorderRadius = 3
        Me.courseSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseSelect.ForeColor = System.Drawing.Color.White
        Me.courseSelect.Items = New String() {"- Please select a course -", "Diploma in Accounting", "Diploma in Graphic Design", "Diploma in Information Technology", "Diploma in Management", "Diploma in Tourism", "Certificate in Health Science", "Certificate in Computer Science", "Certificate in Management"}
        Me.courseSelect.Location = New System.Drawing.Point(55, 391)
        Me.courseSelect.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.courseSelect.Name = "courseSelect"
        Me.courseSelect.NomalColor = System.Drawing.Color.Gray
        Me.courseSelect.onHoverColor = System.Drawing.Color.SteelBlue
        Me.courseSelect.selectedIndex = 0
        Me.courseSelect.Size = New System.Drawing.Size(458, 32)
        Me.courseSelect.TabIndex = 6
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
        Me.IconButton1.Location = New System.Drawing.Point(1123, 13)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(25, 25)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'question1
        '
        Me.question1.AutoSize = True
        Me.question1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question1.Location = New System.Drawing.Point(652, 100)
        Me.question1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question1.Name = "question1"
        Me.question1.Size = New System.Drawing.Size(417, 18)
        Me.question1.TabIndex = 13
        Me.question1.Text = "Have you had any of the following symptoms recently?"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(582, 66)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(28, 449)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'formName
        '
        Me.formName.AutoSize = True
        Me.formName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formName.Location = New System.Drawing.Point(16, 11)
        Me.formName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formName.Name = "formName"
        Me.formName.Size = New System.Drawing.Size(240, 25)
        Me.formName.TabIndex = 15
        Me.formName.Text = "Campus Returnee Form"
        '
        'symptomCheck1
        '
        Me.symptomCheck1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck1.Checked = False
        Me.symptomCheck1.CheckedOnColor = System.Drawing.Color.SteelBlue
        Me.symptomCheck1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.symptomCheck1.ForeColor = System.Drawing.Color.White
        Me.symptomCheck1.Location = New System.Drawing.Point(658, 140)
        Me.symptomCheck1.Margin = New System.Windows.Forms.Padding(5)
        Me.symptomCheck1.Name = "symptomCheck1"
        Me.symptomCheck1.Size = New System.Drawing.Size(20, 20)
        Me.symptomCheck1.TabIndex = 7
        '
        'symptom1
        '
        Me.symptom1.AutoSize = True
        Me.symptom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom1.Location = New System.Drawing.Point(692, 140)
        Me.symptom1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom1.Name = "symptom1"
        Me.symptom1.Size = New System.Drawing.Size(45, 18)
        Me.symptom1.TabIndex = 17
        Me.symptom1.Text = "Fever"
        '
        'symptom2
        '
        Me.symptom2.AutoSize = True
        Me.symptom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom2.Location = New System.Drawing.Point(692, 172)
        Me.symptom2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom2.Name = "symptom2"
        Me.symptom2.Size = New System.Drawing.Size(52, 18)
        Me.symptom2.TabIndex = 19
        Me.symptom2.Text = "Cough"
        '
        'symptomCheck2
        '
        Me.symptomCheck2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck2.Checked = False
        Me.symptomCheck2.CheckedOnColor = System.Drawing.Color.SteelBlue
        Me.symptomCheck2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.symptomCheck2.ForeColor = System.Drawing.Color.White
        Me.symptomCheck2.Location = New System.Drawing.Point(658, 172)
        Me.symptomCheck2.Margin = New System.Windows.Forms.Padding(5)
        Me.symptomCheck2.Name = "symptomCheck2"
        Me.symptomCheck2.Size = New System.Drawing.Size(20, 20)
        Me.symptomCheck2.TabIndex = 8
        '
        'symptom3
        '
        Me.symptom3.AutoSize = True
        Me.symptom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom3.Location = New System.Drawing.Point(692, 204)
        Me.symptom3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom3.Name = "symptom3"
        Me.symptom3.Size = New System.Drawing.Size(87, 18)
        Me.symptom3.TabIndex = 21
        Me.symptom3.Text = "Sore Throat"
        '
        'symptomCheck3
        '
        Me.symptomCheck3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck3.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck3.Checked = False
        Me.symptomCheck3.CheckedOnColor = System.Drawing.Color.SteelBlue
        Me.symptomCheck3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.symptomCheck3.ForeColor = System.Drawing.Color.White
        Me.symptomCheck3.Location = New System.Drawing.Point(658, 204)
        Me.symptomCheck3.Margin = New System.Windows.Forms.Padding(5)
        Me.symptomCheck3.Name = "symptomCheck3"
        Me.symptomCheck3.Size = New System.Drawing.Size(20, 20)
        Me.symptomCheck3.TabIndex = 9
        '
        'symptom4
        '
        Me.symptom4.AutoSize = True
        Me.symptom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom4.Location = New System.Drawing.Point(692, 236)
        Me.symptom4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom4.Name = "symptom4"
        Me.symptom4.Size = New System.Drawing.Size(196, 18)
        Me.symptom4.TabIndex = 23
        Me.symptom4.Text = "Lost of sense ie. taste, smell"
        '
        'symptomCheck4
        '
        Me.symptomCheck4.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck4.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck4.Checked = False
        Me.symptomCheck4.CheckedOnColor = System.Drawing.Color.SteelBlue
        Me.symptomCheck4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.symptomCheck4.ForeColor = System.Drawing.Color.White
        Me.symptomCheck4.Location = New System.Drawing.Point(658, 236)
        Me.symptomCheck4.Margin = New System.Windows.Forms.Padding(5)
        Me.symptomCheck4.Name = "symptomCheck4"
        Me.symptomCheck4.Size = New System.Drawing.Size(20, 20)
        Me.symptomCheck4.TabIndex = 10
        '
        'symptom5
        '
        Me.symptom5.AutoSize = True
        Me.symptom5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom5.Location = New System.Drawing.Point(692, 268)
        Me.symptom5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom5.Name = "symptom5"
        Me.symptom5.Size = New System.Drawing.Size(129, 18)
        Me.symptom5.TabIndex = 25
        Me.symptom5.Text = "None of the above"
        '
        'symptomCheck5
        '
        Me.symptomCheck5.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck5.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.symptomCheck5.Checked = False
        Me.symptomCheck5.CheckedOnColor = System.Drawing.Color.SteelBlue
        Me.symptomCheck5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.symptomCheck5.ForeColor = System.Drawing.Color.White
        Me.symptomCheck5.Location = New System.Drawing.Point(658, 268)
        Me.symptomCheck5.Margin = New System.Windows.Forms.Padding(5)
        Me.symptomCheck5.Name = "symptomCheck5"
        Me.symptomCheck5.Size = New System.Drawing.Size(20, 20)
        Me.symptomCheck5.TabIndex = 11
        '
        'question2
        '
        Me.question2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question2.Location = New System.Drawing.Point(652, 318)
        Me.question2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question2.Name = "question2"
        Me.question2.Size = New System.Drawing.Size(460, 55)
        Me.question2.TabIndex = 26
        Me.question2.Text = "Have you been in close contact with person suspected and/or confirmed to have COV" &
    "ID-19"
        '
        'question2Switch
        '
        Me.question2Switch.BackColor = System.Drawing.Color.Transparent
        Me.question2Switch.BackgroundImage = CType(resources.GetObject("question2Switch.BackgroundImage"), System.Drawing.Image)
        Me.question2Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.question2Switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.question2Switch.Location = New System.Drawing.Point(705, 378)
        Me.question2Switch.Margin = New System.Windows.Forms.Padding(5)
        Me.question2Switch.Name = "question2Switch"
        Me.question2Switch.OffColor = System.Drawing.Color.Gray
        Me.question2Switch.OnColor = System.Drawing.Color.SteelBlue
        Me.question2Switch.Size = New System.Drawing.Size(43, 25)
        Me.question2Switch.TabIndex = 12
        Me.question2Switch.Value = False
        '
        'question2Yes
        '
        Me.question2Yes.AutoSize = True
        Me.question2Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question2Yes.Location = New System.Drawing.Point(770, 380)
        Me.question2Yes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question2Yes.Name = "question2Yes"
        Me.question2Yes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.question2Yes.Size = New System.Drawing.Size(33, 18)
        Me.question2Yes.TabIndex = 29
        Me.question2Yes.Text = "Yes"
        '
        'question2No
        '
        Me.question2No.AutoSize = True
        Me.question2No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question2No.Location = New System.Drawing.Point(658, 380)
        Me.question2No.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question2No.Name = "question2No"
        Me.question2No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.question2No.Size = New System.Drawing.Size(28, 18)
        Me.question2No.TabIndex = 30
        Me.question2No.Text = "No"
        '
        'question3
        '
        Me.question3.AutoSize = True
        Me.question3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question3.Location = New System.Drawing.Point(652, 428)
        Me.question3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question3.Name = "question3"
        Me.question3.Size = New System.Drawing.Size(306, 18)
        Me.question3.TabIndex = 31
        Me.question3.Text = "Are you currently under self quarantine?"
        '
        'question3No
        '
        Me.question3No.AutoSize = True
        Me.question3No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question3No.Location = New System.Drawing.Point(658, 462)
        Me.question3No.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question3No.Name = "question3No"
        Me.question3No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.question3No.Size = New System.Drawing.Size(28, 18)
        Me.question3No.TabIndex = 34
        Me.question3No.Text = "No"
        '
        'question3Yes
        '
        Me.question3Yes.AutoSize = True
        Me.question3Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question3Yes.Location = New System.Drawing.Point(770, 462)
        Me.question3Yes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question3Yes.Name = "question3Yes"
        Me.question3Yes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.question3Yes.Size = New System.Drawing.Size(33, 18)
        Me.question3Yes.TabIndex = 33
        Me.question3Yes.Text = "Yes"
        '
        'question3Switch
        '
        Me.question3Switch.BackColor = System.Drawing.Color.Transparent
        Me.question3Switch.BackgroundImage = CType(resources.GetObject("question3Switch.BackgroundImage"), System.Drawing.Image)
        Me.question3Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.question3Switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.question3Switch.Location = New System.Drawing.Point(705, 459)
        Me.question3Switch.Margin = New System.Windows.Forms.Padding(5)
        Me.question3Switch.Name = "question3Switch"
        Me.question3Switch.OffColor = System.Drawing.Color.Gray
        Me.question3Switch.OnColor = System.Drawing.Color.SteelBlue
        Me.question3Switch.Size = New System.Drawing.Size(43, 25)
        Me.question3Switch.TabIndex = 13
        Me.question3Switch.Value = False
        '
        'phoneNum
        '
        Me.phoneNum.AutoSize = True
        Me.phoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNum.Location = New System.Drawing.Point(49, 272)
        Me.phoneNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneNum.Name = "phoneNum"
        Me.phoneNum.Size = New System.Drawing.Size(56, 18)
        Me.phoneNum.TabIndex = 35
        Me.phoneNum.Text = "Phone"
        '
        'phoneNumInput
        '
        Me.phoneNumInput.BackColor = System.Drawing.Color.White
        Me.phoneNumInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneNumInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.phoneNumInput.HintForeColor = System.Drawing.Color.Empty
        Me.phoneNumInput.HintText = ""
        Me.phoneNumInput.isPassword = False
        Me.phoneNumInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.phoneNumInput.LineIdleColor = System.Drawing.Color.Gray
        Me.phoneNumInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.phoneNumInput.LineThickness = 4
        Me.phoneNumInput.Location = New System.Drawing.Point(55, 305)
        Me.phoneNumInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.phoneNumInput.Name = "phoneNumInput"
        Me.phoneNumInput.Size = New System.Drawing.Size(220, 32)
        Me.phoneNumInput.TabIndex = 4
        Me.phoneNumInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sendButton
        '
        Me.sendButton.ActiveBorderThickness = 1
        Me.sendButton.ActiveCornerRadius = 20
        Me.sendButton.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.sendButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.sendButton.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.sendButton.BackColor = System.Drawing.Color.White
        Me.sendButton.BackgroundImage = CType(resources.GetObject("sendButton.BackgroundImage"), System.Drawing.Image)
        Me.sendButton.ButtonText = "Save"
        Me.sendButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.sendButton.IdleBorderThickness = 1
        Me.sendButton.IdleCornerRadius = 20
        Me.sendButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.sendButton.IdleForecolor = System.Drawing.Color.Gray
        Me.sendButton.IdleLineColor = System.Drawing.Color.Gray
        Me.sendButton.Location = New System.Drawing.Point(292, 445)
        Me.sendButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(169, 52)
        Me.sendButton.TabIndex = 15
        Me.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clearButton
        '
        Me.clearButton.ActiveBorderThickness = 1
        Me.clearButton.ActiveCornerRadius = 20
        Me.clearButton.ActiveFillColor = System.Drawing.Color.IndianRed
        Me.clearButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.clearButton.ActiveLineColor = System.Drawing.Color.IndianRed
        Me.clearButton.BackColor = System.Drawing.Color.White
        Me.clearButton.BackgroundImage = CType(resources.GetObject("clearButton.BackgroundImage"), System.Drawing.Image)
        Me.clearButton.ButtonText = "Clear"
        Me.clearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.clearButton.IdleBorderThickness = 1
        Me.clearButton.IdleCornerRadius = 20
        Me.clearButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.clearButton.IdleForecolor = System.Drawing.Color.Gray
        Me.clearButton.IdleLineColor = System.Drawing.Color.Gray
        Me.clearButton.Location = New System.Drawing.Point(95, 445)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(169, 52)
        Me.clearButton.TabIndex = 14
        Me.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bodyTemp
        '
        Me.bodyTemp.AutoSize = True
        Me.bodyTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bodyTemp.Location = New System.Drawing.Point(290, 272)
        Me.bodyTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bodyTemp.Name = "bodyTemp"
        Me.bodyTemp.Size = New System.Drawing.Size(103, 18)
        Me.bodyTemp.TabIndex = 39
        Me.bodyTemp.Text = "Temperature"
        '
        'bodyTempInput
        '
        Me.bodyTempInput.BackColor = System.Drawing.Color.White
        Me.bodyTempInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bodyTempInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bodyTempInput.ForeColor = System.Drawing.SystemColors.GrayText
        Me.bodyTempInput.HintForeColor = System.Drawing.Color.Empty
        Me.bodyTempInput.HintText = ""
        Me.bodyTempInput.isPassword = False
        Me.bodyTempInput.LineFocusedColor = System.Drawing.Color.SteelBlue
        Me.bodyTempInput.LineIdleColor = System.Drawing.Color.Gray
        Me.bodyTempInput.LineMouseHoverColor = System.Drawing.Color.SteelBlue
        Me.bodyTempInput.LineThickness = 4
        Me.bodyTempInput.Location = New System.Drawing.Point(292, 305)
        Me.bodyTempInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.bodyTempInput.Name = "bodyTempInput"
        Me.bodyTempInput.Size = New System.Drawing.Size(220, 32)
        Me.bodyTempInput.TabIndex = 5
        Me.bodyTempInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'returneeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1161, 554)
        Me.Controls.Add(Me.bodyTempInput)
        Me.Controls.Add(Me.bodyTemp)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.phoneNumInput)
        Me.Controls.Add(Me.phoneNum)
        Me.Controls.Add(Me.question3No)
        Me.Controls.Add(Me.question3Yes)
        Me.Controls.Add(Me.question3Switch)
        Me.Controls.Add(Me.question3)
        Me.Controls.Add(Me.question2No)
        Me.Controls.Add(Me.question2Yes)
        Me.Controls.Add(Me.question2Switch)
        Me.Controls.Add(Me.question2)
        Me.Controls.Add(Me.symptom5)
        Me.Controls.Add(Me.symptomCheck5)
        Me.Controls.Add(Me.symptom4)
        Me.Controls.Add(Me.symptomCheck4)
        Me.Controls.Add(Me.symptom3)
        Me.Controls.Add(Me.symptomCheck3)
        Me.Controls.Add(Me.symptom2)
        Me.Controls.Add(Me.symptomCheck2)
        Me.Controls.Add(Me.symptom1)
        Me.Controls.Add(Me.symptomCheck1)
        Me.Controls.Add(Me.formName)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.question1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.courseSelect)
        Me.Controls.Add(Me.mIdInput)
        Me.Controls.Add(Me.lNameInput)
        Me.Controls.Add(Me.fNameInput)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.mIdLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1161, 554)
        Me.Name = "returneeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campus Returnee Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents mIdLabel As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents fNameInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lNameInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents mIdInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents courseSelect As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents symptom5 As Label
    Friend WithEvents symptomCheck5 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents symptom4 As Label
    Friend WithEvents symptomCheck4 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents symptom3 As Label
    Friend WithEvents symptomCheck3 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents symptom2 As Label
    Friend WithEvents symptomCheck2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents symptom1 As Label
    Friend WithEvents symptomCheck1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents formName As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents question1 As Label
    Friend WithEvents question2Yes As Label
    Friend WithEvents question2Switch As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents question2 As Label
    Friend WithEvents question2No As Label
    Friend WithEvents question3No As Label
    Friend WithEvents question3Yes As Label
    Friend WithEvents question3Switch As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents question3 As Label
    Friend WithEvents phoneNumInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents phoneNum As Label
    Friend WithEvents sendButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents clearButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bodyTempInput As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents bodyTemp As Label
End Class
