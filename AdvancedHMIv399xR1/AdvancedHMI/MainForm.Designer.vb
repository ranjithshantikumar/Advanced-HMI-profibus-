<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusRTUCom1 = New AdvancedHMIDrivers.ModbusRTUCom(Me.components)
        Me.DigitalPanelMeter9 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter8 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter7 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter6 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter5 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter4 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter3 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicTrendChart1 = New AdvancedHMIControls.BasicTrendChart()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BasicDataLogger21 = New AdvancedHMIControls.BasicDataLogger2()
        Me.SimpleWebServer1 = New AdvancedHMIControls.SimpleWebServer()
        CType(Me.ModbusRTUCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicDataLogger21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleWebServer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ModbusRTUCom1
        '
        Me.ModbusRTUCom1.BaudRate = 9600
        Me.ModbusRTUCom1.DataBits = 8
        Me.ModbusRTUCom1.DisableSubscriptions = False
        Me.ModbusRTUCom1.EnableLogging = False
        Me.ModbusRTUCom1.IniFileName = ""
        Me.ModbusRTUCom1.IniFileSection = Nothing
        Me.ModbusRTUCom1.MaxReadGroupSize = 20
        Me.ModbusRTUCom1.Parity = System.IO.Ports.Parity.None
        Me.ModbusRTUCom1.PollRateOverride = 2000
        Me.ModbusRTUCom1.PortName = "COM7"
        Me.ModbusRTUCom1.StationAddress = CType(2, Byte)
        Me.ModbusRTUCom1.StopBits = System.IO.Ports.StopBits.One
        Me.ModbusRTUCom1.SwapBytes = True
        Me.ModbusRTUCom1.SwapWords = False
        Me.ModbusRTUCom1.TimeOut = 3000
        '
        'DigitalPanelMeter9
        '
        Me.DigitalPanelMeter9.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter9.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter9.DecimalPosition = 0
        Me.DigitalPanelMeter9.ForeColor = System.Drawing.Color.Fuchsia
        Me.DigitalPanelMeter9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter9.KeypadMaxValue = 0R
        Me.DigitalPanelMeter9.KeypadMinValue = 0R
        Me.DigitalPanelMeter9.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter9.KeypadText = Nothing
        Me.DigitalPanelMeter9.KeypadWidth = 300
        Me.DigitalPanelMeter9.Location = New System.Drawing.Point(343, 348)
        Me.DigitalPanelMeter9.Name = "DigitalPanelMeter9"
        Me.DigitalPanelMeter9.NumberOfDigits = 5
        Me.DigitalPanelMeter9.PLCAddressKeypad = ""
        Me.DigitalPanelMeter9.PLCAddressValue = "40013"
        Me.DigitalPanelMeter9.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter9.Size = New System.Drawing.Size(349, 151)
        Me.DigitalPanelMeter9.TabIndex = 76
        Me.DigitalPanelMeter9.Text = "P.F(LAG<1000,LEAD>1000)"
        Me.DigitalPanelMeter9.Value = 0R
        Me.DigitalPanelMeter9.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter9.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter8
        '
        Me.DigitalPanelMeter8.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter8.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter8.DecimalPosition = 1
        Me.DigitalPanelMeter8.ForeColor = System.Drawing.Color.HotPink
        Me.DigitalPanelMeter8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter8.KeypadMaxValue = 0R
        Me.DigitalPanelMeter8.KeypadMinValue = 0R
        Me.DigitalPanelMeter8.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter8.KeypadText = Nothing
        Me.DigitalPanelMeter8.KeypadWidth = 300
        Me.DigitalPanelMeter8.Location = New System.Drawing.Point(45, 419)
        Me.DigitalPanelMeter8.Name = "DigitalPanelMeter8"
        Me.DigitalPanelMeter8.NumberOfDigits = 5
        Me.DigitalPanelMeter8.PLCAddressKeypad = ""
        Me.DigitalPanelMeter8.PLCAddressValue = "40011"
        Me.DigitalPanelMeter8.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter8.TabIndex = 75
        Me.DigitalPanelMeter8.Text = "kW"
        Me.DigitalPanelMeter8.Value = 0R
        Me.DigitalPanelMeter8.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter8.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter7
        '
        Me.DigitalPanelMeter7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter7.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter7.DecimalPosition = 1
        Me.DigitalPanelMeter7.ForeColor = System.Drawing.Color.Magenta
        Me.DigitalPanelMeter7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter7.KeypadMaxValue = 0R
        Me.DigitalPanelMeter7.KeypadMinValue = 0R
        Me.DigitalPanelMeter7.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter7.KeypadText = Nothing
        Me.DigitalPanelMeter7.KeypadWidth = 300
        Me.DigitalPanelMeter7.Location = New System.Drawing.Point(45, 316)
        Me.DigitalPanelMeter7.Name = "DigitalPanelMeter7"
        Me.DigitalPanelMeter7.NumberOfDigits = 5
        Me.DigitalPanelMeter7.PLCAddressKeypad = ""
        Me.DigitalPanelMeter7.PLCAddressValue = "40010"
        Me.DigitalPanelMeter7.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter7.TabIndex = 74
        Me.DigitalPanelMeter7.Text = "kVA"
        Me.DigitalPanelMeter7.Value = 0R
        Me.DigitalPanelMeter7.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter7.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter6
        '
        Me.DigitalPanelMeter6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter6.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter6.DecimalPosition = 1
        Me.DigitalPanelMeter6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter6.ForeColor = System.Drawing.Color.SteelBlue
        Me.DigitalPanelMeter6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter6.KeypadMaxValue = 0R
        Me.DigitalPanelMeter6.KeypadMinValue = 0R
        Me.DigitalPanelMeter6.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter6.KeypadText = Nothing
        Me.DigitalPanelMeter6.KeypadWidth = 300
        Me.DigitalPanelMeter6.Location = New System.Drawing.Point(485, 213)
        Me.DigitalPanelMeter6.Name = "DigitalPanelMeter6"
        Me.DigitalPanelMeter6.NumberOfDigits = 5
        Me.DigitalPanelMeter6.PLCAddressKeypad = ""
        Me.DigitalPanelMeter6.PLCAddressValue = "40009"
        Me.DigitalPanelMeter6.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter6.TabIndex = 73
        Me.DigitalPanelMeter6.Text = "B CURRENT"
        Me.DigitalPanelMeter6.Value = 0R
        Me.DigitalPanelMeter6.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter6.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter5
        '
        Me.DigitalPanelMeter5.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter5.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter5.DecimalPosition = 1
        Me.DigitalPanelMeter5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter5.ForeColor = System.Drawing.Color.LightGreen
        Me.DigitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter5.KeypadMaxValue = 0R
        Me.DigitalPanelMeter5.KeypadMinValue = 0R
        Me.DigitalPanelMeter5.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter5.KeypadText = Nothing
        Me.DigitalPanelMeter5.KeypadWidth = 300
        Me.DigitalPanelMeter5.Location = New System.Drawing.Point(264, 213)
        Me.DigitalPanelMeter5.Name = "DigitalPanelMeter5"
        Me.DigitalPanelMeter5.NumberOfDigits = 5
        Me.DigitalPanelMeter5.PLCAddressKeypad = ""
        Me.DigitalPanelMeter5.PLCAddressValue = "40008"
        Me.DigitalPanelMeter5.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter5.TabIndex = 72
        Me.DigitalPanelMeter5.Text = "Y CURRENT"
        Me.DigitalPanelMeter5.Value = 0R
        Me.DigitalPanelMeter5.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter5.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter4
        '
        Me.DigitalPanelMeter4.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter4.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter4.DecimalPosition = 1
        Me.DigitalPanelMeter4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter4.ForeColor = System.Drawing.Color.OrangeRed
        Me.DigitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter4.KeypadMaxValue = 0R
        Me.DigitalPanelMeter4.KeypadMinValue = 0R
        Me.DigitalPanelMeter4.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter4.KeypadText = Nothing
        Me.DigitalPanelMeter4.KeypadWidth = 300
        Me.DigitalPanelMeter4.Location = New System.Drawing.Point(45, 213)
        Me.DigitalPanelMeter4.Name = "DigitalPanelMeter4"
        Me.DigitalPanelMeter4.NumberOfDigits = 5
        Me.DigitalPanelMeter4.PLCAddressKeypad = ""
        Me.DigitalPanelMeter4.PLCAddressValue = "40007"
        Me.DigitalPanelMeter4.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter4.TabIndex = 71
        Me.DigitalPanelMeter4.Text = "R CURRENT"
        Me.DigitalPanelMeter4.Value = 0R
        Me.DigitalPanelMeter4.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter4.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter3
        '
        Me.DigitalPanelMeter3.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter3.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter3.DecimalPosition = 1
        Me.DigitalPanelMeter3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter3.ForeColor = System.Drawing.Color.Cyan
        Me.DigitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter3.KeypadMaxValue = 0R
        Me.DigitalPanelMeter3.KeypadMinValue = 0R
        Me.DigitalPanelMeter3.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter3.KeypadText = Nothing
        Me.DigitalPanelMeter3.KeypadWidth = 300
        Me.DigitalPanelMeter3.Location = New System.Drawing.Point(485, 110)
        Me.DigitalPanelMeter3.Name = "DigitalPanelMeter3"
        Me.DigitalPanelMeter3.NumberOfDigits = 5
        Me.DigitalPanelMeter3.PLCAddressKeypad = ""
        Me.DigitalPanelMeter3.PLCAddressValue = "40003"
        Me.DigitalPanelMeter3.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter3.TabIndex = 70
        Me.DigitalPanelMeter3.Text = "B VOLTAGE"
        Me.DigitalPanelMeter3.Value = 0R
        Me.DigitalPanelMeter3.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter3.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter2.DecimalPosition = 1
        Me.DigitalPanelMeter2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.DarkOrange
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(264, 110)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "40002"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter2.TabIndex = 69
        Me.DigitalPanelMeter2.Text = "Y VOLTAGE"
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.ModbusRTUCom1
        Me.DigitalPanelMeter1.DecimalPosition = 1
        Me.DigitalPanelMeter1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.DarkRed
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(45, 110)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40001"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter1.TabIndex = 68
        Me.DigitalPanelMeter1.Text = "R VOLTAGE"
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicTrendChart1
        '
        Me.BasicTrendChart1.BackColor = System.Drawing.Color.LightGray
        Me.BasicTrendChart1.ComComponent = Me.ModbusRTUCom1
        Me.BasicTrendChart1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.BasicTrendChart1.Location = New System.Drawing.Point(819, 110)
        Me.BasicTrendChart1.MaxPoints = 1000
        Me.BasicTrendChart1.Name = "BasicTrendChart1"
        Me.BasicTrendChart1.PLCAddressValue = "40013"
        Me.BasicTrendChart1.PLCAddressVisible = ""
        Me.BasicTrendChart1.Size = New System.Drawing.Size(440, 271)
        Me.BasicTrendChart1.SuppressErrorDisplay = True
        Me.BasicTrendChart1.TabIndex = 77
        Me.BasicTrendChart1.Text = "P.F"
        Me.BasicTrendChart1.Value = ""
        Me.BasicTrendChart1.YMaximum = 1500
        Me.BasicTrendChart1.YMinimum = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(61, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(451, 26)
        Me.TextBox1.TabIndex = 78
        Me.TextBox1.Text = "THG PUBLISHING MULTIFUNCTION METER DATA  LOGGER"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(264, 316)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(454, 26)
        Me.TextBox2.TabIndex = 79
        Me.TextBox2.Text = "IF P.F IS >1000 ,THEN PF= PF-1000 IT IS THE VALUE IN LEAD"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBox3.Location = New System.Drawing.Point(866, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(320, 26)
        Me.TextBox3.TabIndex = 80
        Me.TextBox3.Text = "PF LOGGING DATA, 2 SEC POLLING RATE"
        '
        'BasicDataLogger21
        '
        Me.BasicDataLogger21.ComComponent = Me.ModbusRTUCom1
        Me.BasicDataLogger21.FileFolder = "C:\Users\ADMIN\Desktop\AdvancedHMIv399xR1\DATALOG"
        Me.BasicDataLogger21.FileName = "PLCDataLog.txt"
        Me.BasicDataLogger21.LogInterval = 2000
        Me.BasicDataLogger21.LogTriggerType = AdvancedHMIControls.BasicDataLogger2.TriggerType.TimeInterval
        Me.BasicDataLogger21.MaximumPoints = 1000
        Me.BasicDataLogger21.PauseLogging = False
        Me.BasicDataLogger21.PLCAddressPauseLogging = ""
        Me.BasicDataLogger21.PLCAddressValueItems.Add(CType(resources.GetObject("BasicDataLogger21.PLCAddressValueItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.BasicDataLogger21.PollRate = 2000
        Me.BasicDataLogger21.Prefix = Nothing
        Me.BasicDataLogger21.SynchronizingObject = Me.DigitalPanelMeter9
        Me.BasicDataLogger21.TimeStampFormat = "dd-MMM-yy HH:mm:ss"
        Me.BasicDataLogger21.Value = ""
        '
        'SimpleWebServer1
        '
        Me.SimpleWebServer1.AutoStart = True
        Me.SimpleWebServer1.RefreshTime = 10
        Me.SimpleWebServer1.SourceForm = Me
        Me.SimpleWebServer1.SynchronizingObject = Me
        Me.SimpleWebServer1.TCPPort = 80
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1327, 561)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BasicTrendChart1)
        Me.Controls.Add(Me.DigitalPanelMeter9)
        Me.Controls.Add(Me.DigitalPanelMeter8)
        Me.Controls.Add(Me.DigitalPanelMeter7)
        Me.Controls.Add(Me.DigitalPanelMeter6)
        Me.Controls.Add(Me.DigitalPanelMeter5)
        Me.Controls.Add(Me.DigitalPanelMeter4)
        Me.Controls.Add(Me.DigitalPanelMeter3)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.ModbusRTUCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicDataLogger21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleWebServer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents ModbusRTUCom1 As AdvancedHMIDrivers.ModbusRTUCom
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter3 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter4 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter5 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter6 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter7 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter8 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter9 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicTrendChart1 As AdvancedHMIControls.BasicTrendChart
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BasicDataLogger21 As AdvancedHMIControls.BasicDataLogger2
    Friend WithEvents SimpleWebServer1 As AdvancedHMIControls.SimpleWebServer
End Class
