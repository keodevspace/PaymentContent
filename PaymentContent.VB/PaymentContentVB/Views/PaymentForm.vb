Imports System.Windows.Forms

Public Class PaymentForm
    Inherits Form

    Private lblAmount As Label
    Private txtAmount As TextBox
    Private btnSubmit As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblAmount = New Label()
        Me.txtAmount = New TextBox()
        Me.btnSubmit = New Button()

        ' 
        ' lblAmount
        ' 
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(30, 30)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 17)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount:"

        ' 
        ' txtAmount
        ' 
        Me.txtAmount.Location = New System.Drawing.Point(100, 30)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 22)
        Me.txtAmount.TabIndex = 1

        ' 
        ' btnSubmit
        ' 
        Me.btnSubmit.Location = New System.Drawing.Point(100, 70)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 30)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        AddHandler Me.btnSubmit.Click, AddressOf Me.BtnSubmit_Click

        ' 
        ' PaymentForm
        ' 
        Me.ClientSize = New System.Drawing.Size(350, 120)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "PaymentForm"
        Me.Text = "Payment Form"
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        Dim amount As Decimal
        If Decimal.TryParse(txtAmount.Text, amount) Then
            ' Logic to process the payment
            MessageBox.Show("Payment of " & amount.ToString("C") & " processed successfully.")
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub
End Class