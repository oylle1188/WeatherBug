<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnGetTheWeather = New System.Windows.Forms.Button()
        Me.txtWOEID = New System.Windows.Forms.TextBox()
        Me.lblWOEID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGetTheWeather
        '
        Me.btnGetTheWeather.Location = New System.Drawing.Point(16, 171)
        Me.btnGetTheWeather.Name = "btnGetTheWeather"
        Me.btnGetTheWeather.Size = New System.Drawing.Size(221, 65)
        Me.btnGetTheWeather.TabIndex = 0
        Me.btnGetTheWeather.Text = "Get The Weather"
        Me.btnGetTheWeather.UseVisualStyleBackColor = True
        '
        'txtWOEID
        '
        Me.txtWOEID.Location = New System.Drawing.Point(92, 71)
        Me.txtWOEID.Name = "txtWOEID"
        Me.txtWOEID.Size = New System.Drawing.Size(145, 20)
        Me.txtWOEID.TabIndex = 1
        '
        'lblWOEID
        '
        Me.lblWOEID.AutoSize = True
        Me.lblWOEID.Location = New System.Drawing.Point(13, 71)
        Me.lblWOEID.Name = "lblWOEID"
        Me.lblWOEID.Size = New System.Drawing.Size(73, 13)
        Me.lblWOEID.TabIndex = 2
        Me.lblWOEID.Text = "Insert WOEID"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblWOEID)
        Me.Controls.Add(Me.txtWOEID)
        Me.Controls.Add(Me.btnGetTheWeather)
        Me.Name = "Main"
        Me.Text = "Weather Bug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetTheWeather As System.Windows.Forms.Button
    Friend WithEvents txtWOEID As System.Windows.Forms.TextBox
    Friend WithEvents lblWOEID As System.Windows.Forms.Label

End Class
