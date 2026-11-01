Public Class Form1
    ' Constants used in the code.
    Private strModuleNames() As String = {"MS Office", "Web Design", "Graphic Design", "VB Programming", "Networking"}
    Private decModulePrices() As Decimal = {120D, 200D, 180D, 250D, 150D}
    Private Const decREGISTRATION_FEE As Decimal = 50D
    Private Const decSERVICE_RATE As Decimal = 0.025D
    Private intStudentCount As Integer = 0

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ofdPhoto.ShowDialog() = DialogResult.OK Then
            picPassport.Image = Image.FromFile(ofdPhoto.FileName)
        End If
    End Sub

    Private Sub lnkTermsConditions_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTermsConditions.LinkClicked
        MessageBox.Show("1. Fees must be paid as agreed." & vbCrLf &
                       "2. The registration fee is not refundable." & vbCrLf &
                       "3. All details given must be correct.", "Terms and Conditions")
    End Sub

    Private Function GetAge(dtmBirth As Date) As Integer
        Dim intAge As Integer = Date.Today.Year - dtmBirth.Year
        If dtmBirth.Date > Date.Today.AddYears(-intAge) Then
            intAge -= 1
        End If
        Return intAge
    End Function

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        lblAge.Text = GetAge(dtpDOB.Value).ToString() & " years"
    End Sub

    Private Sub clbModules_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbModules.ItemCheck
        Dim intIndex As Integer
        Dim blnTicked As Boolean

        lstSelected.Items.Clear()
        For intIndex = 0 To clbModules.Items.Count - 1
            If intIndex = e.Index Then
                blnTicked = (e.NewValue = CheckState.Checked)       ' the item being clicked now
            Else
                blnTicked = clbModules.GetItemChecked(intIndex)     ' all the other items
            End If

            If blnTicked Then
                lstSelected.Items.Add(strModuleNames(intIndex) & "  -  " & decModulePrices(intIndex).ToString("n2"))
            End If
        Next

        UpdateProgress()
    End Sub

    Private Sub radFull_CheckedChanged(sender As Object, e As EventArgs) Handles radFull.CheckedChanged
        nudInstallments.Enabled = radInstallment.Checked
    End Sub

    Private Sub radInstallment_CheckedChanged(sender As Object, e As EventArgs) Handles radInstallment.CheckedChanged
        nudInstallments.Enabled = radInstallment.Checked
    End Sub

    Private Sub UpdateProgress()
        Const intTOTAL_ITEMS As Integer = 11
        Dim intFilled As Integer = 0

        If txtSurname.Text.Trim() <> String.Empty Then intFilled += 1
        If txtOtherNames.Text.Trim() <> String.Empty Then intFilled += 1
        If radMale.Checked Or radFemale.Checked Then intFilled += 1
        If mskPhone.MaskCompleted Then intFilled += 1
        If txtEmail.Text.Trim() <> String.Empty Then intFilled += 1
        If mskGhanaCard.MaskCompleted Then intFilled += 1
        If cboRegion.SelectedIndex >= 0 Then intFilled += 1
        If cboProgramme.SelectedIndex >= 0 Then intFilled += 1
        If lstSelected.Items.Count > 0 Then intFilled += 1
        If txtPaid.Text.Trim() <> String.Empty Then intFilled += 1
        If cboTermsConditions.Checked Then intFilled += 1

        pgbProgress.Value = intFilled * 100 \ intTOTAL_ITEMS
        lblProgress.Text = pgbProgress.Value.ToString() & "%"
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        UpdateProgress()
    End Sub

    Private Sub txtOtherNames_TextChanged(sender As Object, e As EventArgs) Handles txtOtherNames.TextChanged
        UpdateProgress()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        UpdateProgress()
    End Sub

    Private Sub txtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtPaid.TextChanged
        UpdateProgress()
    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        UpdateProgress()
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        UpdateProgress()
    End Sub

    Private Sub mskPhone_TextChanged(sender As Object, e As EventArgs) Handles mskPhone.TextChanged
        UpdateProgress()
    End Sub

    Private Sub mskGhanaCard_TextChanged(sender As Object, e As EventArgs) Handles mskGhanaCard.TextChanged
        UpdateProgress()
    End Sub

    Private Sub cboRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegion.SelectedIndexChanged
        UpdateProgress()
    End Sub

    Private Sub cboProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProgramme.SelectedIndexChanged
        UpdateProgress()
    End Sub

    Private Sub cboTermsConditions_CheckedChanged(sender As Object, e As EventArgs) Handles cboTermsConditions.CheckedChanged
        UpdateProgress()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim intIndex As Integer

        txtSurname.Clear()
        txtOtherNames.Clear()
        dtpDOB.Value = Date.Today
        lblAge.Text = String.Empty
        radMale.Checked = False
        radFemale.Checked = False
        mskPhone.Clear()
        txtEmail.Clear()
        mskGhanaCard.Clear()
        cboRegion.SelectedIndex = -1
        cboProgramme.SelectedIndex = -1
        picPassport.Image = Nothing

        For intIndex = 0 To clbModules.Items.Count - 1
            clbModules.SetItemChecked(intIndex, False)
        Next
        lstSelected.Items.Clear()
        nudMonths.Value = 1
        mcStartDate.SetDate(Date.Today)

        radFull.Checked = True
        nudInstallments.Value = 2
        txtPaid.Clear()

        lblTuition.Text = "GHC 0.00"
        lblDiscount.Text = "GHC 0.00"
        lblServiceCharge.Text = "GHC 0.00"
        lblTotal.Text = "GHC 0.00"
        lblBalance.Text = "GHC 0.00"
        cboTermsConditions.Checked = False
        cboSMS.Checked = False
        rtbReceipt.Clear()
        lstFeeBreakdown.Items.Clear()
        tslStatus.Text = "Ready"
        txtSurname.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function RoundMoney(decAmount As Decimal) As Decimal
        Return Math.Round(decAmount, 2, MidpointRounding.AwayFromZero)
    End Function

    Private Function GetAmountPaid() As Decimal
        Dim decPaid As Decimal = 0
        Decimal.TryParse(txtPaid.Text, decPaid)
        Return decPaid
    End Function

    Private Function GetMonthlyPrice() As Decimal
        Dim decMonthly As Decimal = 0
        Dim intIndex As Integer

        For intIndex = 0 To clbModules.Items.Count - 1
            If clbModules.GetItemChecked(intIndex) Then
                decMonthly += decModulePrices(intIndex)
            End If
        Next
        Return decMonthly
    End Function

    Private Function GetTuition() As Decimal
        Return GetMonthlyPrice() * nudMonths.Value
    End Function

    Private Function GetDiscountRate() As Decimal
        Dim decRate As Decimal = 0
        If nudMonths.Value >= 6 Then decRate = 0.1D
        If radFull.Checked Then decRate += 0.05D
        Return decRate
    End Function

    Private Function GetDiscount() As Decimal
        Return RoundMoney(GetTuition() * GetDiscountRate())
    End Function

    Private Function GetServiceCharge() As Decimal
        Return RoundMoney((GetTuition() - GetDiscount()) * decSERVICE_RATE)
    End Function

    Private Function GetTotalFee() As Decimal
        Return RoundMoney((GetTuition() - GetDiscount()) + decREGISTRATION_FEE + GetServiceCharge())
    End Function

    Private Function GetBalance() As Decimal
        Return RoundMoney(GetTotalFee() - GetAmountPaid())
    End Function

    Private Function GetInstalment() As Decimal
        Return RoundMoney(GetBalance() / nudInstallments.Value)
    End Function

    Private Sub AddFee(strItem As String, decAmount As Decimal)
        lstFeeBreakdown.Items.Add(New ListViewItem(New String() {strItem, decAmount.ToString("n2")}))
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If lstSelected.Items.Count = 0 Then
            MessageBox.Show("Please tick at least one module first.", "Calculate")
        Else
            lblTuition.Text = "GHC " & GetTuition().ToString("n2")
            lblDiscount.Text = "GHC " & GetDiscount().ToString("n2")
            lblServiceCharge.Text = "GHC " & GetServiceCharge().ToString("n2")
            lblTotal.Text = "GHC " & GetTotalFee().ToString("n2")
            lblBalance.Text = "GHC " & GetBalance().ToString("n2")
            lstFeeBreakdown.Items.Clear()
            AddFee("Tuition (" & GetMonthlyPrice().ToString("n2") & " x " & nudMonths.Value.ToString() & " months)", GetTuition())
            AddFee("Discount (" & GetDiscountRate().ToString("p0") & ")", -GetDiscount())
            AddFee("Registration fee", decREGISTRATION_FEE)
            AddFee("Service charge (2.5%)", GetServiceCharge())
            AddFee("Total fee", GetTotalFee())
            AddFee("Amount paid", GetAmountPaid())
            AddFee("Balance", GetBalance())
            If radInstallment.Checked Then
                AddFee("Each instalment", GetInstalment())
            End If
        End If
    End Sub

    Private Function HasDigit(strText As String) As Boolean
        Dim chrLetter As Char
        For Each chrLetter In strText
            If Char.IsDigit(chrLetter) Then Return True
        Next
        Return False
    End Function

    Private Function GetErrors() As String
        Dim strErrors As String = String.Empty
        Dim decPaid As Decimal

        ' i. Names must not be empty or contain digits
        If txtSurname.Text.Trim() = String.Empty OrElse HasDigit(txtSurname.Text) Then
            strErrors &= "- Surname is empty or contains digits." & vbCrLf
        End If
        If txtOtherNames.Text.Trim() = String.Empty OrElse HasDigit(txtOtherNames.Text) Then
            strErrors &= "- Other names are empty or contain digits." & vbCrLf
        End If

        ' ii. Student must be at least 15
        If GetAge(dtpDOB.Value) < 15 Then
            strErrors &= "- The student must be at least 15 years old." & vbCrLf
        End If

        ' iii. Phone and Ghana Card must be complete (MaskCompleted = every digit typed)
        If Not mskPhone.MaskCompleted Then
            strErrors &= "- Phone number is not complete." & vbCrLf
        End If
        If Not mskGhanaCard.MaskCompleted Then
            strErrors &= "- Ghana Card number is not complete." & vbCrLf
        End If

        ' iv. Email must contain @
        If Not txtEmail.Text.Contains("@") Then
            strErrors &= "- Email must contain @." & vbCrLf
        End If

        ' v. Gender, region, programme and at least one module must be chosen
        If Not (radMale.Checked Or radFemale.Checked) Then
            strErrors &= "- Choose a gender." & vbCrLf
        End If
        If cboRegion.SelectedIndex = -1 Then
            strErrors &= "- Choose a region." & vbCrLf
        End If
        If cboProgramme.SelectedIndex = -1 Then
            strErrors &= "- Choose a programme." & vbCrLf
        End If
        If lstSelected.Items.Count = 0 Then
            strErrors &= "- Tick at least one module." & vbCrLf
        End If
        ' vi. Amount paid must be a number and must not be more than the total fee
        If Not Decimal.TryParse(txtPaid.Text, decPaid) OrElse decPaid < 0 Then
            strErrors &= "- Amount paid must be a number." & vbCrLf
        ElseIf lstSelected.Items.Count > 0 AndAlso decPaid > GetTotalFee() Then
            strErrors &= "- Amount paid is more than the total fee (GHC " &
