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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btOk = New System.Windows.Forms.Button()
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(107, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ตารางสูตรคูณ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btOk
        '
        Me.btOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btOk.Location = New System.Drawing.Point(80, 343)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(120, 57)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "ตกลง"
        Me.btOk.UseVisualStyleBackColor = False
        '
        'tbNum
        '
        Me.tbNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNum.Location = New System.Drawing.Point(379, 212)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(185, 27)
        Me.tbNum.TabIndex = 2
        '
        'btClear
        '
        Me.btClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btClear.Location = New System.Drawing.Point(273, 343)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(122, 57)
        Me.btClear.TabIndex = 1
        Me.btClear.Text = "ยกเลิก"
        Me.btClear.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Red
        Me.btExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btExit.Location = New System.Drawing.Point(463, 343)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(127, 57)
        Me.btExit.TabIndex = 1
        Me.btExit.Text = "จบการทำงาน"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(107, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 63)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ใส่ตัวเลข"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(701, 494)
        Me.Controls.Add(Me.tbNum)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btOk As Button
    Friend WithEvents tbNum As TextBox
    Friend WithEvents btClear As Button
    Friend WithEvents btExit As Button
    Friend WithEvents Label2 As Label
End Class
