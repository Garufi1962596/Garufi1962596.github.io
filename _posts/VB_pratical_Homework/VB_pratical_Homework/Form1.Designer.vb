<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Circle = New System.Windows.Forms.Button()
        Me.Line = New System.Windows.Forms.Button()
        Me.Point = New System.Windows.Forms.Button()
        Me.Triangle = New System.Windows.Forms.Button()
        Me.PictureBoxCircle = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLine = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPoint = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTriangle = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Circle
        '
        Me.Circle.Location = New System.Drawing.Point(31, 26)
        Me.Circle.Name = "Circle"
        Me.Circle.Size = New System.Drawing.Size(130, 55)
        Me.Circle.TabIndex = 0
        Me.Circle.Text = "Circle"
        Me.Circle.UseVisualStyleBackColor = True
        '
        'Line
        '
        Me.Line.Location = New System.Drawing.Point(220, 26)
        Me.Line.Name = "Line"
        Me.Line.Size = New System.Drawing.Size(130, 55)
        Me.Line.TabIndex = 1
        Me.Line.Text = "Line"
        Me.Line.UseVisualStyleBackColor = True
        '
        'Point
        '
        Me.Point.Location = New System.Drawing.Point(411, 26)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(130, 55)
        Me.Point.TabIndex = 2
        Me.Point.Text = "Point"
        Me.Point.UseVisualStyleBackColor = True
        '
        'Triangle
        '
        Me.Triangle.Location = New System.Drawing.Point(594, 26)
        Me.Triangle.Name = "Triangle"
        Me.Triangle.Size = New System.Drawing.Size(130, 55)
        Me.Triangle.TabIndex = 3
        Me.Triangle.Text = "Triangle"
        Me.Triangle.UseVisualStyleBackColor = True
        '
        'PictureBoxCircle
        '
        Me.PictureBoxCircle.Location = New System.Drawing.Point(26, 130)
        Me.PictureBoxCircle.Name = "PictureBoxCircle"
        Me.PictureBoxCircle.Size = New System.Drawing.Size(135, 119)
        Me.PictureBoxCircle.TabIndex = 4
        Me.PictureBoxCircle.TabStop = False
        '
        'PictureBoxLine
        '
        Me.PictureBoxLine.Location = New System.Drawing.Point(220, 130)
        Me.PictureBoxLine.Name = "PictureBoxLine"
        Me.PictureBoxLine.Size = New System.Drawing.Size(121, 119)
        Me.PictureBoxLine.TabIndex = 5
        Me.PictureBoxLine.TabStop = False
        '
        'PictureBoxPoint
        '
        Me.PictureBoxPoint.Location = New System.Drawing.Point(411, 130)
        Me.PictureBoxPoint.Name = "PictureBoxPoint"
        Me.PictureBoxPoint.Size = New System.Drawing.Size(130, 119)
        Me.PictureBoxPoint.TabIndex = 6
        Me.PictureBoxPoint.TabStop = False
        '
        'PictureBoxTriangle
        '
        Me.PictureBoxTriangle.Location = New System.Drawing.Point(594, 130)
        Me.PictureBoxTriangle.Name = "PictureBoxTriangle"
        Me.PictureBoxTriangle.Size = New System.Drawing.Size(130, 119)
        Me.PictureBoxTriangle.TabIndex = 7
        Me.PictureBoxTriangle.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxTriangle)
        Me.Controls.Add(Me.PictureBoxPoint)
        Me.Controls.Add(Me.PictureBoxLine)
        Me.Controls.Add(Me.PictureBoxCircle)
        Me.Controls.Add(Me.Triangle)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.Line)
        Me.Controls.Add(Me.Circle)
        Me.Name = "Form1"
        Me.Text = "X"
        CType(Me.PictureBoxCircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Circle As Button
    Friend WithEvents Line As Button
    Friend WithEvents Point As Button
    Friend WithEvents Triangle As Button
    Friend WithEvents PictureBoxCircle As PictureBox
    Friend WithEvents PictureBoxLine As PictureBox
    Friend WithEvents PictureBoxPoint As PictureBox
    Friend WithEvents PictureBoxTriangle As PictureBox
End Class
