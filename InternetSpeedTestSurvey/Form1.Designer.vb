<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSurvey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSurvey))
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 20
        Me.lstSpeed.Location = New System.Drawing.Point(634, 41)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(120, 224)
        Me.lstSpeed.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(312, 39)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(299, 25)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(445, 421)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(211, 20)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average Internet Speed: "
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.Turquoise
        Me.btnSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(359, 80)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(200, 39)
        Me.btnSpeed.TabIndex = 5
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'frmSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstSpeed)
        Me.Name = "frmSurvey"
        Me.Text = "frmSurvey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnSpeed As Button
End Class
