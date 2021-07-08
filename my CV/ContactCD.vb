
Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
    Dim uri = "https://www.linkedin.com/in/karachristos-e/"
    Dim psi = New ProcessStartInfo()
    psi.UseShellExecute = True
    psi.FileName = uri
    Process.Start(psi)
End Sub
