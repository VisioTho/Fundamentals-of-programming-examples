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
        frmGreetingText = New TextBox()
        lblHelloText = New Label()
        btnGreet = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(frmGreetingText, 0, 0)
        TableLayoutPanel1.Controls.Add(lblHelloText, 0, 2)
        TableLayoutPanel1.Controls.Add(btnGreet, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 71.52542F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 28.474577F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 154F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' frmGreetingText
        ' 
        frmGreetingText.Anchor = AnchorStyles.Bottom
        frmGreetingText.Font = New Font("Segoe UI", 14F)
        frmGreetingText.Location = New Point(280, 176)
        frmGreetingText.Name = "frmGreetingText"
        frmGreetingText.PlaceholderText = "Enter Your Greeting Here"
        frmGreetingText.Size = New Size(240, 32)
        frmGreetingText.TabIndex = 1
        ' 
        ' lblHelloText
        ' 
        lblHelloText.Anchor = AnchorStyles.Top
        lblHelloText.AutoSize = True
        lblHelloText.Font = New Font("Segoe UI", 15F)
        lblHelloText.Location = New Point(365, 295)
        lblHelloText.Name = "lblHelloText"
        lblHelloText.Size = New Size(69, 28)
        lblHelloText.TabIndex = 1
        lblHelloText.Text = "Label1"
        ' 
        ' btnGreet
        ' 
        btnGreet.Anchor = AnchorStyles.Top
        btnGreet.Font = New Font("Segoe UI", 14F)
        btnGreet.Location = New Point(327, 214)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(145, 53)
        btnGreet.TabIndex = 0
        btnGreet.Text = "Greet"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Hello World"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnGreet As Button
    Friend WithEvents lblHelloText As Label
    Friend WithEvents frmGreetingText As TextBox

End Class
