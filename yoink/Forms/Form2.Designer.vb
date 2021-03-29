<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.msuLogo = New System.Windows.Forms.PictureBox()
        Me.formName = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.fullName = New System.Windows.Forms.Label()
        Me.matricID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phoneNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studCourse = New System.Windows.Forms.Label()
        Me.returnButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studTemp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.symptom1 = New System.Windows.Forms.Label()
        Me.symptom2 = New System.Windows.Forms.Label()
        Me.symptom3 = New System.Windows.Forms.Label()
        Me.symptom4 = New System.Windows.Forms.Label()
        Me.symptom5 = New System.Windows.Forms.Label()
        Me.question2 = New System.Windows.Forms.Label()
        Me.symptom7 = New System.Windows.Forms.Label()
        Me.question3 = New System.Windows.Forms.Label()
        Me.symptom8 = New System.Windows.Forms.Label()
        Me.actionTake = New System.Windows.Forms.Label()
        CType(Me.msuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'msuLogo
        '
        Me.msuLogo.BackgroundImage = Global.yoink.My.Resources.Resources.MSU_black
        Me.msuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.msuLogo.Location = New System.Drawing.Point(275, 12)
        Me.msuLogo.Name = "msuLogo"
        Me.msuLogo.Size = New System.Drawing.Size(183, 80)
        Me.msuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.msuLogo.TabIndex = 0
        Me.msuLogo.TabStop = False
        '
        'formName
        '
        Me.formName.AutoSize = True
        Me.formName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formName.Location = New System.Drawing.Point(254, 95)
        Me.formName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formName.Name = "formName"
        Me.formName.Size = New System.Drawing.Size(224, 25)
        Me.formName.TabIndex = 16
        Me.formName.Text = "Student Status Report"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(13, 156)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(52, 18)
        Me.nameLabel.TabIndex = 17
        Me.nameLabel.Text = "Name"
        '
        'fullName
        '
        Me.fullName.AutoSize = True
        Me.fullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullName.Location = New System.Drawing.Point(13, 174)
        Me.fullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fullName.Name = "fullName"
        Me.fullName.Size = New System.Drawing.Size(48, 18)
        Me.fullName.TabIndex = 18
        Me.fullName.Text = "--------"
        Me.fullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'matricID
        '
        Me.matricID.AutoSize = True
        Me.matricID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matricID.Location = New System.Drawing.Point(13, 231)
        Me.matricID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.matricID.Name = "matricID"
        Me.matricID.Size = New System.Drawing.Size(48, 18)
        Me.matricID.TabIndex = 20
        Me.matricID.Text = "--------"
        Me.matricID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Matric ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 327)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Phone number"
        '
        'phoneNumber
        '
        Me.phoneNumber.AutoSize = True
        Me.phoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumber.Location = New System.Drawing.Point(13, 345)
        Me.phoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.Size = New System.Drawing.Size(48, 18)
        Me.phoneNumber.TabIndex = 22
        Me.phoneNumber.Text = "--------"
        Me.phoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Course"
        '
        'studCourse
        '
        Me.studCourse.AutoSize = True
        Me.studCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studCourse.Location = New System.Drawing.Point(13, 288)
        Me.studCourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.studCourse.Name = "studCourse"
        Me.studCourse.Size = New System.Drawing.Size(48, 18)
        Me.studCourse.TabIndex = 24
        Me.studCourse.Text = "--------"
        Me.studCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'returnButton
        '
        Me.returnButton.ActiveBorderThickness = 1
        Me.returnButton.ActiveCornerRadius = 20
        Me.returnButton.ActiveFillColor = System.Drawing.Color.IndianRed
        Me.returnButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.returnButton.ActiveLineColor = System.Drawing.Color.IndianRed
        Me.returnButton.BackColor = System.Drawing.Color.White
        Me.returnButton.BackgroundImage = CType(resources.GetObject("returnButton.BackgroundImage"), System.Drawing.Image)
        Me.returnButton.ButtonText = "Return"
        Me.returnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.returnButton.IdleBorderThickness = 1
        Me.returnButton.IdleCornerRadius = 20
        Me.returnButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.returnButton.IdleForecolor = System.Drawing.Color.Gray
        Me.returnButton.IdleLineColor = System.Drawing.Color.Gray
        Me.returnButton.Location = New System.Drawing.Point(550, 460)
        Me.returnButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(169, 53)
        Me.returnButton.TabIndex = 39
        Me.returnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 384)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Temperature"
        '
        'studTemp
        '
        Me.studTemp.AutoSize = True
        Me.studTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studTemp.Location = New System.Drawing.Point(13, 402)
        Me.studTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.studTemp.Name = "studTemp"
        Me.studTemp.Size = New System.Drawing.Size(48, 18)
        Me.studTemp.TabIndex = 41
        Me.studTemp.Text = "--------"
        Me.studTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Symptoms"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(259, 146)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(15, 305)
        Me.BunifuSeparator1.TabIndex = 43
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'symptom1
        '
        Me.symptom1.AutoSize = True
        Me.symptom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom1.Location = New System.Drawing.Point(282, 174)
        Me.symptom1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom1.Name = "symptom1"
        Me.symptom1.Size = New System.Drawing.Size(48, 18)
        Me.symptom1.TabIndex = 44
        Me.symptom1.Text = "--------"
        Me.symptom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'symptom2
        '
        Me.symptom2.AutoSize = True
        Me.symptom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom2.Location = New System.Drawing.Point(282, 192)
        Me.symptom2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom2.Name = "symptom2"
        Me.symptom2.Size = New System.Drawing.Size(48, 18)
        Me.symptom2.TabIndex = 45
        Me.symptom2.Text = "--------"
        Me.symptom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'symptom3
        '
        Me.symptom3.AutoSize = True
        Me.symptom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom3.Location = New System.Drawing.Point(282, 213)
        Me.symptom3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom3.Name = "symptom3"
        Me.symptom3.Size = New System.Drawing.Size(48, 18)
        Me.symptom3.TabIndex = 46
        Me.symptom3.Text = "--------"
        Me.symptom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'symptom4
        '
        Me.symptom4.AutoSize = True
        Me.symptom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom4.Location = New System.Drawing.Point(282, 231)
        Me.symptom4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom4.Name = "symptom4"
        Me.symptom4.Size = New System.Drawing.Size(48, 18)
        Me.symptom4.TabIndex = 47
        Me.symptom4.Text = "--------"
        Me.symptom4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'symptom5
        '
        Me.symptom5.AutoSize = True
        Me.symptom5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom5.Location = New System.Drawing.Point(282, 249)
        Me.symptom5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom5.Name = "symptom5"
        Me.symptom5.Size = New System.Drawing.Size(48, 18)
        Me.symptom5.TabIndex = 48
        Me.symptom5.Text = "--------"
        Me.symptom5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'question2
        '
        Me.question2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question2.Location = New System.Drawing.Point(279, 297)
        Me.question2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question2.Name = "question2"
        Me.question2.Size = New System.Drawing.Size(460, 39)
        Me.question2.TabIndex = 49
        Me.question2.Text = "Have you been in close contact with person suspected and/or confirmed to have COV" &
    "ID-19"
        '
        'symptom7
        '
        Me.symptom7.AutoSize = True
        Me.symptom7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom7.Location = New System.Drawing.Point(282, 336)
        Me.symptom7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom7.Name = "symptom7"
        Me.symptom7.Size = New System.Drawing.Size(48, 18)
        Me.symptom7.TabIndex = 50
        Me.symptom7.Text = "--------"
        Me.symptom7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'question3
        '
        Me.question3.AutoSize = True
        Me.question3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question3.Location = New System.Drawing.Point(282, 384)
        Me.question3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.question3.Name = "question3"
        Me.question3.Size = New System.Drawing.Size(306, 18)
        Me.question3.TabIndex = 51
        Me.question3.Text = "Are you currently under self quarantine?"
        '
        'symptom8
        '
        Me.symptom8.AutoSize = True
        Me.symptom8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom8.Location = New System.Drawing.Point(282, 402)
        Me.symptom8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptom8.Name = "symptom8"
        Me.symptom8.Size = New System.Drawing.Size(48, 18)
        Me.symptom8.TabIndex = 52
        Me.symptom8.Text = "--------"
        Me.symptom8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'actionTake
        '
        Me.actionTake.AutoSize = True
        Me.actionTake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actionTake.Location = New System.Drawing.Point(13, 480)
        Me.actionTake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.actionTake.Name = "actionTake"
        Me.actionTake.Size = New System.Drawing.Size(44, 18)
        Me.actionTake.TabIndex = 53
        Me.actionTake.Text = "------"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 528)
        Me.Controls.Add(Me.actionTake)
        Me.Controls.Add(Me.symptom8)
        Me.Controls.Add(Me.question3)
        Me.Controls.Add(Me.symptom7)
        Me.Controls.Add(Me.question2)
        Me.Controls.Add(Me.symptom5)
        Me.Controls.Add(Me.symptom4)
        Me.Controls.Add(Me.symptom3)
        Me.Controls.Add(Me.symptom2)
        Me.Controls.Add(Me.symptom1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.studTemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.studCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.phoneNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.matricID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fullName)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.formName)
        Me.Controls.Add(Me.msuLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        CType(Me.msuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents msuLogo As PictureBox
    Friend WithEvents formName As Label
    Friend WithEvents fullName As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents matricID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents phoneNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studCourse As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents returnButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents studTemp As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents symptom1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label5 As Label
    Friend WithEvents symptom5 As Label
    Friend WithEvents symptom4 As Label
    Friend WithEvents symptom3 As Label
    Friend WithEvents symptom2 As Label
    Friend WithEvents symptom7 As Label
    Friend WithEvents question2 As Label
    Friend WithEvents symptom8 As Label
    Friend WithEvents question3 As Label
    Friend WithEvents actionTake As Label
End Class
