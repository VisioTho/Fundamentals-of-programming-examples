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
        TableLayoutPanel1 = New TableLayoutPanel()
        lblRadius = New Label()
        Label1 = New Label()
        txtRadiusInput = New TextBox()
        lblArea = New Label()
        btnCalculate = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.125F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.875F))
        TableLayoutPanel1.Controls.Add(lblRadius, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 2)
        TableLayoutPanel1.Controls.Add(txtRadiusInput, 1, 1)
        TableLayoutPanel1.Controls.Add(lblArea, 1, 2)
        TableLayoutPanel1.Controls.Add(btnCalculate, 1, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 56.6878967F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 43.3121033F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 64F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 236F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblRadius
        ' 
        lblRadius.Anchor = AnchorStyles.Right
        lblRadius.AutoSize = True
        lblRadius.Font = New Font("Segoe UI", 12F)
        lblRadius.Location = New Point(229, 106)
        lblRadius.Name = "lblRadius"
        lblRadius.Size = New Size(57, 21)
        lblRadius.TabIndex = 0
        lblRadius.Text = "Radius"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(244, 170)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 21)
        Label1.TabIndex = 1
        Label1.Text = "Area"
        ' 
        ' txtRadiusInput
        ' 
        txtRadiusInput.Anchor = AnchorStyles.Left
        txtRadiusInput.Font = New Font("Segoe UI", 14F)
        txtRadiusInput.Location = New Point(292, 101)
        txtRadiusInput.Name = "txtRadiusInput"
        txtRadiusInput.PlaceholderText = "enter radius e.g. 7"
        txtRadiusInput.Size = New Size(238, 32)
        txtRadiusInput.TabIndex = 2
        ' 
        ' lblArea
        ' 
        lblArea.Anchor = AnchorStyles.Left
        lblArea.AutoSize = True
        lblArea.Font = New Font("Segoe UI", 14F)
        lblArea.ForeColor = SystemColors.ControlDarkDark
        lblArea.Location = New Point(292, 168)
        lblArea.Name = "lblArea"
        lblArea.Size = New Size(67, 25)
        lblArea.TabIndex = 3
        lblArea.Text = "Label2"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 12F)
        btnCalculate.Location = New Point(292, 216)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(238, 35)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Circle Area"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblRadius As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRadiusInput As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents btnCalculate As Button

End Class
