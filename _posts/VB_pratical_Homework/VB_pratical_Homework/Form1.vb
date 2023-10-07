Imports System.Windows.Forms.AxHost

Public Class Form1

    Private Sub Circle_Click(sender As Object, e As EventArgs) Handles Circle.Click
        Dim g As Graphics = PictureBoxCircle.CreateGraphics()

        ' To define the circle properties
        Dim pen As New Pen(Color.Black, 3)
        Dim radius As Integer = 50
        Dim centerX As Integer = PictureBoxCircle.Width \ 2 ' X coordinate of the center
        Dim centerY As Integer = PictureBoxCircle.Height \ 2 ' Y coordinate of the center

        ' to draw circle
        g.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2) 'This method is used to draw an ellipse

        ' Releases the graphics
        g.Dispose()
    End Sub

    Private Sub Line_Click(sender As Object, e As EventArgs) Handles Line.Click
        Dim g As Graphics = PictureBoxLine.CreateGraphics()

        Dim pen As New Pen(Color.Green, 3) ' to assign the color

        Dim startX As Integer = 0
        Dim startY As Integer = PictureBoxLine.Height \ 2 ' X  and Y coordinates of start point
        Dim endX As Integer = PictureBoxLine.Width
        Dim endY As Integer = PictureBoxLine.Height \ 2   ' X  and Y coordinates of end point

        g.DrawLine(pen, startX, startY, endX, endY) 'This method is used to draw a line
        g.Dispose()
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles Point.Click
        Dim g As Graphics = PictureBoxPoint.CreateGraphics()
        Dim pen As New Pen(Color.Blue, 3) ' to assign the color

        ' to define the coordinates of the point  
        Dim x As Integer = 50
        Dim y As Integer = 50

        ' to define the rectangle size (1x1 pixels for a dot)
        Dim width As Integer = 1
        Dim height As Integer = 1

        ' to draw a point
        g.DrawRectangle(pen, x, y, width, height)


        g.Dispose()
    End Sub

    Private Sub Triangle_Click(sender As Object, e As EventArgs) Handles Triangle.Click
        Dim g As Graphics = PictureBoxTriangle.CreateGraphics()
        Dim pen As New Pen(Color.Red, 3) ' to assign the color

        'to define the points that make up the triangle
        Dim point1 As New Point(50, 10)
        Dim point2 As New Point(10, 100)
        Dim point3 As New Point(90, 100)

        ' to create an array of points with the points of the triangle
        Dim trianglePoints() As Point = {point1, point2, point3}

        ' to draw a triangle 
        g.DrawPolygon(pen, trianglePoints)


        g.Dispose()
    End Sub
End Class
