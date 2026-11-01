<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        mskGhanaCard = New MaskedTextBox()
        mskPhone = New MaskedTextBox()
        btnBrowse = New Button()
        picPassport = New PictureBox()
        radFemale = New RadioButton()
        radMale = New RadioButton()
        lblAge = New Label()
        cboRegion = New ComboBox()
        dtpDOB = New DateTimePicker()
        txtOtherNames = New TextBox()
        txtEmail = New TextBox()
        txtSurname = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ofdPhoto = New OpenFileDialog()
        GroupBox2 = New GroupBox()
        Label13 = New Label()
        mcStartDate = New MonthCalendar()
        lstSelected = New ListBox()
        nudMonths = New NumericUpDown()
        clbModules = New CheckedListBox()
        Label11 = New Label()
        cboProgramme = New ComboBox()
        Label12 = New Label()
        Label20 = New Label()
        lblTuition = New Label()
        GroupBox3 = New GroupBox()
        txtPaid = New TextBox()
        nudInstallments = New NumericUpDown()
        Label24 = New Label()
        Label23 = New Label()
        radInstallment = New RadioButton()
        radFull = New RadioButton()
        lblBalance = New Label()
        Label19 = New Label()
        lblTotal = New Label()
        Label17 = New Label()
        lblServiceCharge = New Label()
        Label16 = New Label()
        lblDiscount = New Label()
        Label18 = New Label()
        Label14 = New Label()
        Label10 = New Label()
        btnExit = New Button()
        btnClear = New Button()
        btnRegister = New Button()
        btnCalculate = New Button()
        cboTermsConditions = New CheckBox()
        lnkTermsConditions = New LinkLabel()
        cboSMS = New CheckBox()
        rtbReceipt = New RichTextBox()
        lstFeeBreakdown = New ListView()
        chItem = New ColumnHeader()
        chAmount = New ColumnHeader()
        Label15 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        pgbProgress = New ProgressBar()
        lblProgress = New Label()
        ToolTip1 = New ToolTip(components)
        ssMain = New StatusStrip()
        tslStatus = New ToolStripStatusLabel()
        GroupBox1.SuspendLayout()
        CType(picPassport, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(nudMonths, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(nudInstallments, ComponentModel.ISupportInitialize).BeginInit()
        ssMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(mskGhanaCard)
        GroupBox1.Controls.Add(mskPhone)
        GroupBox1.Controls.Add(btnBrowse)
        GroupBox1.Controls.Add(picPassport)
        GroupBox1.Controls.Add(radFemale)
        GroupBox1.Controls.Add(radMale)
        GroupBox1.Controls.Add(lblAge)
        GroupBox1.Controls.Add(cboRegion)
        GroupBox1.Controls.Add(dtpDOB)
        GroupBox1.Controls.Add(txtOtherNames)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtSurname)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(6, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(379, 470)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Details"
        ' 
        ' mskGhanaCard
        ' 
        mskGhanaCard.Location = New Point(112, 254)
        mskGhanaCard.Mask = "\G\H\A-000000000-0"
        mskGhanaCard.Name = "mskGhanaCard"
        mskGhanaCard.Size = New Size(261, 23)
        mskGhanaCard.TabIndex = 22
        ToolTip1.SetToolTip(mskGhanaCard, "Ghana Card number, e.g. GHA-123456789-0")
        ' 
        ' mskPhone
        ' 
        mskPhone.Location = New Point(112, 187)
        mskPhone.Mask = "000-000-0000"
        mskPhone.Name = "mskPhone"
        mskPhone.Size = New Size(261, 23)
        mskPhone.TabIndex = 21
        ToolTip1.SetToolTip(mskPhone, " Phone number, 10 digits")
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(222, 370)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(104, 23)
        btnBrowse.TabIndex = 20
        btnBrowse.Text = "Browse Photo"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picPassport
        ' 
        picPassport.BorderStyle = BorderStyle.FixedSingle
        picPassport.Location = New Point(79, 315)
        picPassport.Name = "picPassport"
        picPassport.Size = New Size(133, 137)
        picPassport.SizeMode = PictureBoxSizeMode.Zoom
        picPassport.TabIndex = 19
        picPassport.TabStop = False
        ' 
        ' radFemale
        ' 
        radFemale.Location = New Point(222, 153)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(104, 24)
        radFemale.TabIndex = 18
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.Location = New Point(112, 153)
        radMale.Name = "radMale"
        radMale.Size = New Size(104, 24)
        radMale.TabIndex = 17
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' lblAge
        ' 
        lblAge.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAge.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblAge.Location = New Point(112, 122)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(100, 23)
        lblAge.TabIndex = 16
        lblAge.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRegion
        ' 
        cboRegion.DropDownStyle = ComboBoxStyle.DropDownList
        cboRegion.FormattingEnabled = True
        cboRegion.Items.AddRange(New Object() {"Ahafo ", "Ashanti ", "Bono ", "Bono East ", "Central ", "Eastern ", "Greater Accra ", "North East ", "Northern ", "Oti ", "Savannah ", "Upper East ", "Upper West ", "Volta ", "Western", "Western North"})
        cboRegion.Location = New Point(112, 286)
        cboRegion.Name = "cboRegion"
        cboRegion.Size = New Size(261, 23)
        cboRegion.TabIndex = 15
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Location = New Point(112, 90)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(261, 23)
        dtpDOB.TabIndex = 14
        ToolTip1.SetToolTip(dtpDOB, " Choose the date of birth. The student must be 15 or older")
        ' 
        ' txtOtherNames
        ' 
        txtOtherNames.Location = New Point(112, 54)
        txtOtherNames.Name = "txtOtherNames"
        txtOtherNames.Size = New Size(261, 23)
        txtOtherNames.TabIndex = 13
        ToolTip1.SetToolTip(txtOtherNames, "Type the student's other names (letters only)")
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(112, 221)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(261, 23)
        txtEmail.TabIndex = 11
        ToolTip1.SetToolTip(txtEmail, "Email address (must contain @)")
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(112, 19)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(261, 23)
        txtSurname.TabIndex = 9
        ToolTip1.SetToolTip(txtSurname, " Type the student's surname (letters only)")
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(6, 286)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 8
        Label9.Text = "Region:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(6, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 7
        Label8.Text = "Ghana Card:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(6, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 6
        Label7.Text = "Email:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(6, 187)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 5
        Label6.Text = "Phone:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(6, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Gender:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(6, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Age:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(6, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "Date of Birth:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(6, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Other Names:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "Surname:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ofdPhoto
        ' 
        ofdPhoto.FileName = "OpenFileDialog1"
        ofdPhoto.Filter = " Images|*.jpg;*.jpeg;*.png"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(mcStartDate)
        GroupBox2.Controls.Add(lstSelected)
        GroupBox2.Controls.Add(nudMonths)
        GroupBox2.Controls.Add(clbModules)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(cboProgramme)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Location = New Point(400, 42)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(379, 470)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Course Details"
        ' 
        ' Label13
        ' 
        Label13.Location = New Point(6, 312)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 23)
        Label13.TabIndex = 28
        Label13.Text = "Start Date:"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mcStartDate
        ' 
        mcStartDate.BackColor = SystemColors.HotTrack
        mcStartDate.FirstDayOfWeek = Day.Sunday
        mcStartDate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mcStartDate.ForeColor = SystemColors.MenuBar
        mcStartDate.Location = New Point(127, 306)
        mcStartDate.MaxSelectionCount = 1
        mcStartDate.Name = "mcStartDate"
        mcStartDate.ShowToday = False
        mcStartDate.TabIndex = 27
        mcStartDate.TitleBackColor = SystemColors.HotTrack
        mcStartDate.TrailingForeColor = SystemColors.Control
        ' 
        ' lstSelected
        ' 
        lstSelected.FormattingEnabled = True
        lstSelected.Location = New Point(6, 177)
        lstSelected.Name = "lstSelected"
        lstSelected.Size = New Size(367, 94)
        lstSelected.TabIndex = 26
        ' 
        ' nudMonths
        ' 
        nudMonths.Location = New Point(127, 277)
        nudMonths.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudMonths.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudMonths.Name = "nudMonths"
        nudMonths.Size = New Size(120, 23)
        nudMonths.TabIndex = 25
        ToolTip1.SetToolTip(nudMonths, "Number of months (6 or more gets a 10% discount)")
        nudMonths.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' clbModules
        ' 
        clbModules.CheckOnClick = True
        clbModules.FormattingEnabled = True
        clbModules.Items.AddRange(New Object() {"MS Office - GHC 120.00", "Web Design: -GHC 200.00", "Graphic Design - GHC 180.00", "VB Programming - GHC 250.00", "Networking - GHC 150.00"})
        clbModules.Location = New Point(6, 62)
        clbModules.Name = "clbModules"
        clbModules.Size = New Size(367, 94)
        clbModules.TabIndex = 23
        ToolTip1.SetToolTip(clbModules, " Tick every module the student wants")
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(6, 42)
        Label11.Name = "Label11"
        Label11.Size = New Size(184, 23)
        Label11.TabIndex = 22
        Label11.Text = "Modules (tick the ones required)"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboProgramme
        ' 
        cboProgramme.DropDownStyle = ComboBoxStyle.DropDownList
        cboProgramme.FormattingEnabled = True
        cboProgramme.Items.AddRange(New Object() {"Software Development ", "Data Analytics ", "Web Development ", "Networking"})
        cboProgramme.Location = New Point(112, 19)
        cboProgramme.Name = "cboProgramme"
        cboProgramme.Size = New Size(261, 23)
        cboProgramme.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(6, 274)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 23)
        Label12.TabIndex = 8
        Label12.Text = "Number of months:"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label20
        ' 
        Label20.Location = New Point(6, 19)
        Label20.Name = "Label20"
        Label20.Size = New Size(100, 23)
        Label20.TabIndex = 0
        Label20.Text = "Programme:"
        Label20.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTuition
        ' 
        lblTuition.AutoSize = True
        lblTuition.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTuition.Location = New Point(6, 71)
        lblTuition.Name = "lblTuition"
        lblTuition.Size = New Size(71, 16)
        lblTuition.TabIndex = 2
        lblTuition.Text = "GHC 0.00"
        lblTuition.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtPaid)
        GroupBox3.Controls.Add(nudInstallments)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(radInstallment)
        GroupBox3.Controls.Add(radFull)
        GroupBox3.Controls.Add(lblBalance)
        GroupBox3.Controls.Add(Label19)
        GroupBox3.Controls.Add(lblTotal)
        GroupBox3.Controls.Add(Label17)
        GroupBox3.Controls.Add(lblServiceCharge)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(lblDiscount)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(lblTuition)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Location = New Point(6, 518)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(772, 117)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Payment"
        ' 
        ' txtPaid
        ' 
        txtPaid.Location = New Point(636, 17)
        txtPaid.Name = "txtPaid"
        txtPaid.Size = New Size(100, 23)
        txtPaid.TabIndex = 16
        ToolTip1.SetToolTip(txtPaid, "Amount paid now, in GHC")
        ' 
        ' nudInstallments
        ' 
        nudInstallments.Enabled = False
        nudInstallments.Location = New Point(480, 17)
        nudInstallments.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudInstallments.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudInstallments.Name = "nudInstallments"
        nudInstallments.Size = New Size(63, 23)
        nudInstallments.TabIndex = 15
        ToolTip1.SetToolTip(nudInstallments, "Only available for Instalment payment")
        nudInstallments.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(550, 21)
        Label24.Name = "Label24"
        Label24.Size = New Size(80, 15)
        Label24.TabIndex = 14
        Label24.Text = "Amount Paid:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(345, 21)
        Label23.Name = "Label23"
        Label23.Size = New Size(132, 15)
        Label23.TabIndex = 13
        Label23.Text = "Number of instalments:"
        ' 
        ' radInstallment
        ' 
        radInstallment.AutoSize = True
        radInstallment.Checked = True
        radInstallment.Location = New Point(220, 17)
        radInstallment.Name = "radInstallment"
        radInstallment.Size = New Size(84, 19)
        radInstallment.TabIndex = 12
        radInstallment.TabStop = True
        radInstallment.Text = "Installment"
        radInstallment.UseVisualStyleBackColor = True
        ' 
        ' radFull
        ' 
        radFull.AutoSize = True
        radFull.Location = New Point(110, 17)
        radFull.Name = "radFull"
        radFull.Size = New Size(94, 19)
        radFull.TabIndex = 11
        radFull.Text = "Full Payment"
        radFull.UseVisualStyleBackColor = True
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBalance.ForeColor = Color.Red
        lblBalance.Location = New Point(663, 71)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(71, 16)
        lblBalance.TabIndex = 10
        lblBalance.Text = "GHC 0.00"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(663, 56)
        Label19.Name = "Label19"
        Label19.Size = New Size(51, 15)
        Label19.TabIndex = 9
        Label19.Text = "Balance:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = SystemColors.Highlight
        lblTotal.Location = New Point(521, 71)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(71, 16)
        lblTotal.TabIndex = 8
        lblTotal.Text = "GHC 0.00"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(521, 56)
        Label17.Name = "Label17"
        Label17.Size = New Size(35, 15)
        Label17.TabIndex = 7
        Label17.Text = "Total:"
        ' 
        ' lblServiceCharge
        ' 
        lblServiceCharge.AutoSize = True
        lblServiceCharge.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServiceCharge.Location = New Point(345, 71)
        lblServiceCharge.Name = "lblServiceCharge"
        lblServiceCharge.Size = New Size(71, 16)
        lblServiceCharge.TabIndex = 6
        lblServiceCharge.Text = "GHC 0.00"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(345, 56)
        Label16.Name = "Label16"
        Label16.Size = New Size(88, 15)
        Label16.TabIndex = 5
        Label16.Text = "Service Charge:"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiscount.Location = New Point(172, 71)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(71, 16)
        lblDiscount.TabIndex = 4
        lblDiscount.Text = "GHC 0.00"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(172, 56)
        Label18.Name = "Label18"
        Label18.Size = New Size(57, 15)
        Label18.TabIndex = 3
        Label18.Text = "Discount:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(6, 56)
        Label14.Name = "Label14"
        Label14.Size = New Size(47, 15)
        Label14.TabIndex = 1
        Label14.Text = "Tuition:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 15)
        Label10.TabIndex = 0
        Label10.Text = "Payment Mode:"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(338, 666)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(104, 23)
        btnExit.TabIndex = 21
        btnExit.Tag = ""
        btnExit.Text = "E&xit"
        ToolTip1.SetToolTip(btnExit, "Close the program")
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(228, 666)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(104, 23)
        btnClear.TabIndex = 22
        btnClear.Text = "C&lear"
        ToolTip1.SetToolTip(btnClear, " Empty the whole form")
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(118, 666)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(104, 23)
        btnRegister.TabIndex = 23
        btnRegister.Text = "&Register"
        ToolTip1.SetToolTip(btnRegister, "Check the form and register the student")
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(8, 666)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(104, 23)
        btnCalculate.TabIndex = 24
        btnCalculate.Text = "&Calculate"
        ToolTip1.SetToolTip(btnCalculate, " Work out the fees")
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' cboTermsConditions
        ' 
        cboTermsConditions.AutoSize = True
        cboTermsConditions.Location = New Point(12, 640)
        cboTermsConditions.Name = "cboTermsConditions"
        cboTermsConditions.Size = New Size(87, 19)
        cboTermsConditions.TabIndex = 25
        cboTermsConditions.Text = "I accept the"
        cboTermsConditions.UseVisualStyleBackColor = True
        ' 
        ' lnkTermsConditions
        ' 
        lnkTermsConditions.AutoSize = True
        lnkTermsConditions.BackColor = Color.Transparent
        lnkTermsConditions.Location = New Point(96, 641)
        lnkTermsConditions.Name = "lnkTermsConditions"
        lnkTermsConditions.Size = New Size(122, 15)
        lnkTermsConditions.TabIndex = 26
        lnkTermsConditions.TabStop = True
        lnkTermsConditions.Text = "Terms and Conditions"
        ' 
        ' cboSMS
        ' 
        cboSMS.AutoSize = True
        cboSMS.Location = New Point(240, 641)
        cboSMS.Name = "cboSMS"
        cboSMS.Size = New Size(129, 19)
        cboSMS.TabIndex = 27
        cboSMS.Text = "Send me SMS alerts"
        cboSMS.UseVisualStyleBackColor = True
        ' 
        ' rtbReceipt
        ' 
        rtbReceipt.Location = New Point(785, 59)
        rtbReceipt.Name = "rtbReceipt"
        rtbReceipt.ReadOnly = True
        rtbReceipt.Size = New Size(315, 292)
        rtbReceipt.TabIndex = 28
        rtbReceipt.Text = ""
        ' 
        ' lstFeeBreakdown
        ' 
        lstFeeBreakdown.Columns.AddRange(New ColumnHeader() {chItem, chAmount})
        lstFeeBreakdown.FullRowSelect = True
        lstFeeBreakdown.GridLines = True
        lstFeeBreakdown.Location = New Point(785, 383)
        lstFeeBreakdown.Name = "lstFeeBreakdown"
        lstFeeBreakdown.Size = New Size(315, 306)
        lstFeeBreakdown.TabIndex = 29
        lstFeeBreakdown.UseCompatibleStateImageBehavior = False
        lstFeeBreakdown.View = View.Details
        ' 
        ' chItem
        ' 
        chItem.Text = "Item"
        chItem.Width = 210
        ' 
        ' chAmount
        ' 
        chAmount.Text = "Amount (GHC)"
        chAmount.Width = 100
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(785, 41)
        Label15.Name = "Label15"
        Label15.Size = New Size(49, 15)
        Label15.TabIndex = 30
        Label15.Text = "Receipt:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(785, 362)
        Label21.Name = "Label21"
        Label21.Size = New Size(90, 15)
        Label21.TabIndex = 31
        Label21.Text = "Fee breakdown:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.DarkBlue
        Label22.Location = New Point(12, 9)
        Label22.Name = "Label22"
        Label22.Size = New Size(390, 21)
        Label22.TabIndex = 32
        Label22.Text = "Volta Digital Skills Academy: Student Registration"
        ' 
        ' pgbProgress
        ' 
        pgbProgress.Location = New Point(931, 12)
        pgbProgress.Name = "pgbProgress"
        pgbProgress.Size = New Size(100, 23)
        pgbProgress.TabIndex = 35
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.Location = New Point(870, 13)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(0, 17)
        lblProgress.TabIndex = 36
        ' 
        ' ssMain
        ' 
        ssMain.Items.AddRange(New ToolStripItem() {tslStatus})
        ssMain.Location = New Point(0, 698)
        ssMain.Name = "ssMain"
        ssMain.Size = New Size(1118, 22)
        ssMain.TabIndex = 38
        ssMain.Text = "StatusStrip1"
        ' 
        ' tslStatus
        ' 
        tslStatus.Name = "tslStatus"
        tslStatus.Size = New Size(39, 17)
        tslStatus.Text = "Ready"
        ' 
        ' Form1
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        CancelButton = btnExit
        ClientSize = New Size(1118, 720)
        Controls.Add(ssMain)
        Controls.Add(lblProgress)
        Controls.Add(pgbProgress)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label15)
        Controls.Add(lstFeeBreakdown)
        Controls.Add(rtbReceipt)
        Controls.Add(cboSMS)
        Controls.Add(lnkTermsConditions)
        Controls.Add(cboTermsConditions)
        Controls.Add(btnCalculate)
        Controls.Add(btnRegister)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VDSA Student Registration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picPassport, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(nudMonths, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(nudInstallments, ComponentModel.ISupportInitialize).EndInit()
        ssMain.ResumeLayout(False)
        ssMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOtherNames As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents cboRegion As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblAge As Label
    Friend WithEvents picPassport As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofdPhoto As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTuition As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cboProgramme As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents clbModules As CheckedListBox
    Friend WithEvents lstSelected As ListBox
    Friend WithEvents nudMonths As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents mcStartDate As MonthCalendar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents cboTermsConditions As CheckBox
    Friend WithEvents lnkTermsConditions As LinkLabel
    Friend WithEvents cboSMS As CheckBox
    Friend WithEvents rtbReceipt As RichTextBox
    Friend WithEvents lstFeeBreakdown As ListView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents mskGhanaCard As MaskedTextBox
    Friend WithEvents radInstallment As RadioButton
    Friend WithEvents radFull As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents nudInstallments As NumericUpDown
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents pgbProgress As ProgressBar
    Friend WithEvents lblProgress As Label
    Friend WithEvents chItem As ColumnHeader
    Friend WithEvents chAmount As ColumnHeader
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tslStatus As ToolStripStatusLabel

End Class
