<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Course = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.pic_SplashScreen = New System.Windows.Forms.PictureBox()
        CType(Me.pic_SplashScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Final Project"
        '
        'lbl_Course
        '
        Me.lbl_Course.AutoSize = True
        Me.lbl_Course.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Course.Location = New System.Drawing.Point(307, 104)
        Me.lbl_Course.Name = "lbl_Course"
        Me.lbl_Course.Size = New System.Drawing.Size(320, 54)
        Me.lbl_Course.TabIndex = 5
        Me.lbl_Course.Text = "CPT-206-A01S"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(307, 27)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(292, 54)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "Barry Norton"
        '
        'pic_SplashScreen
        '
        Me.pic_SplashScreen.Image = CType(resources.GetObject("pic_SplashScreen.Image"), System.Drawing.Image)
        Me.pic_SplashScreen.Location = New System.Drawing.Point(21, 36)
        Me.pic_SplashScreen.Name = "pic_SplashScreen"
        Me.pic_SplashScreen.Size = New System.Drawing.Size(280, 183)
        Me.pic_SplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_SplashScreen.TabIndex = 8
        Me.pic_SplashScreen.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 237)
        Me.Controls.Add(Me.pic_SplashScreen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Course)
        Me.Controls.Add(Me.lbl_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Final Project SplashScreen"
        CType(Me.pic_SplashScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Course As Label
    Friend WithEvents lbl_Name As Label
    Friend WithEvents pic_SplashScreen As PictureBox
End Class
