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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpVehicle = New System.Windows.Forms.GroupBox()
        Me.radBatmobile = New System.Windows.Forms.RadioButton()
        Me.radHerbie = New System.Windows.Forms.RadioButton()
        Me.radMysteryMachine = New System.Windows.Forms.RadioButton()
        Me.txtRentalDays = New System.Windows.Forms.TextBox()
        Me.chkPrepayGas = New System.Windows.Forms.CheckBox()
        Me.btnCalculatePrice = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRentalDays = New System.Windows.Forms.Label()
        Me.lblOutputTotal = New System.Windows.Forms.Label()
        Me.lblCostPerDay = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.lblGasIfPrepaid = New System.Windows.Forms.Label()
        Me.lblCostPerDayOutput = New System.Windows.Forms.Label()
        Me.lblNumberOfDaysOutput = New System.Windows.Forms.Label()
        Me.lblGasIfPrepaidOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpVehicle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpVehicle
        '
        Me.grpVehicle.Controls.Add(Me.radBatmobile)
        Me.grpVehicle.Controls.Add(Me.radHerbie)
        Me.grpVehicle.Controls.Add(Me.radMysteryMachine)
        Me.grpVehicle.Location = New System.Drawing.Point(12, 26)
        Me.grpVehicle.Name = "grpVehicle"
        Me.grpVehicle.Size = New System.Drawing.Size(160, 88)
        Me.grpVehicle.TabIndex = 0
        Me.grpVehicle.TabStop = False
        Me.grpVehicle.Text = "Vehicle Choice"
        '
        'radBatmobile
        '
        Me.radBatmobile.AutoSize = True
        Me.radBatmobile.Location = New System.Drawing.Point(15, 65)
        Me.radBatmobile.Name = "radBatmobile"
        Me.radBatmobile.Size = New System.Drawing.Size(71, 17)
        Me.radBatmobile.TabIndex = 2
        Me.radBatmobile.TabStop = True
        Me.radBatmobile.Text = "Batmobile"
        Me.radBatmobile.UseVisualStyleBackColor = True
        '
        'radHerbie
        '
        Me.radHerbie.AutoSize = True
        Me.radHerbie.Location = New System.Drawing.Point(15, 42)
        Me.radHerbie.Name = "radHerbie"
        Me.radHerbie.Size = New System.Drawing.Size(123, 17)
        Me.radHerbie.TabIndex = 1
        Me.radHerbie.TabStop = True
        Me.radHerbie.Text = "Herbie the Love Bug"
        Me.radHerbie.UseVisualStyleBackColor = True
        '
        'radMysteryMachine
        '
        Me.radMysteryMachine.AutoSize = True
        Me.radMysteryMachine.Location = New System.Drawing.Point(15, 19)
        Me.radMysteryMachine.Name = "radMysteryMachine"
        Me.radMysteryMachine.Size = New System.Drawing.Size(105, 17)
        Me.radMysteryMachine.TabIndex = 0
        Me.radMysteryMachine.TabStop = True
        Me.radMysteryMachine.Text = "Mystery Machine"
        Me.radMysteryMachine.UseVisualStyleBackColor = True
        '
        'txtRentalDays
        '
        Me.txtRentalDays.Location = New System.Drawing.Point(119, 120)
        Me.txtRentalDays.Name = "txtRentalDays"
        Me.txtRentalDays.Size = New System.Drawing.Size(31, 20)
        Me.txtRentalDays.TabIndex = 1
        '
        'chkPrepayGas
        '
        Me.chkPrepayGas.AutoSize = True
        Me.chkPrepayGas.Location = New System.Drawing.Point(15, 162)
        Me.chkPrepayGas.Name = "chkPrepayGas"
        Me.chkPrepayGas.Size = New System.Drawing.Size(160, 17)
        Me.chkPrepayGas.TabIndex = 2
        Me.chkPrepayGas.Text = "Prepay to refill gas at return?"
        Me.chkPrepayGas.UseVisualStyleBackColor = True
        '
        'btnCalculatePrice
        '
        Me.btnCalculatePrice.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalculatePrice.Location = New System.Drawing.Point(15, 186)
        Me.btnCalculatePrice.Name = "btnCalculatePrice"
        Me.btnCalculatePrice.Size = New System.Drawing.Size(158, 49)
        Me.btnCalculatePrice.TabIndex = 3
        Me.btnCalculatePrice.Text = "&Calculate Price"
        Me.btnCalculatePrice.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(193, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblRentalDays
        '
        Me.lblRentalDays.AutoSize = True
        Me.lblRentalDays.Location = New System.Drawing.Point(12, 123)
        Me.lblRentalDays.Name = "lblRentalDays"
        Me.lblRentalDays.Size = New System.Drawing.Size(93, 13)
        Me.lblRentalDays.TabIndex = 6
        Me.lblRentalDays.Text = "Rental days? (1-3)"
        '
        'lblOutputTotal
        '
        Me.lblOutputTotal.AutoSize = True
        Me.lblOutputTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTotal.Location = New System.Drawing.Point(190, 222)
        Me.lblOutputTotal.Name = "lblOutputTotal"
        Me.lblOutputTotal.Size = New System.Drawing.Size(69, 13)
        Me.lblOutputTotal.TabIndex = 7
        Me.lblOutputTotal.Text = "Total Cost:"
        '
        'lblCostPerDay
        '
        Me.lblCostPerDay.AutoSize = True
        Me.lblCostPerDay.Location = New System.Drawing.Point(191, 153)
        Me.lblCostPerDay.Name = "lblCostPerDay"
        Me.lblCostPerDay.Size = New System.Drawing.Size(69, 13)
        Me.lblCostPerDay.TabIndex = 8
        Me.lblCostPerDay.Text = "Cost per day:"
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Location = New System.Drawing.Point(191, 175)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(84, 13)
        Me.lblNumberOfDays.TabIndex = 9
        Me.lblNumberOfDays.Text = "Number of days:"
        '
        'lblGasIfPrepaid
        '
        Me.lblGasIfPrepaid.AutoSize = True
        Me.lblGasIfPrepaid.Location = New System.Drawing.Point(191, 198)
        Me.lblGasIfPrepaid.Name = "lblGasIfPrepaid"
        Me.lblGasIfPrepaid.Size = New System.Drawing.Size(81, 13)
        Me.lblGasIfPrepaid.TabIndex = 10
        Me.lblGasIfPrepaid.Text = "Gas (if prepaid):"
        '
        'lblCostPerDayOutput
        '
        Me.lblCostPerDayOutput.AutoSize = True
        Me.lblCostPerDayOutput.Location = New System.Drawing.Point(289, 153)
        Me.lblCostPerDayOutput.Name = "lblCostPerDayOutput"
        Me.lblCostPerDayOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblCostPerDayOutput.TabIndex = 11
        '
        'lblNumberOfDaysOutput
        '
        Me.lblNumberOfDaysOutput.AutoSize = True
        Me.lblNumberOfDaysOutput.Location = New System.Drawing.Point(289, 175)
        Me.lblNumberOfDaysOutput.Name = "lblNumberOfDaysOutput"
        Me.lblNumberOfDaysOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfDaysOutput.TabIndex = 12
        '
        'lblGasIfPrepaidOutput
        '
        Me.lblGasIfPrepaidOutput.AutoSize = True
        Me.lblGasIfPrepaidOutput.Location = New System.Drawing.Point(289, 198)
        Me.lblGasIfPrepaidOutput.Name = "lblGasIfPrepaidOutput"
        Me.lblGasIfPrepaidOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblGasIfPrepaidOutput.TabIndex = 13
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.AutoSize = True
        Me.lblTotalOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOutput.Location = New System.Drawing.Point(289, 222)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalOutput.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(15, 241)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(157, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "&Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculatePrice
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 283)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblGasIfPrepaidOutput)
        Me.Controls.Add(Me.lblNumberOfDaysOutput)
        Me.Controls.Add(Me.lblCostPerDayOutput)
        Me.Controls.Add(Me.lblGasIfPrepaid)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblCostPerDay)
        Me.Controls.Add(Me.lblOutputTotal)
        Me.Controls.Add(Me.lblRentalDays)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalculatePrice)
        Me.Controls.Add(Me.chkPrepayGas)
        Me.Controls.Add(Me.txtRentalDays)
        Me.Controls.Add(Me.grpVehicle)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Vehicle Rental"
        Me.grpVehicle.ResumeLayout(False)
        Me.grpVehicle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpVehicle As GroupBox
    Friend WithEvents radBatmobile As RadioButton
    Friend WithEvents radHerbie As RadioButton
    Friend WithEvents radMysteryMachine As RadioButton
    Friend WithEvents txtRentalDays As TextBox
    Friend WithEvents chkPrepayGas As CheckBox
    Friend WithEvents btnCalculatePrice As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRentalDays As Label
    Friend WithEvents lblOutputTotal As Label
    Friend WithEvents lblCostPerDay As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents lblGasIfPrepaid As Label
    Friend WithEvents lblCostPerDayOutput As Label
    Friend WithEvents lblNumberOfDaysOutput As Label
    Friend WithEvents lblGasIfPrepaidOutput As Label
    Friend WithEvents lblTotalOutput As Label
    Friend WithEvents btnClear As Button
End Class
