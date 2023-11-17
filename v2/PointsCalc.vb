Public Class PointsCalc
    Dim CurrentRank As Rank
    Dim NextRank As Rank
    Dim remainingpoints As Decimal

    Dim ranks() As Rank = {
        New Rank("Highest Rank achieved", 999999999),
        New Rank("Chief Inspector", 5000000),
        New Rank("Senior Inspector", 2000000),
        New Rank("Inspector", 1000000),
        New Rank("Junior Inspector", 500000),
        New Rank("Senior Supervisor", 200000),
        New Rank("Supervisor", 100000),
        New Rank("Junior Supervisor", 50000),
        New Rank("Senior Operator", 20000),
        New Rank("Operator", 10000),
        New Rank("Junior Operator", 5000),
        New Rank("Worker", 2000),
        New Rank("Trainee", 1000),
        New Rank("Visitor", 0)
        }

    Private Sub UserControl1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(32, 32, 32)
        tb_u1.BackColor = Color.FromArgb(75, 75, 75)
        tb_u1.ForeColor = Color.FromArgb(248, 248, 248)
        tb_u2.BackColor = Color.FromArgb(75, 75, 75)
        tb_u2.ForeColor = Color.FromArgb(248, 248, 248)
        tb_totalpoints.BackColor = Color.FromArgb(75, 75, 75)
        tb_totalpoints.ForeColor = Color.FromArgb(248, 248, 248)
        tb_nextrankpoints.BackColor = Color.FromArgb(75, 75, 75)
        tb_nextrankpoints.ForeColor = Color.FromArgb(248, 248, 248)
        Me.ForeColor = Color.FromArgb(248, 248, 248)

    End Sub
    Private Sub UserControl1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.FromArgb(50, 50, 50), 4.0)
        For Each ctr As Control In Me.Controls
            If TypeOf ctr Is TextBox Then
                g.DrawRectangle(pen, New _
                Rectangle(ctr.Location, ctr.Size))
            End If
        Next
        pen.Dispose()
    End Sub

    Private Sub UpdateText(sender As System.Object, e As System.EventArgs) Handles tb_u1.TextChanged, tb_u2.TextChanged
        Dim a As Integer
        Dim b As Integer
        Dim invalid1 As Integer = 0
        Dim invalid2 As Integer = 0

        Try
            a = CDec(tb_u1.Text)
            If a < 0 Then
                invalid1 = 2
                a = 0
            End If
        Catch ex As Exception
            invalid1 = 1
            a = 0
        End Try

        Try
            b = CDec(tb_u2.Text)
            If b < 0 Then
                invalid2 = 2
                b = 0
            End If
        Catch ex As Exception
            invalid2 = 1
            b = 0
        End Try

        If invalid1 = 2 And invalid2 = 2 Then
            tb_u2.BackColor = Color.Red
            tb_u1.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be greater than 0!"
        ElseIf invalid1 = 2 And invalid2 = 0 Then
            tb_u2.BackColor = Color.FromArgb(75, 75, 75)
            tb_u1.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be greater than 0!"
        ElseIf invalid1 = 0 And invalid2 = 2 Then
            tb_u2.BackColor = Color.Red
            tb_u1.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be greater than 0!"
        End If
        If invalid1 = 1 And invalid2 = 1 Then
            tb_u2.BackColor = Color.Red
            tb_u1.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers!"
        ElseIf invalid1 = 1 And invalid2 = 0 Then
            tb_u2.BackColor = Color.FromArgb(75, 75, 75)
            tb_u1.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers!"
        ElseIf invalid1 = 0 And invalid2 = 1 Then
            tb_u2.BackColor = Color.Red
            tb_u1.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers!"
        ElseIf invalid1 = 1 And invalid2 = 2 Or invalid1 = 2 And invalid2 = 1 Then
            tb_u2.BackColor = Color.Red
            tb_u1.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers and greater than 0!"
        End If

        If invalid1 = 0 And invalid2 = 0 Then
            tb_u1.BackColor = Color.FromArgb(75, 75, 75)
            tb_u2.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = False
        End If

        remainingpoints = UpdateRank(a + b)
        If NextRank.Name = "Highest Rank achieved" Then
            remainingpoints = 0
        End If

        tb_totalpoints.Text = a + b
        tb_nextrankpoints.Text = remainingpoints
        lb_current.Text = "Your current rank is: " & CurrentRank.Name
        lb_current.Visible = True
        lb_next.Text = "Your next rank will be: " & NextRank.Name
        lb_next.Visible = True
    End Sub

    Function UpdateRank(ByVal total As Integer)
        For Each rank As Rank In ranks
            If total < rank.Amount Then
                NextRank = rank
            End If
            If total >= rank.Amount Then
                CurrentRank = rank
                Return (NextRank.Amount - total)
            End If
        Next
        Return Nothing
    End Function
End Class

Public Class Rank
    Public Property Name As String
    Public Property Amount As Integer

    Public Sub New(name As String, amount As Integer)
        Me.Name = name
        Me.Amount = amount
    End Sub
End Class
