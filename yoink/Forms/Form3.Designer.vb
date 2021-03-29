<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.clearButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1.SuspendLayout()
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
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.BackColor = System.Drawing.Color.Transparent
        Me.errorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.Location = New System.Drawing.Point(13, 23)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(67, 15)
        Me.errorLabel.TabIndex = 1
        Me.errorLabel.Text = "------------"
        '
        'clearButton
        '
        Me.clearButton.ActiveBorderThickness = 1
        Me.clearButton.ActiveCornerRadius = 20
        Me.clearButton.ActiveFillColor = System.Drawing.Color.IndianRed
        Me.clearButton.ActiveForecolor = System.Drawing.Color.Transparent
        Me.clearButton.ActiveLineColor = System.Drawing.Color.IndianRed
        Me.clearButton.BackColor = System.Drawing.SystemColors.Control
        Me.clearButton.BackgroundImage = CType(resources.GetObject("clearButton.BackgroundImage"), System.Drawing.Image)
        Me.clearButton.ButtonText = "Return"
        Me.clearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.SteelBlue
        Me.clearButton.IdleBorderThickness = 1
        Me.clearButton.IdleCornerRadius = 20
        Me.clearButton.IdleFillColor = System.Drawing.Color.Transparent
        Me.clearButton.IdleForecolor = System.Drawing.Color.Gray
        Me.clearButton.IdleLineColor = System.Drawing.Color.Gray
        Me.clearButton.Location = New System.Drawing.Point(98, 35)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(135, 42)
        Me.clearButton.TabIndex = 15
        Me.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.errorLabel)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-1, -14)
        Me.BunifuGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(331, 42)
        Me.BunifuGradientPanel1.TabIndex = 16
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(330, 84)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.clearButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form3"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents errorLabel As Label
    Friend WithEvents clearButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
