
# Pratical Homework1 in VB

## Write a program in C# or VB.NET that creates a window containing a single line, point, circle, rectangle.

Below you can see an image containing the output of the code and the code itself. If you want to start the project on visual studio click the following link and download the folder [2023-10-06-BB_pratical_homework.zip](https://github.com/Garufi1962596/Garufi1962596.github.io/edit/main/_posts)

![it is not possible to view the image please click on the repository link](/VB_HW1.png)

    Imports System.Drawing

    Public Class Form1

            Private Sub DrawCircle(bitmap As Bitmap)
                Using g As Graphics = Graphics.FromImage(bitmap)
        
                    ' To define the circle properties
                    Using pen As New Pen(Color.Black, 3)
                        Dim radius As Integer = 50
                        Dim centerX As Integer = bitmap.Width \ 2 ' X coordinate of the center
                        Dim centerY As Integer = bitmap.Height \ 2 ' Y coordinate of the center
        
                        ' to draw a circle
                        g.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2)
                    End Using
                End Using
            End Sub
        
            Private Sub DrawLine(bitmap As Bitmap)
        
                Using g As Graphics = Graphics.FromImage(bitmap)
        
                    ' To define the line properties
                    Using pen As New Pen(Color.Green, 3)
                        Dim startX As Integer = 0
                        Dim startY As Integer = bitmap.Height \ 2
                        Dim endX As Integer = bitmap.Width
                        Dim endY As Integer = bitmap.Height \ 2
        
                        ' to draw a line
                        g.DrawLine(pen, startX, startY, endX, endY)
                    End Using
                End Using
            End Sub
        
            Private Sub DrawPoint(bitmap As Bitmap)
                Using g As Graphics = Graphics.FromImage(bitmap)
                    ' To define the point properties
                    Using pen As New Pen(Color.Blue, 3)
                        Dim x As Integer = 50
                        Dim y As Integer = 50
                        Dim width As Integer = 1
                        Dim height As Integer = 1
        
                        ' to draw a point
                        g.DrawRectangle(pen, x, y, width, height)
        
                    End Using
                End Using
            End Sub
        
            Private Sub DrawRectangle(bitmap As Bitmap)
                Using g As Graphics = Graphics.FromImage(bitmap)
                    ' To define the rectangle properties
                    Using pen As New Pen(Color.Red)
                        Dim x As Integer = 0
                        Dim y As Integer = 0
                        Dim width As Integer = bitmap.Width - 1
                        Dim height As Integer = bitmap.Height / 2
        
                        ' to draw a rectangle
                        g.DrawRectangle(pen, x, y, width, height)
                    End Using
                End Using
            End Sub
        
            Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
                ' to Create a Bitmap to draw on
                Dim bitmap As New Bitmap(PictureBoxCircle.Width, PictureBoxCircle.Height)
        
                ' to Call the drawing functions for each shape
                DrawCircle(bitmap)
                PictureBoxCircle.Image = bitmap.Clone()
        
                bitmap = New Bitmap(PictureBoxLine.Width, PictureBoxLine.Height)
                DrawLine(bitmap)
                PictureBoxLine.Image = bitmap.Clone()
        
                bitmap = New Bitmap(PictureBoxPoint.Width, PictureBoxPoint.Height)
                DrawPoint(bitmap)
                PictureBoxPoint.Image = bitmap.Clone()
        
                bitmap = New Bitmap(PictureBoxRectangle.Width, PictureBoxRectangle.Height)
                DrawRectangle(bitmap)
                PictureBoxRectangle.Image = bitmap.Clone()
            End Sub
    End Class
