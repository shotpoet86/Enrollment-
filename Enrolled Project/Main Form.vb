' Name:         Enrolled Project
' Purpose:      Calculate and display the total numbered enrolled.
' Programmer:   Austin Parker 1/25/2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private dblUpdateEnroll As Double


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the program when user clicks.
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtNumEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtNumEnrolled.TextChanged

        'Converts the String number entered to a arithmetic number to be calculated.
        Double.TryParse(txtNumEnrolled.Text, dblUpdateEnroll)

    End Sub

    Private Sub lblTotalEnrolled_Click(sender As Object, e As EventArgs) Handles lblTotalEnrolled.Click


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Creates a Static variable to hold the total student calculation until user is finished with program.
        Static dblTotal As Double

        'Calculates the updated student number to the existing student count from the Static Double.
        dblTotal = dblTotal + dblUpdateEnroll

        'Converts the updated total number of students to String form so the label box can display .
        lblTotalEnrolled.Text = dblTotal.ToString

        'Empties the number enrolled box after clicking the update total button to allow another user input.
        txtNumEnrolled.Text = String.Empty

    End Sub
End Class
