<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        TxtName = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.AutoSize = True
        TxtName.BackColor = Color.Transparent
        TxtName.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.ForeColor = SystemColors.ActiveCaptionText
        TxtName.Location = New Point(119, 104)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(56, 18)
        TxtName.TabIndex = 4
        TxtName.Text = "Label3"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumOrchid
        GroupBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(119, 275)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Reservasi Hari Ini"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MediumOrchid
        GroupBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.WhiteSmoke
        GroupBox2.Location = New Point(321, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Total Reservasi Minggu Ini"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.MediumOrchid
        GroupBox3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.WhiteSmoke
        GroupBox3.Location = New Point(553, 139)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 100)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Total Reservasi Bulan Ini"
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TxtName)
        ForeColor = SystemColors.ButtonHighlight
        Name = "DashboardControl"
        Size = New Size(798, 407)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TxtName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
