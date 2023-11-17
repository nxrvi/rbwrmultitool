<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ts_1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_pc = New System.Windows.Forms.ToolStripButton()
        Me.tsb_dta = New System.Windows.Forms.ToolStripButton()
        Me.PointsCalc1 = New PointsCalculator.PointsCalc()
        Me.DemandToAPRM1 = New PointsCalculator.DemandToAPRM()
        Me.ts_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 558
        Me.Label1.Text = "Created by nxrvi :> | Icon owned by RBWR"
        '
        'ts_1
        '
        Me.ts_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ts_1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ts_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_pc, Me.tsb_dta})
        Me.ts_1.Location = New System.Drawing.Point(0, 0)
        Me.ts_1.Name = "ts_1"
        Me.ts_1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ts_1.Size = New System.Drawing.Size(570, 26)
        Me.ts_1.TabIndex = 559
        Me.ts_1.Text = "ToolStrip1"
        '
        'tsb_pc
        '
        Me.tsb_pc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsb_pc.Image = CType(resources.GetObject("tsb_pc.Image"), System.Drawing.Image)
        Me.tsb_pc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_pc.Name = "tsb_pc"
        Me.tsb_pc.Size = New System.Drawing.Size(115, 23)
        Me.tsb_pc.Text = "Points Calculator"
        '
        'tsb_dta
        '
        Me.tsb_dta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsb_dta.Image = CType(resources.GetObject("tsb_dta.Image"), System.Drawing.Image)
        Me.tsb_dta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_dta.Name = "tsb_dta"
        Me.tsb_dta.Size = New System.Drawing.Size(125, 23)
        Me.tsb_dta.Text = "Demand To APRM"
        '
        'PointsCalc1
        '
        Me.PointsCalc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PointsCalc1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PointsCalc1.Location = New System.Drawing.Point(0, 29)
        Me.PointsCalc1.Name = "PointsCalc1"
        Me.PointsCalc1.Size = New System.Drawing.Size(570, 244)
        Me.PointsCalc1.TabIndex = 560
        '
        'DemandToAPRM1
        '
        Me.DemandToAPRM1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DemandToAPRM1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DemandToAPRM1.Location = New System.Drawing.Point(0, 29)
        Me.DemandToAPRM1.Name = "DemandToAPRM1"
        Me.DemandToAPRM1.Size = New System.Drawing.Size(570, 244)
        Me.DemandToAPRM1.TabIndex = 561
        Me.DemandToAPRM1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(570, 298)
        Me.Controls.Add(Me.DemandToAPRM1)
        Me.Controls.Add(Me.PointsCalc1)
        Me.Controls.Add(Me.ts_1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Points Calculator"
        Me.ts_1.ResumeLayout(False)
        Me.ts_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ts_1 As ToolStrip
    Friend WithEvents tsb_pc As ToolStripButton
    Friend WithEvents tsb_dta As ToolStripButton
    Friend WithEvents PointsCalc1 As PointsCalculator.PointsCalc
    Friend WithEvents DemandToAPRM1 As PointsCalculator.DemandToAPRM
End Class
