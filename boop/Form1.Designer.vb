<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOOP))
        Me.BOOPbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BOOPbutton
        '
        Me.BOOPbutton.Location = New System.Drawing.Point(5, 6)
        Me.BOOPbutton.Name = "BOOPbutton"
        Me.BOOPbutton.Size = New System.Drawing.Size(173, 39)
        Me.BOOPbutton.TabIndex = 0
        Me.BOOPbutton.Text = "BOOP"
        Me.BOOPbutton.UseVisualStyleBackColor = True
        '
        'BOOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 51)
        Me.Controls.Add(Me.BOOPbutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(20, 20)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BOOP"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOOP"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BOOPbutton As Button
End Class
