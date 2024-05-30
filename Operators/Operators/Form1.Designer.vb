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
        btnCheck = New Button()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        lblEvaluationText = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.18182F))
        TableLayoutPanel1.Controls.Add(txtNumber1, 0, 1)
        TableLayoutPanel1.Controls.Add(txtNumber2, 0, 2)
        TableLayoutPanel1.Controls.Add(lblEvaluationText, 0, 4)
        TableLayoutPanel1.Controls.Add(btnCheck, 0, 3)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 68.13725F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 31.8627453F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 56F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 69F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 105F))
        TableLayoutPanel1.Size = New Size(800, 438)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnCheck
        ' 
        btnCheck.Anchor = AnchorStyles.Top
        btnCheck.Location = New Point(338, 266)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(124, 49)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Anchor = AnchorStyles.Top
        txtNumber1.Font = New Font("Segoe UI", 12.0F)
        txtNumber1.Location = New Point(287, 144)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.PlaceholderText = "Enter first number"
        txtNumber1.Size = New Size(225, 29)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Anchor = AnchorStyles.Top
        txtNumber2.Font = New Font("Segoe UI", 12.0F)
        txtNumber2.Location = New Point(287, 210)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.PlaceholderText = "Enter second number"
        txtNumber2.Size = New Size(225, 29)
        txtNumber2.TabIndex = 1
        ' 
        ' lblEvaluationText
        ' 
        lblEvaluationText.Anchor = AnchorStyles.Top
        lblEvaluationText.AutoSize = True
        lblEvaluationText.Location = New Point(400, 332)
        lblEvaluationText.Name = "lblEvaluationText"
        lblEvaluationText.Size = New Size(0, 15)
        lblEvaluationText.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Logical and Relational Operators"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblEvaluationText As Label

End Class
