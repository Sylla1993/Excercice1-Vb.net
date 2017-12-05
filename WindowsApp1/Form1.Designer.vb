<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtentrer = New System.Windows.Forms.TextBox()
        Me.lblentrer = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtentrer
        '
        Me.txtentrer.Location = New System.Drawing.Point(250, 36)
        Me.txtentrer.Name = "txtentrer"
        Me.txtentrer.Size = New System.Drawing.Size(180, 26)
        Me.txtentrer.TabIndex = 0
        '
        'lblentrer
        '
        Me.lblentrer.AutoSize = True
        Me.lblentrer.Location = New System.Drawing.Point(91, 42)
        Me.lblentrer.Name = "lblentrer"
        Me.lblentrer.Size = New System.Drawing.Size(136, 20)
        Me.lblentrer.TabIndex = 1
        Me.lblentrer.Text = "Entrez un nombre"
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblresult.Location = New System.Drawing.Point(246, 225)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 20)
        Me.lblresult.TabIndex = 2
        '
        'btngenerate
        '
        Me.btngenerate.Location = New System.Drawing.Point(250, 128)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(89, 43)
        Me.btngenerate.TabIndex = 3
        Me.btngenerate.Text = "Valider"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 391)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.lblentrer)
        Me.Controls.Add(Me.txtentrer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtentrer As TextBox
    Friend WithEvents lblentrer As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents btngenerate As Button
End Class
