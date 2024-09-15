<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Library
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Library))
        NewBookBtn = New Button()
        NewStudentBtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NewBookBtn
        ' 
        NewBookBtn.Location = New Point(12, 12)
        NewBookBtn.Name = "NewBookBtn"
        NewBookBtn.Size = New Size(75, 23)
        NewBookBtn.TabIndex = 0
        NewBookBtn.Text = "New Book"
        NewBookBtn.UseVisualStyleBackColor = True
        ' 
        ' NewStudentBtn
        ' 
        NewStudentBtn.Location = New Point(93, 12)
        NewStudentBtn.Name = "NewStudentBtn"
        NewStudentBtn.Size = New Size(95, 23)
        NewStudentBtn.TabIndex = 1
        NewStudentBtn.Text = "New Student"
        NewStudentBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(191, 129)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Library
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 327)
        Controls.Add(PictureBox1)
        Controls.Add(NewStudentBtn)
        Controls.Add(NewBookBtn)
        Name = "Library"
        Text = "Library"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NewBookBtn As Button
    Friend WithEvents NewStudentBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
