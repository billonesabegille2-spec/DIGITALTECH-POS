<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileUpdate
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
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelSeaShell)
        Me.Controls.Add(Me.PanelRed)
        Me.Name = "ProfileUpdate"
        Me.Text = "ProfileUpdate"
        CType(Me.PictureUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSeaShell.ResumeLayout(False)
        Me.PanelSeaShell.PerformLayout()
        Me.PanelRed.ResumeLayout(False)
        Me.PanelRed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureUser As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents lblMName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents labelItsQuick As Label
    Friend WithEvents LabelLetsGet As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSeaShell As Panel
    Friend WithEvents PanelRed As Panel
    Friend WithEvents btnChangePass As Button
End Class
