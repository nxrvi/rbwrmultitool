Public Class DemandToAPRM

    Dim supressTB_Demand As Boolean = False
    Dim supressTB_APRM As Boolean = False

    Public Enum CalcType
        MWtoAPRM
        APRMtoMW
    End Enum
    Private Sub DemandToAPRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(32, 32, 32)
        Me.ForeColor = Color.FromArgb(248, 248, 248)
        tb_aprm.BackColor = Color.FromArgb(75, 75, 75)
        tb_aprm.ForeColor = Color.FromArgb(248, 248, 248)
        tb_demand.BackColor = Color.FromArgb(75, 75, 75)
        tb_demand.ForeColor = Color.FromArgb(248, 248, 248)
        tb_feedflow.BackColor = Color.FromArgb(75, 75, 75)
        tb_feedflow.ForeColor = Color.FromArgb(248, 248, 248)
    End Sub

    Private Sub DemandToAPRM_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
    Private Sub tb_demand_TextChanged(sender As Object, e As EventArgs) Handles tb_demand.TextChanged

        If supressTB_Demand Then
            Return
        End If

        supressTB_APRM = True

        Dim a As Integer
        Dim invalid As Integer = 0
        Dim y As Decimal

        Try
            a = CDec(tb_demand.Text)
            If a < 0 Then
                invalid = 2
                a = 0
            End If
        Catch ex As Exception
            invalid = 1
            a = 0
        End Try

        If invalid = 2 Then
            tb_demand.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be greater than 0!"
        End If
        If invalid = 1 Then
            tb_demand.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers!"
        End If

        If invalid = 0 Then
            tb_demand.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = False
        End If

        y = Calc(a, CalcType.MWtoAPRM)

        tb_aprm.Text = y

        If y > 100 Then
            lb_error.Visible = True
            lb_error.Text = "It is generally not recommended to exceed 100% APRM"
            tb_aprm.BackColor = Color.Red
        Else
            tb_aprm.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = False
        End If

        tb_feedflow.Text = CalcFlow(y)

        supressTB_APRM = False
    End Sub

    Private Sub tb_aprm_TextChanged(sender As Object, e As EventArgs) Handles tb_aprm.TextChanged

        If supressTB_APRM Then
            Return
        End If

        supressTB_Demand = True

        Dim a As Integer
        Dim invalid As Integer = 0
        Dim y As Decimal

        Try
            a = CDec(tb_aprm.Text)
            If a < 0 Then
                invalid = 2
                a = 0
            End If
        Catch ex As Exception
            invalid = 1
            a = 0
        End Try

        If invalid = 2 Then
            tb_aprm.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be greater than 0!"
        End If
        If invalid = 1 Then
            tb_aprm.BackColor = Color.Red
            lb_error.Visible = True
            lb_error.Text = "The values in the fields must be numbers!"
        End If

        If invalid = 0 Then
            tb_aprm.BackColor = Color.FromArgb(75, 75, 75)
            lb_error.Visible = False
        End If

        y = Calc(a, CalcType.APRMtoMW)

        If y < 0 Then
            y = 0
        End If

        tb_demand.Text = y

        If a > 100 Then
            lb_error.Visible = True
            lb_error.Text = "It is generally not recommended to exceed 100% APRM"
            tb_aprm.BackColor = Color.Red
        End If

        tb_feedflow.Text = CalcFlow(a)

        supressTB_Demand = False
    End Sub
    Function Calc(ByVal a As Integer, ByVal calctype As CalcType)
        Dim y As Decimal
        If calctype = CalcType.APRMtoMW Then
            y = 14.3 * a - 163 - 42.7
            Return Math.Round(y, 1)
        ElseIf calctype = CalcType.MWtoAPRM Then
            y = (a + 163 + 42.7) / 14.3
            Return Math.Round(y, 2)
        End If
    End Function

    Function CalcFlow(ByVal therm As Integer)
        Dim y As Decimal

        y = 82.9 + (13.7 * therm) + (5.87 * ((10 ^ -3) * therm ^ 2))

        Return Math.Round(y, 1)

    End Function

End Class