GetTotalFee().ToString("n2") & ")." & vbCrLf
        End If

        ' vii. Terms box must be ticked
        If Not cboTermsConditions.Checked Then
            strErrors &= "- Accept the Terms and Conditions." & vbCrLf
        End If

        Return strErrors
    End Function

    ' Add one line to the receipt, with optional bold and colour
    Private Sub AddReceiptLine(strText As String, Optional blnBold As Boolean = False, Optional clrColour As Color = Nothing)
        rtbReceipt.SelectionStart = rtbReceipt.TextLength        ' go to the end of the text
        rtbReceipt.SelectionLength = 0
        rtbReceipt.SelectionColor = If(clrColour.IsEmpty, Color.Black, clrColour)
        rtbReceipt.SelectionFont = New Font(rtbReceipt.Font, If(blnBold, FontStyle.Bold,
FontStyle.Regular))
        rtbReceipt.AppendText(strText & vbCrLf)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim strErrors As String
        Dim strStudentID As String
        Dim strFullName As String
        Dim strModules As String = String.Empty
        Dim intIndex As Integer

        ' 1. Validate: if there are problems, show them and stop
        strErrors = GetErrors()
        If strErrors <> String.Empty Then
            MessageBox.Show("Please correct the following:" & vbCrLf & vbCrLf & strErrors,
                            "Registration not accepted", MessageBoxButtons.OK,
MessageBoxIcon.Warning)
        Else
            ' 2. Form is correct: create the Student ID, the full name and the list of modules
            intStudentCount += 1
            strStudentID = "VDSA-" & Date.Today.Year.ToString() & "-" &
