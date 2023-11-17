Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(32, 32, 32)
        ts_1.BackColor = Color.FromArgb(32, 32, 32)
        tsb_dta.BackColor = Color.FromArgb(25, 25, 25)
        tsb_pc.BackColor = Color.FromArgb(25, 25, 25)
        ts_1.Renderer = New OverrideControls.ToolStripOverride()
        Me.ForeColor = Color.FromArgb(248, 248, 248)
        DemandToAPRM1.Visible = False
    End Sub

    Private Sub tsbtnSearch_Paint(sender As Object, e As PaintEventArgs) Handles tsb_pc.Paint
        Dim btn As ToolStripButton = DirectCast(sender, ToolStripButton)
        ControlPaint.DrawBorder(e.Graphics, New Rectangle(0, 0, btn.Width, btn.Height), Color.FromArgb(32, 32, 32), ButtonBorderStyle.Solid)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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

    Private Sub tsb_pc_Click(sender As Object, e As EventArgs) Handles tsb_pc.Click
        DemandToAPRM1.Visible = False
        PointsCalc1.Visible = True
    End Sub

    Private Sub tsb_dta_Click(sender As Object, e As EventArgs) Handles tsb_dta.Click
        DemandToAPRM1.Visible = True
        PointsCalc1.Visible = False
    End Sub
End Class

Namespace OverrideControls
    Public Class ToolStripOverride
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
        End Sub

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        End Sub
    End Class

    Public Class MainFormToolStripRenderer
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
            Me.RoundedEdges = False
        End Sub
    End Class
End Namespace
