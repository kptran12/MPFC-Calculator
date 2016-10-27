<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPFCCalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTestNum = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblnvFN = New System.Windows.Forms.Label()
        Me.lblInvLN = New System.Windows.Forms.Label()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.lblDriverFN = New System.Windows.Forms.Label()
        Me.lblDriverLN = New System.Windows.Forms.Label()
        Me.lblDriverPhone = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbTest = New System.Windows.Forms.GroupBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.tbTestNum = New System.Windows.Forms.TextBox()
        Me.gbInventor = New System.Windows.Forms.GroupBox()
        Me.tbInvLN = New System.Windows.Forms.TextBox()
        Me.tbInvFN = New System.Windows.Forms.TextBox()
        Me.gbDriver = New System.Windows.Forms.GroupBox()
        Me.ddID = New System.Windows.Forms.ComboBox()
        Me.tbDriverPhone = New System.Windows.Forms.TextBox()
        Me.tbDriverLN = New System.Windows.Forms.TextBox()
        Me.tbDriverFN = New System.Windows.Forms.TextBox()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.pbDriver = New System.Windows.Forms.PictureBox()
        Me.ddDataVehicle4 = New System.Windows.Forms.ComboBox()
        Me.ddDataVehicle3 = New System.Windows.Forms.ComboBox()
        Me.ddDataVehicle2 = New System.Windows.Forms.ComboBox()
        Me.ddDataVehicle1 = New System.Windows.Forms.ComboBox()
        Me.tbDataStartMile4 = New System.Windows.Forms.TextBox()
        Me.tbDataEndFuel4 = New System.Windows.Forms.TextBox()
        Me.tbDataEndFuel3 = New System.Windows.Forms.TextBox()
        Me.tbDataEndFuel2 = New System.Windows.Forms.TextBox()
        Me.tbDataEndFuel1 = New System.Windows.Forms.TextBox()
        Me.tbDataStartFuel4 = New System.Windows.Forms.TextBox()
        Me.tbDataStartFuel3 = New System.Windows.Forms.TextBox()
        Me.tbDataEndMile1 = New System.Windows.Forms.TextBox()
        Me.tbDataStartFuel2 = New System.Windows.Forms.TextBox()
        Me.tbDataStartMile1 = New System.Windows.Forms.TextBox()
        Me.tbDataStartFuel1 = New System.Windows.Forms.TextBox()
        Me.tbDataStartMile2 = New System.Windows.Forms.TextBox()
        Me.tbDataEndMile4 = New System.Windows.Forms.TextBox()
        Me.tbDataStartMile3 = New System.Windows.Forms.TextBox()
        Me.tbDataEndMile3 = New System.Windows.Forms.TextBox()
        Me.tbDataEndMile2 = New System.Windows.Forms.TextBox()
        Me.gbResults = New System.Windows.Forms.GroupBox()
        Me.tbResultsVehicle4 = New System.Windows.Forms.TextBox()
        Me.tbResultsVehicle3 = New System.Windows.Forms.TextBox()
        Me.tbResultsVehicle1 = New System.Windows.Forms.TextBox()
        Me.tbResultsVehicle2 = New System.Windows.Forms.TextBox()
        Me.tbMPFCRate4 = New System.Windows.Forms.TextBox()
        Me.tbMPFCRate3 = New System.Windows.Forms.TextBox()
        Me.tbMPFCRate1 = New System.Windows.Forms.TextBox()
        Me.tbMPFCRate2 = New System.Windows.Forms.TextBox()
        Me.tbResultsFamily4 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelCost4 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelCost3 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelCost2 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelCost1 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelUse4 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelUse3 = New System.Windows.Forms.TextBox()
        Me.tbResultsMile2 = New System.Windows.Forms.TextBox()
        Me.tbResultsMile1 = New System.Windows.Forms.TextBox()
        Me.tbResultsMile3 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelUse2 = New System.Windows.Forms.TextBox()
        Me.tbResultsFamily3 = New System.Windows.Forms.TextBox()
        Me.tbResultsFamily1 = New System.Windows.Forms.TextBox()
        Me.tbResultsMile4 = New System.Windows.Forms.TextBox()
        Me.tbResultsFuelUse1 = New System.Windows.Forms.TextBox()
        Me.tbResultsFamily2 = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTests = New System.Windows.Forms.Button()
        Me.gbTest.SuspendLayout()
        Me.gbInventor.SuspendLayout()
        Me.gbDriver.SuspendLayout()
        Me.gbData.SuspendLayout()
        CType(Me.pbDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Miles Per Fuel Cell (MPFC) Calculator"
        '
        'lblTestNum
        '
        Me.lblTestNum.AutoSize = True
        Me.lblTestNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestNum.Location = New System.Drawing.Point(6, 18)
        Me.lblTestNum.Name = "lblTestNum"
        Me.lblTestNum.Size = New System.Drawing.Size(56, 20)
        Me.lblTestNum.TabIndex = 1
        Me.lblTestNum.Text = "Test #"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(6, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        '
        'lblnvFN
        '
        Me.lblnvFN.AutoSize = True
        Me.lblnvFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnvFN.Location = New System.Drawing.Point(6, 30)
        Me.lblnvFN.Name = "lblnvFN"
        Me.lblnvFN.Size = New System.Drawing.Size(92, 20)
        Me.lblnvFN.TabIndex = 3
        Me.lblnvFN.Text = "First Name"
        '
        'lblInvLN
        '
        Me.lblInvLN.AutoSize = True
        Me.lblInvLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvLN.Location = New System.Drawing.Point(6, 63)
        Me.lblInvLN.Name = "lblInvLN"
        Me.lblInvLN.Size = New System.Drawing.Size(91, 20)
        Me.lblInvLN.TabIndex = 4
        Me.lblInvLN.Text = "Last Name"
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverID.Location = New System.Drawing.Point(6, 18)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(26, 20)
        Me.lblDriverID.TabIndex = 5
        Me.lblDriverID.Text = "ID"
        '
        'lblDriverFN
        '
        Me.lblDriverFN.AutoSize = True
        Me.lblDriverFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverFN.Location = New System.Drawing.Point(6, 50)
        Me.lblDriverFN.Name = "lblDriverFN"
        Me.lblDriverFN.Size = New System.Drawing.Size(92, 20)
        Me.lblDriverFN.TabIndex = 6
        Me.lblDriverFN.Text = "First Name"
        '
        'lblDriverLN
        '
        Me.lblDriverLN.AutoSize = True
        Me.lblDriverLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverLN.Location = New System.Drawing.Point(6, 79)
        Me.lblDriverLN.Name = "lblDriverLN"
        Me.lblDriverLN.Size = New System.Drawing.Size(91, 20)
        Me.lblDriverLN.TabIndex = 7
        Me.lblDriverLN.Text = "Last Name"
        '
        'lblDriverPhone
        '
        Me.lblDriverPhone.AutoSize = True
        Me.lblDriverPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverPhone.Location = New System.Drawing.Point(6, 110)
        Me.lblDriverPhone.Name = "lblDriverPhone"
        Me.lblDriverPhone.Size = New System.Drawing.Size(56, 20)
        Me.lblDriverPhone.TabIndex = 8
        Me.lblDriverPhone.Text = "Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Vehicle"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(225, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Start Mileage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(359, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "End Mileage"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(485, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Start Fuel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(615, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "End Fuel"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Vehicle"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(229, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Family"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(359, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Mileage"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(485, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Fuel Used"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(615, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Fuel Cost"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(752, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 20)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "MPFC Rating"
        '
        'gbTest
        '
        Me.gbTest.Controls.Add(Me.tbDate)
        Me.gbTest.Controls.Add(Me.tbTestNum)
        Me.gbTest.Controls.Add(Me.lblTestNum)
        Me.gbTest.Controls.Add(Me.lblDate)
        Me.gbTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTest.Location = New System.Drawing.Point(40, 53)
        Me.gbTest.Name = "gbTest"
        Me.gbTest.Size = New System.Drawing.Size(281, 100)
        Me.gbTest.TabIndex = 20
        Me.gbTest.TabStop = False
        Me.gbTest.Text = "Test Info"
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(73, 48)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(100, 22)
        Me.tbDate.TabIndex = 4
        '
        'tbTestNum
        '
        Me.tbTestNum.Location = New System.Drawing.Point(73, 15)
        Me.tbTestNum.Name = "tbTestNum"
        Me.tbTestNum.Size = New System.Drawing.Size(100, 22)
        Me.tbTestNum.TabIndex = 3
        '
        'gbInventor
        '
        Me.gbInventor.Controls.Add(Me.tbInvLN)
        Me.gbInventor.Controls.Add(Me.tbInvFN)
        Me.gbInventor.Controls.Add(Me.lblnvFN)
        Me.gbInventor.Controls.Add(Me.lblInvLN)
        Me.gbInventor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInventor.Location = New System.Drawing.Point(412, 53)
        Me.gbInventor.Name = "gbInventor"
        Me.gbInventor.Size = New System.Drawing.Size(303, 100)
        Me.gbInventor.TabIndex = 21
        Me.gbInventor.TabStop = False
        Me.gbInventor.Text = "Inventor Info"
        '
        'tbInvLN
        '
        Me.tbInvLN.Location = New System.Drawing.Point(118, 61)
        Me.tbInvLN.Name = "tbInvLN"
        Me.tbInvLN.Size = New System.Drawing.Size(100, 22)
        Me.tbInvLN.TabIndex = 6
        '
        'tbInvFN
        '
        Me.tbInvFN.Location = New System.Drawing.Point(118, 30)
        Me.tbInvFN.Name = "tbInvFN"
        Me.tbInvFN.Size = New System.Drawing.Size(100, 22)
        Me.tbInvFN.TabIndex = 5
        '
        'gbDriver
        '
        Me.gbDriver.Controls.Add(Me.ddID)
        Me.gbDriver.Controls.Add(Me.tbDriverPhone)
        Me.gbDriver.Controls.Add(Me.tbDriverLN)
        Me.gbDriver.Controls.Add(Me.tbDriverFN)
        Me.gbDriver.Controls.Add(Me.lblDriverID)
        Me.gbDriver.Controls.Add(Me.lblDriverFN)
        Me.gbDriver.Controls.Add(Me.lblDriverLN)
        Me.gbDriver.Controls.Add(Me.lblDriverPhone)
        Me.gbDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDriver.Location = New System.Drawing.Point(776, 53)
        Me.gbDriver.Name = "gbDriver"
        Me.gbDriver.Size = New System.Drawing.Size(280, 137)
        Me.gbDriver.TabIndex = 22
        Me.gbDriver.TabStop = False
        Me.gbDriver.Text = "Driver Info"
        '
        'ddID
        '
        Me.ddID.FormattingEnabled = True
        Me.ddID.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.ddID.Location = New System.Drawing.Point(141, 18)
        Me.ddID.Name = "ddID"
        Me.ddID.Size = New System.Drawing.Size(121, 24)
        Me.ddID.TabIndex = 12
        '
        'tbDriverPhone
        '
        Me.tbDriverPhone.Location = New System.Drawing.Point(141, 110)
        Me.tbDriverPhone.Name = "tbDriverPhone"
        Me.tbDriverPhone.ReadOnly = True
        Me.tbDriverPhone.Size = New System.Drawing.Size(100, 22)
        Me.tbDriverPhone.TabIndex = 11
        '
        'tbDriverLN
        '
        Me.tbDriverLN.Location = New System.Drawing.Point(141, 79)
        Me.tbDriverLN.Name = "tbDriverLN"
        Me.tbDriverLN.ReadOnly = True
        Me.tbDriverLN.Size = New System.Drawing.Size(100, 22)
        Me.tbDriverLN.TabIndex = 10
        '
        'tbDriverFN
        '
        Me.tbDriverFN.Location = New System.Drawing.Point(141, 50)
        Me.tbDriverFN.Name = "tbDriverFN"
        Me.tbDriverFN.ReadOnly = True
        Me.tbDriverFN.Size = New System.Drawing.Size(100, 22)
        Me.tbDriverFN.TabIndex = 9
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.pbDriver)
        Me.gbData.Controls.Add(Me.ddDataVehicle4)
        Me.gbData.Controls.Add(Me.ddDataVehicle3)
        Me.gbData.Controls.Add(Me.ddDataVehicle2)
        Me.gbData.Controls.Add(Me.ddDataVehicle1)
        Me.gbData.Controls.Add(Me.tbDataStartMile4)
        Me.gbData.Controls.Add(Me.tbDataEndFuel4)
        Me.gbData.Controls.Add(Me.Label10)
        Me.gbData.Controls.Add(Me.tbDataEndFuel3)
        Me.gbData.Controls.Add(Me.Label11)
        Me.gbData.Controls.Add(Me.tbDataEndFuel2)
        Me.gbData.Controls.Add(Me.Label12)
        Me.gbData.Controls.Add(Me.tbDataEndFuel1)
        Me.gbData.Controls.Add(Me.Label13)
        Me.gbData.Controls.Add(Me.tbDataStartFuel4)
        Me.gbData.Controls.Add(Me.Label14)
        Me.gbData.Controls.Add(Me.tbDataStartFuel3)
        Me.gbData.Controls.Add(Me.tbDataEndMile1)
        Me.gbData.Controls.Add(Me.tbDataStartFuel2)
        Me.gbData.Controls.Add(Me.tbDataStartMile1)
        Me.gbData.Controls.Add(Me.tbDataStartFuel1)
        Me.gbData.Controls.Add(Me.tbDataStartMile2)
        Me.gbData.Controls.Add(Me.tbDataEndMile4)
        Me.gbData.Controls.Add(Me.tbDataStartMile3)
        Me.gbData.Controls.Add(Me.tbDataEndMile3)
        Me.gbData.Controls.Add(Me.tbDataEndMile2)
        Me.gbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbData.Location = New System.Drawing.Point(12, 191)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(1058, 237)
        Me.gbData.TabIndex = 23
        Me.gbData.TabStop = False
        Me.gbData.Text = "Data"
        '
        'pbDriver
        '
        Me.pbDriver.Location = New System.Drawing.Point(783, 18)
        Me.pbDriver.MaximumSize = New System.Drawing.Size(200, 194)
        Me.pbDriver.Name = "pbDriver"
        Me.pbDriver.Size = New System.Drawing.Size(200, 194)
        Me.pbDriver.TabIndex = 48
        Me.pbDriver.TabStop = False
        '
        'ddDataVehicle4
        '
        Me.ddDataVehicle4.FormattingEnabled = True
        Me.ddDataVehicle4.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.ddDataVehicle4.Location = New System.Drawing.Point(19, 137)
        Me.ddDataVehicle4.Name = "ddDataVehicle4"
        Me.ddDataVehicle4.Size = New System.Drawing.Size(121, 28)
        Me.ddDataVehicle4.TabIndex = 47
        '
        'ddDataVehicle3
        '
        Me.ddDataVehicle3.FormattingEnabled = True
        Me.ddDataVehicle3.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.ddDataVehicle3.Location = New System.Drawing.Point(19, 107)
        Me.ddDataVehicle3.Name = "ddDataVehicle3"
        Me.ddDataVehicle3.Size = New System.Drawing.Size(121, 28)
        Me.ddDataVehicle3.TabIndex = 46
        '
        'ddDataVehicle2
        '
        Me.ddDataVehicle2.FormattingEnabled = True
        Me.ddDataVehicle2.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.ddDataVehicle2.Location = New System.Drawing.Point(19, 77)
        Me.ddDataVehicle2.Name = "ddDataVehicle2"
        Me.ddDataVehicle2.Size = New System.Drawing.Size(121, 28)
        Me.ddDataVehicle2.TabIndex = 45
        '
        'ddDataVehicle1
        '
        Me.ddDataVehicle1.FormattingEnabled = True
        Me.ddDataVehicle1.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.ddDataVehicle1.Location = New System.Drawing.Point(19, 49)
        Me.ddDataVehicle1.Name = "ddDataVehicle1"
        Me.ddDataVehicle1.Size = New System.Drawing.Size(121, 28)
        Me.ddDataVehicle1.TabIndex = 44
        '
        'tbDataStartMile4
        '
        Me.tbDataStartMile4.Location = New System.Drawing.Point(233, 133)
        Me.tbDataStartMile4.Name = "tbDataStartMile4"
        Me.tbDataStartMile4.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartMile4.TabIndex = 43
        '
        'tbDataEndFuel4
        '
        Me.tbDataEndFuel4.Location = New System.Drawing.Point(617, 133)
        Me.tbDataEndFuel4.Name = "tbDataEndFuel4"
        Me.tbDataEndFuel4.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndFuel4.TabIndex = 42
        '
        'tbDataEndFuel3
        '
        Me.tbDataEndFuel3.Location = New System.Drawing.Point(617, 105)
        Me.tbDataEndFuel3.Name = "tbDataEndFuel3"
        Me.tbDataEndFuel3.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndFuel3.TabIndex = 41
        '
        'tbDataEndFuel2
        '
        Me.tbDataEndFuel2.Location = New System.Drawing.Point(617, 77)
        Me.tbDataEndFuel2.Name = "tbDataEndFuel2"
        Me.tbDataEndFuel2.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndFuel2.TabIndex = 40
        '
        'tbDataEndFuel1
        '
        Me.tbDataEndFuel1.Location = New System.Drawing.Point(617, 49)
        Me.tbDataEndFuel1.Name = "tbDataEndFuel1"
        Me.tbDataEndFuel1.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndFuel1.TabIndex = 39
        '
        'tbDataStartFuel4
        '
        Me.tbDataStartFuel4.Location = New System.Drawing.Point(489, 133)
        Me.tbDataStartFuel4.Name = "tbDataStartFuel4"
        Me.tbDataStartFuel4.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartFuel4.TabIndex = 38
        '
        'tbDataStartFuel3
        '
        Me.tbDataStartFuel3.Location = New System.Drawing.Point(489, 105)
        Me.tbDataStartFuel3.Name = "tbDataStartFuel3"
        Me.tbDataStartFuel3.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartFuel3.TabIndex = 37
        '
        'tbDataEndMile1
        '
        Me.tbDataEndMile1.Location = New System.Drawing.Point(362, 49)
        Me.tbDataEndMile1.Name = "tbDataEndMile1"
        Me.tbDataEndMile1.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndMile1.TabIndex = 31
        '
        'tbDataStartFuel2
        '
        Me.tbDataStartFuel2.Location = New System.Drawing.Point(489, 77)
        Me.tbDataStartFuel2.Name = "tbDataStartFuel2"
        Me.tbDataStartFuel2.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartFuel2.TabIndex = 36
        '
        'tbDataStartMile1
        '
        Me.tbDataStartMile1.Location = New System.Drawing.Point(233, 49)
        Me.tbDataStartMile1.Name = "tbDataStartMile1"
        Me.tbDataStartMile1.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartMile1.TabIndex = 28
        '
        'tbDataStartFuel1
        '
        Me.tbDataStartFuel1.Location = New System.Drawing.Point(489, 49)
        Me.tbDataStartFuel1.Name = "tbDataStartFuel1"
        Me.tbDataStartFuel1.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartFuel1.TabIndex = 35
        '
        'tbDataStartMile2
        '
        Me.tbDataStartMile2.Location = New System.Drawing.Point(233, 77)
        Me.tbDataStartMile2.Name = "tbDataStartMile2"
        Me.tbDataStartMile2.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartMile2.TabIndex = 29
        '
        'tbDataEndMile4
        '
        Me.tbDataEndMile4.Location = New System.Drawing.Point(362, 133)
        Me.tbDataEndMile4.Name = "tbDataEndMile4"
        Me.tbDataEndMile4.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndMile4.TabIndex = 34
        '
        'tbDataStartMile3
        '
        Me.tbDataStartMile3.Location = New System.Drawing.Point(233, 105)
        Me.tbDataStartMile3.Name = "tbDataStartMile3"
        Me.tbDataStartMile3.Size = New System.Drawing.Size(100, 27)
        Me.tbDataStartMile3.TabIndex = 30
        '
        'tbDataEndMile3
        '
        Me.tbDataEndMile3.Location = New System.Drawing.Point(362, 105)
        Me.tbDataEndMile3.Name = "tbDataEndMile3"
        Me.tbDataEndMile3.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndMile3.TabIndex = 33
        '
        'tbDataEndMile2
        '
        Me.tbDataEndMile2.Location = New System.Drawing.Point(362, 77)
        Me.tbDataEndMile2.Name = "tbDataEndMile2"
        Me.tbDataEndMile2.Size = New System.Drawing.Size(100, 27)
        Me.tbDataEndMile2.TabIndex = 32
        '
        'gbResults
        '
        Me.gbResults.Controls.Add(Me.tbResultsVehicle4)
        Me.gbResults.Controls.Add(Me.tbResultsVehicle3)
        Me.gbResults.Controls.Add(Me.tbResultsVehicle1)
        Me.gbResults.Controls.Add(Me.tbResultsVehicle2)
        Me.gbResults.Controls.Add(Me.tbMPFCRate4)
        Me.gbResults.Controls.Add(Me.tbMPFCRate3)
        Me.gbResults.Controls.Add(Me.tbMPFCRate1)
        Me.gbResults.Controls.Add(Me.tbMPFCRate2)
        Me.gbResults.Controls.Add(Me.tbResultsFamily4)
        Me.gbResults.Controls.Add(Me.Label15)
        Me.gbResults.Controls.Add(Me.tbResultsFuelCost4)
        Me.gbResults.Controls.Add(Me.Label16)
        Me.gbResults.Controls.Add(Me.tbResultsFuelCost3)
        Me.gbResults.Controls.Add(Me.Label17)
        Me.gbResults.Controls.Add(Me.tbResultsFuelCost2)
        Me.gbResults.Controls.Add(Me.Label18)
        Me.gbResults.Controls.Add(Me.tbResultsFuelCost1)
        Me.gbResults.Controls.Add(Me.Label19)
        Me.gbResults.Controls.Add(Me.tbResultsFuelUse4)
        Me.gbResults.Controls.Add(Me.Label20)
        Me.gbResults.Controls.Add(Me.tbResultsFuelUse3)
        Me.gbResults.Controls.Add(Me.tbResultsMile2)
        Me.gbResults.Controls.Add(Me.tbResultsMile1)
        Me.gbResults.Controls.Add(Me.tbResultsMile3)
        Me.gbResults.Controls.Add(Me.tbResultsFuelUse2)
        Me.gbResults.Controls.Add(Me.tbResultsFamily3)
        Me.gbResults.Controls.Add(Me.tbResultsFamily1)
        Me.gbResults.Controls.Add(Me.tbResultsMile4)
        Me.gbResults.Controls.Add(Me.tbResultsFuelUse1)
        Me.gbResults.Controls.Add(Me.tbResultsFamily2)
        Me.gbResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResults.Location = New System.Drawing.Point(39, 472)
        Me.gbResults.Name = "gbResults"
        Me.gbResults.Size = New System.Drawing.Size(890, 194)
        Me.gbResults.TabIndex = 24
        Me.gbResults.TabStop = False
        Me.gbResults.Text = "Results:"
        '
        'tbResultsVehicle4
        '
        Me.tbResultsVehicle4.Location = New System.Drawing.Point(26, 148)
        Me.tbResultsVehicle4.Name = "tbResultsVehicle4"
        Me.tbResultsVehicle4.ReadOnly = True
        Me.tbResultsVehicle4.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsVehicle4.TabIndex = 67
        '
        'tbResultsVehicle3
        '
        Me.tbResultsVehicle3.Location = New System.Drawing.Point(26, 120)
        Me.tbResultsVehicle3.Name = "tbResultsVehicle3"
        Me.tbResultsVehicle3.ReadOnly = True
        Me.tbResultsVehicle3.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsVehicle3.TabIndex = 66
        '
        'tbResultsVehicle1
        '
        Me.tbResultsVehicle1.Location = New System.Drawing.Point(26, 64)
        Me.tbResultsVehicle1.Name = "tbResultsVehicle1"
        Me.tbResultsVehicle1.ReadOnly = True
        Me.tbResultsVehicle1.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsVehicle1.TabIndex = 64
        '
        'tbResultsVehicle2
        '
        Me.tbResultsVehicle2.Location = New System.Drawing.Point(26, 92)
        Me.tbResultsVehicle2.Name = "tbResultsVehicle2"
        Me.tbResultsVehicle2.ReadOnly = True
        Me.tbResultsVehicle2.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsVehicle2.TabIndex = 65
        '
        'tbMPFCRate4
        '
        Me.tbMPFCRate4.Location = New System.Drawing.Point(756, 148)
        Me.tbMPFCRate4.Name = "tbMPFCRate4"
        Me.tbMPFCRate4.ReadOnly = True
        Me.tbMPFCRate4.Size = New System.Drawing.Size(100, 27)
        Me.tbMPFCRate4.TabIndex = 63
        '
        'tbMPFCRate3
        '
        Me.tbMPFCRate3.Location = New System.Drawing.Point(756, 120)
        Me.tbMPFCRate3.Name = "tbMPFCRate3"
        Me.tbMPFCRate3.ReadOnly = True
        Me.tbMPFCRate3.Size = New System.Drawing.Size(100, 27)
        Me.tbMPFCRate3.TabIndex = 62
        '
        'tbMPFCRate1
        '
        Me.tbMPFCRate1.Location = New System.Drawing.Point(756, 64)
        Me.tbMPFCRate1.Name = "tbMPFCRate1"
        Me.tbMPFCRate1.ReadOnly = True
        Me.tbMPFCRate1.Size = New System.Drawing.Size(100, 27)
        Me.tbMPFCRate1.TabIndex = 60
        '
        'tbMPFCRate2
        '
        Me.tbMPFCRate2.Location = New System.Drawing.Point(756, 92)
        Me.tbMPFCRate2.Name = "tbMPFCRate2"
        Me.tbMPFCRate2.ReadOnly = True
        Me.tbMPFCRate2.Size = New System.Drawing.Size(100, 27)
        Me.tbMPFCRate2.TabIndex = 61
        '
        'tbResultsFamily4
        '
        Me.tbResultsFamily4.Location = New System.Drawing.Point(233, 148)
        Me.tbResultsFamily4.Name = "tbResultsFamily4"
        Me.tbResultsFamily4.ReadOnly = True
        Me.tbResultsFamily4.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFamily4.TabIndex = 59
        '
        'tbResultsFuelCost4
        '
        Me.tbResultsFuelCost4.Location = New System.Drawing.Point(617, 148)
        Me.tbResultsFuelCost4.Name = "tbResultsFuelCost4"
        Me.tbResultsFuelCost4.ReadOnly = True
        Me.tbResultsFuelCost4.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelCost4.TabIndex = 58
        '
        'tbResultsFuelCost3
        '
        Me.tbResultsFuelCost3.Location = New System.Drawing.Point(617, 120)
        Me.tbResultsFuelCost3.Name = "tbResultsFuelCost3"
        Me.tbResultsFuelCost3.ReadOnly = True
        Me.tbResultsFuelCost3.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelCost3.TabIndex = 57
        '
        'tbResultsFuelCost2
        '
        Me.tbResultsFuelCost2.Location = New System.Drawing.Point(617, 92)
        Me.tbResultsFuelCost2.Name = "tbResultsFuelCost2"
        Me.tbResultsFuelCost2.ReadOnly = True
        Me.tbResultsFuelCost2.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelCost2.TabIndex = 56
        '
        'tbResultsFuelCost1
        '
        Me.tbResultsFuelCost1.Location = New System.Drawing.Point(617, 64)
        Me.tbResultsFuelCost1.Name = "tbResultsFuelCost1"
        Me.tbResultsFuelCost1.ReadOnly = True
        Me.tbResultsFuelCost1.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelCost1.TabIndex = 55
        '
        'tbResultsFuelUse4
        '
        Me.tbResultsFuelUse4.Location = New System.Drawing.Point(489, 148)
        Me.tbResultsFuelUse4.Name = "tbResultsFuelUse4"
        Me.tbResultsFuelUse4.ReadOnly = True
        Me.tbResultsFuelUse4.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelUse4.TabIndex = 54
        '
        'tbResultsFuelUse3
        '
        Me.tbResultsFuelUse3.Location = New System.Drawing.Point(489, 120)
        Me.tbResultsFuelUse3.Name = "tbResultsFuelUse3"
        Me.tbResultsFuelUse3.ReadOnly = True
        Me.tbResultsFuelUse3.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelUse3.TabIndex = 53
        '
        'tbResultsMile2
        '
        Me.tbResultsMile2.Location = New System.Drawing.Point(362, 92)
        Me.tbResultsMile2.Name = "tbResultsMile2"
        Me.tbResultsMile2.ReadOnly = True
        Me.tbResultsMile2.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsMile2.TabIndex = 48
        '
        'tbResultsMile1
        '
        Me.tbResultsMile1.Location = New System.Drawing.Point(362, 64)
        Me.tbResultsMile1.Name = "tbResultsMile1"
        Me.tbResultsMile1.ReadOnly = True
        Me.tbResultsMile1.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsMile1.TabIndex = 47
        '
        'tbResultsMile3
        '
        Me.tbResultsMile3.Location = New System.Drawing.Point(362, 120)
        Me.tbResultsMile3.Name = "tbResultsMile3"
        Me.tbResultsMile3.ReadOnly = True
        Me.tbResultsMile3.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsMile3.TabIndex = 49
        '
        'tbResultsFuelUse2
        '
        Me.tbResultsFuelUse2.Location = New System.Drawing.Point(489, 92)
        Me.tbResultsFuelUse2.Name = "tbResultsFuelUse2"
        Me.tbResultsFuelUse2.ReadOnly = True
        Me.tbResultsFuelUse2.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelUse2.TabIndex = 52
        '
        'tbResultsFamily3
        '
        Me.tbResultsFamily3.Location = New System.Drawing.Point(233, 120)
        Me.tbResultsFamily3.Name = "tbResultsFamily3"
        Me.tbResultsFamily3.ReadOnly = True
        Me.tbResultsFamily3.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFamily3.TabIndex = 46
        '
        'tbResultsFamily1
        '
        Me.tbResultsFamily1.Location = New System.Drawing.Point(233, 64)
        Me.tbResultsFamily1.Name = "tbResultsFamily1"
        Me.tbResultsFamily1.ReadOnly = True
        Me.tbResultsFamily1.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFamily1.TabIndex = 44
        '
        'tbResultsMile4
        '
        Me.tbResultsMile4.Location = New System.Drawing.Point(362, 148)
        Me.tbResultsMile4.Name = "tbResultsMile4"
        Me.tbResultsMile4.ReadOnly = True
        Me.tbResultsMile4.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsMile4.TabIndex = 50
        '
        'tbResultsFuelUse1
        '
        Me.tbResultsFuelUse1.Location = New System.Drawing.Point(489, 64)
        Me.tbResultsFuelUse1.Name = "tbResultsFuelUse1"
        Me.tbResultsFuelUse1.ReadOnly = True
        Me.tbResultsFuelUse1.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFuelUse1.TabIndex = 51
        '
        'tbResultsFamily2
        '
        Me.tbResultsFamily2.Location = New System.Drawing.Point(233, 92)
        Me.tbResultsFamily2.Name = "tbResultsFamily2"
        Me.tbResultsFamily2.ReadOnly = True
        Me.tbResultsFamily2.Size = New System.Drawing.Size(100, 27)
        Me.tbResultsFamily2.TabIndex = 45
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(917, 672)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 28
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(125, 672)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 29
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(246, 672)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTests
        '
        Me.btnTests.Location = New System.Drawing.Point(718, 672)
        Me.btnTests.Name = "btnTests"
        Me.btnTests.Size = New System.Drawing.Size(75, 23)
        Me.btnTests.TabIndex = 31
        Me.btnTests.Text = "All Tests"
        Me.btnTests.UseVisualStyleBackColor = True
        '
        'MPFCCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 707)
        Me.Controls.Add(Me.btnTests)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.gbDriver)
        Me.Controls.Add(Me.gbInventor)
        Me.Controls.Add(Me.gbTest)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MPFCCalculator"
        Me.Text = "MPFC Calculator"
        Me.gbTest.ResumeLayout(False)
        Me.gbTest.PerformLayout()
        Me.gbInventor.ResumeLayout(False)
        Me.gbInventor.PerformLayout()
        Me.gbDriver.ResumeLayout(False)
        Me.gbDriver.PerformLayout()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.pbDriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResults.ResumeLayout(False)
        Me.gbResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTestNum As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblnvFN As Label
    Friend WithEvents lblInvLN As Label
    Friend WithEvents lblDriverID As Label
    Friend WithEvents lblDriverFN As Label
    Friend WithEvents lblDriverLN As Label
    Friend WithEvents lblDriverPhone As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents gbTest As GroupBox
    Friend WithEvents gbInventor As GroupBox
    Friend WithEvents gbDriver As GroupBox
    Friend WithEvents gbData As GroupBox
    Friend WithEvents gbResults As GroupBox
    Friend WithEvents tbDate As TextBox
    Friend WithEvents tbTestNum As TextBox
    Friend WithEvents tbInvLN As TextBox
    Friend WithEvents tbInvFN As TextBox
    Friend WithEvents tbDriverPhone As TextBox
    Friend WithEvents tbDriverLN As TextBox
    Friend WithEvents tbDriverFN As TextBox
    Friend WithEvents ddDataVehicle4 As ComboBox
    Friend WithEvents ddDataVehicle3 As ComboBox
    Friend WithEvents ddDataVehicle2 As ComboBox
    Friend WithEvents ddDataVehicle1 As ComboBox
    Friend WithEvents tbDataStartMile4 As TextBox
    Friend WithEvents tbDataEndFuel4 As TextBox
    Friend WithEvents tbDataEndFuel3 As TextBox
    Friend WithEvents tbDataEndFuel2 As TextBox
    Friend WithEvents tbDataEndFuel1 As TextBox
    Friend WithEvents tbDataStartFuel4 As TextBox
    Friend WithEvents tbDataStartFuel3 As TextBox
    Friend WithEvents tbDataEndMile1 As TextBox
    Friend WithEvents tbDataStartFuel2 As TextBox
    Friend WithEvents tbDataStartMile1 As TextBox
    Friend WithEvents tbDataStartFuel1 As TextBox
    Friend WithEvents tbDataStartMile2 As TextBox
    Friend WithEvents tbDataEndMile4 As TextBox
    Friend WithEvents tbDataStartMile3 As TextBox
    Friend WithEvents tbDataEndMile3 As TextBox
    Friend WithEvents tbDataEndMile2 As TextBox
    Friend WithEvents tbMPFCRate4 As TextBox
    Friend WithEvents tbMPFCRate3 As TextBox
    Friend WithEvents tbMPFCRate1 As TextBox
    Friend WithEvents tbMPFCRate2 As TextBox
    Friend WithEvents tbResultsFamily4 As TextBox
    Friend WithEvents tbResultsFuelCost4 As TextBox
    Friend WithEvents tbResultsFuelCost3 As TextBox
    Friend WithEvents tbResultsFuelCost2 As TextBox
    Friend WithEvents tbResultsFuelCost1 As TextBox
    Friend WithEvents tbResultsFuelUse4 As TextBox
    Friend WithEvents tbResultsFuelUse3 As TextBox
    Friend WithEvents tbResultsMile2 As TextBox
    Friend WithEvents tbResultsMile1 As TextBox
    Friend WithEvents tbResultsMile3 As TextBox
    Friend WithEvents tbResultsFuelUse2 As TextBox
    Friend WithEvents tbResultsFamily3 As TextBox
    Friend WithEvents tbResultsFamily1 As TextBox
    Friend WithEvents tbResultsMile4 As TextBox
    Friend WithEvents tbResultsFuelUse1 As TextBox
    Friend WithEvents tbResultsFamily2 As TextBox
    Friend WithEvents tbResultsVehicle4 As TextBox
    Friend WithEvents tbResultsVehicle3 As TextBox
    Friend WithEvents tbResultsVehicle1 As TextBox
    Friend WithEvents tbResultsVehicle2 As TextBox
    Friend WithEvents ddID As ComboBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTests As Button
    Friend WithEvents pbDriver As PictureBox
End Class
