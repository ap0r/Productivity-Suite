<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SecondsToNextActionLabel = New System.Windows.Forms.Label()
        Me.ActionsPerHourLabel = New System.Windows.Forms.Label()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.IntervalTrackBar = New System.Windows.Forms.TrackBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ActionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.IntervalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SecondsToNextActionLabel)
        Me.GroupBox1.Controls.Add(Me.ActionsPerHourLabel)
        Me.GroupBox1.Controls.Add(Me.IntervalLabel)
        Me.GroupBox1.Controls.Add(Me.IntervalTrackBar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action Timer"
        '
        'SecondsToNextActionLabel
        '
        Me.SecondsToNextActionLabel.AutoSize = True
        Me.SecondsToNextActionLabel.Location = New System.Drawing.Point(6, 77)
        Me.SecondsToNextActionLabel.Name = "SecondsToNextActionLabel"
        Me.SecondsToNextActionLabel.Size = New System.Drawing.Size(140, 13)
        Me.SecondsToNextActionLabel.TabIndex = 5
        Me.SecondsToNextActionLabel.Text = "Seconds to next action: 360"
        '
        'ActionsPerHourLabel
        '
        Me.ActionsPerHourLabel.AutoSize = True
        Me.ActionsPerHourLabel.Location = New System.Drawing.Point(6, 64)
        Me.ActionsPerHourLabel.Name = "ActionsPerHourLabel"
        Me.ActionsPerHourLabel.Size = New System.Drawing.Size(102, 13)
        Me.ActionsPerHourLabel.TabIndex = 4
        Me.ActionsPerHourLabel.Text = "Actions per hour: 10"
        '
        'IntervalLabel
        '
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Location = New System.Drawing.Point(6, 51)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(93, 13)
        Me.IntervalLabel.TabIndex = 3
        Me.IntervalLabel.Text = "Interval: 6 minutes"
        '
        'IntervalTrackBar
        '
        Me.IntervalTrackBar.Location = New System.Drawing.Point(6, 19)
        Me.IntervalTrackBar.Maximum = 20
        Me.IntervalTrackBar.Minimum = 1
        Me.IntervalTrackBar.Name = "IntervalTrackBar"
        Me.IntervalTrackBar.Size = New System.Drawing.Size(261, 45)
        Me.IntervalTrackBar.TabIndex = 2
        Me.IntervalTrackBar.Value = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(261, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Mute"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Audio Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.RichTextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 158)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Tasks"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(215, 78)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Reload"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(215, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(202, 129)
        Me.RichTextBox4.TabIndex = 11
        Me.RichTextBox4.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox3)
        Me.GroupBox3.Controls.Add(Me.RichTextBox2)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 202)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Advanced To-do"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(425, 32)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(202, 163)
        Me.RichTextBox3.TabIndex = 10
        Me.RichTextBox3.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(217, 32)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(202, 163)
        Me.RichTextBox2.TabIndex = 9
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 33)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(202, 163)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Done"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "In progress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To Do"
        '
        'ActionTimer
        '
        Me.ActionTimer.Enabled = True
        Me.ActionTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Productivity Suite 0.1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IntervalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SecondsToNextActionLabel As Label
    Friend WithEvents ActionsPerHourLabel As Label
    Friend WithEvents IntervalLabel As Label
    Friend WithEvents IntervalTrackBar As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ActionTimer As Timer
End Class
