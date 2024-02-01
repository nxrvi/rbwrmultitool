<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DemandToAPRM
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
        Me.lb_title2 = New System.Windows.Forms.Label()
        Me.lb_error = New System.Windows.Forms.Label()
        Me.tb_demand = New System.Windows.Forms.TextBox()
        Me.tb_aprm = New System.Windows.Forms.TextBox()
        Me.tb_feedflow = New System.Windows.Forms.TextBox()
        Me.lb_feedflow = New System.Windows.Forms.Label()
        Me.lb_aprm = New System.Windows.Forms.Label()
        Me.lb_demand = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_genload = New System.Windows.Forms.Label()
        Me.tb_genload = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lb_title2
        '
        Me.lb_title2.AutoSize = True
        Me.lb_title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title2.Location = New System.Drawing.Point(163, 6)
        Me.lb_title2.Name = "lb_title2"
        Me.lb_title2.Size = New System.Drawing.Size(239, 22)
        Me.lb_title2.TabIndex = 567
        Me.lb_title2.Text = "Demand to APRM Calculator"
        '
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(41, 193)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(51, 17)
        Me.lb_error.TabIndex = 575
        Me.lb_error.Text = "Label1"
        Me.lb_error.Visible = False
        '
        'tb_demand
        '
        Me.tb_demand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_demand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_demand.Location = New System.Drawing.Point(226, 73)
        Me.tb_demand.MaxLength = 10
        Me.tb_demand.Name = "tb_demand"
        Me.tb_demand.Size = New System.Drawing.Size(117, 23)
        Me.tb_demand.TabIndex = 569
        Me.tb_demand.Text = "0"
        Me.tb_demand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_aprm
        '
        Me.tb_aprm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_aprm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_aprm.Location = New System.Drawing.Point(44, 73)
        Me.tb_aprm.MaxLength = 10
        Me.tb_aprm.Name = "tb_aprm"
        Me.tb_aprm.Size = New System.Drawing.Size(117, 23)
        Me.tb_aprm.TabIndex = 570
        Me.tb_aprm.Text = "0"
        Me.tb_aprm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_feedflow
        '
        Me.tb_feedflow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_feedflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_feedflow.Location = New System.Drawing.Point(400, 73)
        Me.tb_feedflow.Name = "tb_feedflow"
        Me.tb_feedflow.ReadOnly = True
        Me.tb_feedflow.Size = New System.Drawing.Size(117, 23)
        Me.tb_feedflow.TabIndex = 571
        Me.tb_feedflow.Text = "0"
        Me.tb_feedflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_feedflow
        '
        Me.lb_feedflow.AutoSize = True
        Me.lb_feedflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_feedflow.Location = New System.Drawing.Point(406, 44)
        Me.lb_feedflow.Name = "lb_feedflow"
        Me.lb_feedflow.Size = New System.Drawing.Size(106, 17)
        Me.lb_feedflow.TabIndex = 574
        Me.lb_feedflow.Text = "Feedwater Flow"
        '
        'lb_aprm
        '
        Me.lb_aprm.AutoSize = True
        Me.lb_aprm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_aprm.Location = New System.Drawing.Point(62, 44)
        Me.lb_aprm.Name = "lb_aprm"
        Me.lb_aprm.Size = New System.Drawing.Size(78, 17)
        Me.lb_aprm.TabIndex = 573
        Me.lb_aprm.Text = "APRM in %"
        '
        'lb_demand
        '
        Me.lb_demand.AutoSize = True
        Me.lb_demand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_demand.Location = New System.Drawing.Point(228, 44)
        Me.lb_demand.Name = "lb_demand"
        Me.lb_demand.Size = New System.Drawing.Size(104, 17)
        Me.lb_demand.TabIndex = 572
        Me.lb_demand.Text = "Demand in MW"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 13)
        Me.Label1.TabIndex = 576
        Me.Label1.Text = "Actual output can be +/- a few MW depending on Reactor Type!"
        '
        'lb_genload
        '
        Me.lb_genload.AutoSize = True
        Me.lb_genload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_genload.Location = New System.Drawing.Point(45, 125)
        Me.lb_genload.Name = "lb_genload"
        Me.lb_genload.Size = New System.Drawing.Size(114, 17)
        Me.lb_genload.TabIndex = 573
        Me.lb_genload.Text = "Gen Load in MW"
        '
        'tb_genload
        '
        Me.tb_genload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_genload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_genload.Location = New System.Drawing.Point(44, 154)
        Me.tb_genload.MaxLength = 10
        Me.tb_genload.Name = "tb_genload"
        Me.tb_genload.Size = New System.Drawing.Size(117, 23)
        Me.tb_genload.TabIndex = 570
        Me.tb_genload.Text = "0"
        Me.tb_genload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DemandToAPRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.tb_demand)
        Me.Controls.Add(Me.tb_genload)
        Me.Controls.Add(Me.tb_aprm)
        Me.Controls.Add(Me.tb_feedflow)
        Me.Controls.Add(Me.lb_feedflow)
        Me.Controls.Add(Me.lb_genload)
        Me.Controls.Add(Me.lb_aprm)
        Me.Controls.Add(Me.lb_demand)
        Me.Controls.Add(Me.lb_title2)
        Me.Name = "DemandToAPRM"
        Me.Size = New System.Drawing.Size(570, 244)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_title2 As Label
    Friend WithEvents lb_error As Label
    Friend WithEvents tb_demand As TextBox
    Friend WithEvents tb_aprm As TextBox
    Friend WithEvents tb_feedflow As TextBox
    Friend WithEvents lb_feedflow As Label
    Friend WithEvents lb_aprm As Label
    Friend WithEvents lb_demand As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_genload As Label
    Friend WithEvents tb_genload As TextBox
End Class
