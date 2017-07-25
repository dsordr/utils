<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_kur_al = New System.Windows.Forms.Button()
        Me.grid_kur = New System.Windows.Forms.DataGridView()
        CType(Me.grid_kur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_kur_al
        '
        Me.btn_kur_al.Location = New System.Drawing.Point(355, 301)
        Me.btn_kur_al.Name = "btn_kur_al"
        Me.btn_kur_al.Size = New System.Drawing.Size(75, 23)
        Me.btn_kur_al.TabIndex = 0
        Me.btn_kur_al.Text = "Button1"
        Me.btn_kur_al.UseVisualStyleBackColor = True
        '
        'grid_kur
        '
        Me.grid_kur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_kur.Location = New System.Drawing.Point(27, 22)
        Me.grid_kur.Name = "grid_kur"
        Me.grid_kur.Size = New System.Drawing.Size(240, 150)
        Me.grid_kur.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 364)
        Me.Controls.Add(Me.grid_kur)
        Me.Controls.Add(Me.btn_kur_al)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grid_kur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_kur_al As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents grid_kur As DataGridView
End Class