intStudentCount.ToString("D3")
            strFullName = txtSurname.Text.Trim() & " " & txtOtherNames.Text.Trim()

            For intIndex = 0 To clbModules.Items.Count - 1
                If clbModules.GetItemChecked(intIndex) Then
                    If strModules <> String.Empty Then strModules &= ", "
                    strModules &= strModuleNames(intIndex)
                End If
            Next

            ' 3. Print the receipt: headings bold, total fee blue, balance red
            rtbReceipt.Clear()
            AddReceiptLine("VOLTA DIGITAL SKILLS ACADEMY", True)
            AddReceiptLine("OFFICIAL REGISTRATION RECEIPT", True)
            AddReceiptLine("Student ID : " & strStudentID, True)
            AddReceiptLine("Name : " & strFullName, True)
            AddReceiptLine("Modules : " & strModules, True)
            AddReceiptLine("TOTAL FEE : GHC " & GetTotalFee().ToString("n2"), True, Color.Blue)
            AddReceiptLine("AMOUNT PAID : GHC " & GetAmountPaid().ToString("n2"), True)
            AddReceiptLine("BALANCE : GHC " & GetBalance().ToString("n2"), True, Color.Red)
            If radInstallment.Checked Then
                AddReceiptLine(nudInstallments.Value.ToString() & " instalments of GHC " & GetInstalment().ToString("n2"))
            End If

            ' 4. Message in the status bar (the "taskbar" at the bottom of the form)
            tslStatus.Text = "Registration successful: " & strFullName & " (" & strStudentID &
")"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
