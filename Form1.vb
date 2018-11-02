'Chris Unger
'CSC 101-02
'Assignment 8 - Average Income of Employees
'Purpose - Using Input Box, Do While Loop, and Counters to compute total and average income of Employees

Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Declare Variables
        Const intNUM_EMP As Integer = 5         'The number of Employees
        Dim strInput As String                  'Hold string Input
        Dim decAverage As Decimal
        Dim decIncome As Decimal                'Hold Income
        Dim intCount As Integer = 1             'Loop Counter
        Dim decTotal As Decimal = 0             'To Hold Total Income

        ' Get the Number of Employees
        Do While intCount <= intNUM_EMP

            ' Get the Pay of the Employees
            strInput = InputBox("Enter the pay of the Employee" &
                       intCount.ToString(), "Input Income")

            ' Convert the Input to Decimal
            If Decimal.TryParse(strInput, decIncome) Then

                ' Add the Employee Pay to the Total Income
                decTotal += decIncome

                ' Add 1 to the Loop Counter
                intCount += 1
            Else
                ' Display an Error Message for Invalid Data
                MessageBox.Show("Enter a Numeric Value.")
            End If
        Loop

        'Compute the Average
        decAverage = decTotal / intNUM_EMP

        ' Display the Total Sales
        lblTotal.Text = decTotal.ToString("c")
        lblEmps.Text = intNUM_EMP.ToString("n0")
        lblAverage.Text = decAverage.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear All Labels
        lblEmps.Text = String.Empty
        lblAverage.Text = String.Empty
        lblTotal.Text = String.Empty

        'Focus returns on btnEnter
        btnEnter.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits Application
        Me.Close()
    End Sub
End Class
