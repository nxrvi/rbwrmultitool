<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PointsCalc
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lb_next = New System.Windows.Forms.Label()
        Me.lb_current = New System.Windows.Forms.Label()
        Me.lb_error = New System.Windows.Forms.Label()
        Me.tb_nextrankpoints = New System.Windows.Forms.TextBox()
        Me.tb_u1 = New System.Windows.Forms.TextBox()
        Me.tb_u2 = New System.Windows.Forms.TextBox()
        Me.tb_totalpoints = New System.Windows.Forms.TextBox()
        Me.lb_nextrankpoints = New System.Windows.Forms.Label()
        Me.lb_total_head = New System.Windows.Forms.Label()
        Me.lb_u2points = New System.Windows.Forms.Label()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.lb_u1points = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_next
        '
        Me.lb_next.AutoSize = True
        Me.lb_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_next.Location = New System.Drawing.Point(44, 184)
        Me.lb_next.Name = "lb_next"
        Me.lb_next.Size = New System.Drawing.Size(51, 18)
        Me.lb_next.TabIndex = 570
        Me.lb_next.Text = "Label2"
        Me.lb_next.Visible = False
        '
        'lb_current
        '
        Me.lb_current.AutoSize = True
        Me.lb_current.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_current.Location = New System.Drawing.Point(44, 152)
        Me.lb_current.Name = "lb_current"
        Me.lb_current.Size = New System.Drawing.Size(51, 18)
        Me.lb_current.TabIndex = 569
        Me.lb_current.Text = "Label1"
        Me.lb_current.Visible = False
        '
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(44, 115)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(51, 17)
        Me.lb_error.TabIndex = 568
        Me.lb_error.Text = "Label1"
        Me.lb_error.Visible = False
        '
        'tb_nextrankpoints
        '
        Me.tb_nextrankpoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_nextrankpoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nextrankpoints.Location = New System.Drawing.Point(400, 179)
        Me.tb_nextrankpoints.Name = "tb_nextrankpoints"
        Me.tb_nextrankpoints.ReadOnly = True
        Me.tb_nextrankpoints.Size = New System.Drawing.Size(117, 23)
        Me.tb_nextrankpoints.TabIndex = 561
        Me.tb_nextrankpoints.Text = "0"
        Me.tb_nextrankpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_u1
        '
        Me.tb_u1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_u1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_u1.Location = New System.Drawing.Point(47, 73)
        Me.tb_u1.MaxLength = 10
        Me.tb_u1.Name = "tb_u1"
        Me.tb_u1.Size = New System.Drawing.Size(117, 23)
        Me.tb_u1.TabIndex = 558
        Me.tb_u1.Text = "0"
        Me.tb_u1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_u2
        '
        Me.tb_u2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_u2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_u2.Location = New System.Drawing.Point(224, 73)
        Me.tb_u2.MaxLength = 10
        Me.tb_u2.Name = "tb_u2"
        Me.tb_u2.Size = New System.Drawing.Size(117, 23)
        Me.tb_u2.TabIndex = 559
        Me.tb_u2.Text = "0"
        Me.tb_u2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_totalpoints
        '
        Me.tb_totalpoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_totalpoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_totalpoints.Location = New System.Drawing.Point(400, 73)
        Me.tb_totalpoints.Name = "tb_totalpoints"
        Me.tb_totalpoints.ReadOnly = True
        Me.tb_totalpoints.Size = New System.Drawing.Size(117, 23)
        Me.tb_totalpoints.TabIndex = 560
        Me.tb_totalpoints.Text = "0"
        Me.tb_totalpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_nextrankpoints
        '
        Me.lb_nextrankpoints.AutoSize = True
        Me.lb_nextrankpoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nextrankpoints.Location = New System.Drawing.Point(406, 139)
        Me.lb_nextrankpoints.Name = "lb_nextrankpoints"
        Me.lb_nextrankpoints.Size = New System.Drawing.Size(99, 34)
        Me.lb_nextrankpoints.TabIndex = 562
        Me.lb_nextrankpoints.Text = "Points needed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for next rank"
        '
        'lb_total_head
        '
        Me.lb_total_head.AutoSize = True
        Me.lb_total_head.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_head.Location = New System.Drawing.Point(417, 44)
        Me.lb_total_head.Name = "lb_total_head"
        Me.lb_total_head.Size = New System.Drawing.Size(83, 17)
        Me.lb_total_head.TabIndex = 565
        Me.lb_total_head.Text = "Total Points"
        '
        'lb_u2points
        '
        Me.lb_u2points.AutoSize = True
        Me.lb_u2points.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_u2points.Location = New System.Drawing.Point(240, 44)
        Me.lb_u2points.Name = "lb_u2points"
        Me.lb_u2points.Size = New System.Drawing.Size(88, 17)
        Me.lb_u2points.TabIndex = 564
        Me.lb_u2points.Text = "Unit 2 Points"
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.Location = New System.Drawing.Point(166, 7)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(232, 22)
        Me.lb_title.TabIndex = 567
        Me.lb_title.Text = "Points Calculator for RBWR"
        '
        'lb_u1points
        '
        Me.lb_u1points.AutoSize = True
        Me.lb_u1points.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_u1points.Location = New System.Drawing.Point(59, 44)
        Me.lb_u1points.Name = "lb_u1points"
        Me.lb_u1points.Size = New System.Drawing.Size(88, 17)
        Me.lb_u1points.TabIndex = 563
        Me.lb_u1points.Text = "Unit 1 Points"
        '
        'PointsCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lb_next)
        Me.Controls.Add(Me.lb_current)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.tb_nextrankpoints)
        Me.Controls.Add(Me.tb_u1)
        Me.Controls.Add(Me.tb_u2)
        Me.Controls.Add(Me.tb_totalpoints)
        Me.Controls.Add(Me.lb_nextrankpoints)
        Me.Controls.Add(Me.lb_total_head)
        Me.Controls.Add(Me.lb_u2points)
        Me.Controls.Add(Me.lb_title)
        Me.Controls.Add(Me.lb_u1points)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PointsCalc"
        Me.Size = New System.Drawing.Size(570, 244)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_next As Label
    Friend WithEvents lb_current As Label
    Friend WithEvents lb_error As Label
    Friend WithEvents tb_nextrankpoints As TextBox
    Friend WithEvents tb_u1 As TextBox
    Friend WithEvents tb_u2 As TextBox
    Friend WithEvents tb_totalpoints As TextBox
    Friend WithEvents lb_nextrankpoints As Label
    Friend WithEvents lb_total_head As Label
    Friend WithEvents lb_u2points As Label
    Friend WithEvents lb_title As Label
    Friend WithEvents lb_u1points As Label
End Class
