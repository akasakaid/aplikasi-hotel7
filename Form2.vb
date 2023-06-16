Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TinggiWindow = Me.ClientSize.Height
        Dim PanjangWindow = Me.ClientSize.Width

        PanelSideBar.Height = PanjangWindow
        PanelSideBar.Width = 200

        BtnDashboard.Width = 200
        BtnPenginap.Width = 200
        BtnKamar.Width = 200
        BtnPemasukan.Width = 200
        BtnPengeluaran.Width = 200

        Dim DashboardController As New DashboardControl()
        Me.Controls.Add(DashboardController)
        DashboardController.Size = New Size((PanjangWindow - PanelSideBar.Width) - 10, (TinggiWindow - 10))
        DashboardController.Location = New Point()
        DashboardController.Visible = True
    End Sub
End Class