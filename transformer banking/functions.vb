Module functions

    Public Sub minimize(form)
        form.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub close_form()
        'form.Close()
        Application.Exit()
    End Sub
End Module
