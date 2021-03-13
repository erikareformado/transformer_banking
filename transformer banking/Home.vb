Imports System.IO
Public Class Home

    'Public uc_delta_wye_desc As New DeltaWyeDesciption
    Public uc_wye_wye_activity As New WyeWyeActivities
    Public uc_delta_wye_activity As New DeltaWyeActivity
    Public uc_delta_delta_activity As New DeltaDeltaActivity
    Public uc_wye_delta_activity As New WyeDeltaActivity
    Public uc_open_delta_activity As New OpenDeltaActivity
    Public uc_open_wye_open_delta_activity As New OpenwyeOpendeltaActivity

    Public uc_exercises As New Exercise


    Public uc_wye_wye_intro As New wye_wye_introduction
    Public uc_delta_wye_intro As New delta_wye_introduction
    Public uc_delta_delta_intro As New delta_delta_introduction
    Public uc_wye_delta_intro As New wye_delta_introduction
    Public uc_open_delta_intro As New open_delta_introduction
    Public uc_openwye_opendelta_intro As New open_wye_open_delta_introduction

    Public uc_test As New Test
    Public uc_transformer_details As New tranformer_Details

    Public action As String
    Public exan_no As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_all.Controls.Clear()
        'panel_all.Controls.Add(uc_introduction)


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        overview.Show()
    End Sub

    Private Sub picturebox_minimize_Click(sender As Object, e As EventArgs) Handles picturebox_minimize.Click
        minimize(Me)
    End Sub

    Private Sub picturebox_close_Click(sender As Object, e As EventArgs) Handles picturebox_close.Click
        Me.Close()
    End Sub

    Private Sub panel_all_Paint(sender As Object, e As PaintEventArgs) Handles panel_all.Paint

    End Sub


End Class
