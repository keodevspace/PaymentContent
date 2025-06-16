Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private lblTitle As Label
    Private btnProcessPayment As Button
    Private btnViewPayments As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.btnProcessPayment = New Button()
        Me.btnViewPayments = New Button()

        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Arial", 16, FontStyle.Bold)
        Me.lblTitle.Location = New Point(100, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(200, 32)
        Me.lblTitle.Text = "Payment Content"

        ' 
        ' btnProcessPayment
        ' 
        Me.btnProcessPayment.Location = New Point(100, 80)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New Size(150, 40)
        Me.btnProcessPayment.Text = "Process Payment"
        AddHandler Me.btnProcessPayment.Click, AddressOf Me.BtnProcessPayment_Click

        ' 
        ' btnViewPayments
        ' 
        Me.btnViewPayments.Location = New Point(100, 140)
        Me.btnViewPayments.Name = "btnViewPayments"
        Me.btnViewPayments.Size = New Size(150, 40)
        Me.btnViewPayments.Text = "View Payments"
        AddHandler Me.btnViewPayments.Click, AddressOf Me.BtnViewPayments_Click

        ' 
        ' MainForm
        ' 
        Me.ClientSize = New Size(400, 250)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnProcessPayment)
        Me.Controls.Add(Me.btnViewPayments)
        Me.Name = "MainForm"
        Me.Text = "Payment Content Application"
    End Sub

    Private Sub BtnProcessPayment_Click(sender As Object, e As EventArgs)
        ' Logic to process payment
    End Sub

    Private Sub BtnViewPayments_Click(sender As Object, e As EventArgs)
        ' Logic to view payments
    End Sub
End Class