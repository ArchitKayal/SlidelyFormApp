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
        ButtonViewSubmissions = New Button()
        ButtonNewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' ButtonViewSubmissions
        ' 
        ButtonViewSubmissions.Location = New Point(254, 184)
        ButtonViewSubmissions.Name = "ButtonViewSubmissions"
        ButtonViewSubmissions.Size = New Size(303, 34)
        ButtonViewSubmissions.TabIndex = 0
        ButtonViewSubmissions.Text = "View Submissions (Ctrl + V)"
        ButtonViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' ButtonNewSubmissions
        ' 
        ButtonNewSubmissions.Location = New Point(254, 242)
        ButtonNewSubmissions.Name = "ButtonNewSubmissions"
        ButtonNewSubmissions.Size = New Size(303, 34)
        ButtonNewSubmissions.TabIndex = 1
        ButtonNewSubmissions.Text = "Create New Submission (Ctrl + N)"
        ButtonNewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonNewSubmissions)
        Controls.Add(ButtonViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonViewSubmissions As Button
    Friend WithEvents ButtonNewSubmissions As Button

End Class
