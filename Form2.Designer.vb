<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        PanelSideBar = New Panel()
        BtnPengeluaran = New Button()
        BtnPemasukan = New Button()
        BtnKamar = New Button()
        BtnPenginap = New Button()
        BtnDashboard = New Button()
        DashboardControl1 = New DashboardControl()
        PanelSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSideBar
        ' 
        PanelSideBar.BackColor = Color.WhiteSmoke
        PanelSideBar.Controls.Add(BtnPengeluaran)
        PanelSideBar.Controls.Add(BtnPemasukan)
        PanelSideBar.Controls.Add(BtnKamar)
        PanelSideBar.Controls.Add(BtnPenginap)
        PanelSideBar.Controls.Add(BtnDashboard)
        PanelSideBar.Location = New Point(0, 3)
        PanelSideBar.Name = "PanelSideBar"
        PanelSideBar.Size = New Size(200, 342)
        PanelSideBar.TabIndex = 0
        ' 
        ' BtnPengeluaran
        ' 
        BtnPengeluaran.BackColor = Color.MediumOrchid
        BtnPengeluaran.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnPengeluaran.ForeColor = Color.GhostWhite
        BtnPengeluaran.Location = New Point(0, 237)
        BtnPengeluaran.Name = "BtnPengeluaran"
        BtnPengeluaran.Size = New Size(200, 36)
        BtnPengeluaran.TabIndex = 4
        BtnPengeluaran.Text = "Pengeluaran"
        BtnPengeluaran.UseVisualStyleBackColor = False
        ' 
        ' BtnPemasukan
        ' 
        BtnPemasukan.BackColor = Color.MediumOrchid
        BtnPemasukan.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnPemasukan.ForeColor = Color.GhostWhite
        BtnPemasukan.Location = New Point(0, 195)
        BtnPemasukan.Name = "BtnPemasukan"
        BtnPemasukan.Size = New Size(200, 36)
        BtnPemasukan.TabIndex = 3
        BtnPemasukan.Text = "Pemasukan"
        BtnPemasukan.UseVisualStyleBackColor = False
        ' 
        ' BtnKamar
        ' 
        BtnKamar.BackColor = Color.MediumOrchid
        BtnKamar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnKamar.ForeColor = Color.GhostWhite
        BtnKamar.Location = New Point(0, 153)
        BtnKamar.Name = "BtnKamar"
        BtnKamar.Size = New Size(200, 36)
        BtnKamar.TabIndex = 2
        BtnKamar.Text = "Kamar"
        BtnKamar.UseVisualStyleBackColor = False
        ' 
        ' BtnPenginap
        ' 
        BtnPenginap.BackColor = Color.MediumOrchid
        BtnPenginap.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnPenginap.ForeColor = Color.GhostWhite
        BtnPenginap.Location = New Point(0, 115)
        BtnPenginap.Name = "BtnPenginap"
        BtnPenginap.Size = New Size(200, 36)
        BtnPenginap.TabIndex = 1
        BtnPenginap.Text = "Penginap"
        BtnPenginap.UseVisualStyleBackColor = False
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.BackColor = Color.MediumOrchid
        BtnDashboard.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnDashboard.ForeColor = Color.GhostWhite
        BtnDashboard.Location = New Point(0, 73)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Size = New Size(200, 36)
        BtnDashboard.TabIndex = 0
        BtnDashboard.Text = "Dashboard"
        BtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' DashboardControl1
        ' 
        DashboardControl1.Location = New Point(258, 12)
        DashboardControl1.Name = "DashboardControl1"
        DashboardControl1.Size = New Size(489, 309)
        DashboardControl1.TabIndex = 1
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumOrchid
        ClientSize = New Size(800, 450)
        Controls.Add(DashboardControl1)
        Controls.Add(PanelSideBar)
        ForeColor = Color.MediumOrchid
        Name = "Form2"
        Text = "Dashboard - Aplikasi Hotel Kelompok 7"
        WindowState = FormWindowState.Maximized
        PanelSideBar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnPenginap As Button
    Friend WithEvents BtnKamar As Button
    Friend WithEvents BtnPengeluaran As Button
    Friend WithEvents BtnPemasukan As Button
    Friend WithEvents DashboardControl1 As DashboardControl
End Class
