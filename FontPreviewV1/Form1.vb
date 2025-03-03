Imports System.Drawing.Text
Imports System.Windows.Forms

Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Set cursor to busy
        Me.Cursor = Cursors.WaitCursor

        ' Clear previous entries
        flowPanel.Controls.Clear()
        flowPanel.FlowDirection = FlowDirection.TopDown ' Ensure vertical stacking
        flowPanel.WrapContents = False

        ' Get user text
        Dim userText As String = txtInput.Text
        Dim fonts As New InstalledFontCollection()

        ' Get user-defined font size (with error handling)
        Dim fontSizeUser As Integer
        If Not Integer.TryParse(txtSize.Text, fontSizeUser) OrElse fontSizeUser <= 0 Then
            fontSizeUser = 18 ' Default to 18 if input is invalid
            txtSize.Text = 18
        End If

        For Each fontFamily As FontFamily In fonts.Families
            ' Create a panel to contain the sample and font name
            Dim rowPanel As New Panel()
            rowPanel.AutoSize = True
            rowPanel.Dock = DockStyle.Top ' Ensures each entry is on a new line

            ' Label for sample text
            Dim lblSample As New Label()
            lblSample.AutoSize = True
            lblSample.Text = userText & " "
            Try
                lblSample.Font = New Font(fontFamily, fontSizeUser)
            Catch ex As Exception
                lblSample.Font = New Font("Arial", fontSizeUser) ' Fallback font
            End Try

            ' Label for font name
            Dim lblFontName As New Label()
            lblFontName.AutoSize = True
            lblFontName.Text = fontFamily.Name
            lblFontName.Font = New Font("Calibri", fontSizeUser, FontStyle.Bold)
            lblFontName.ForeColor = Color.DarkBlue

            ' Add both labels to the row panel
            rowPanel.Controls.Add(lblSample)
            rowPanel.Controls.Add(lblFontName)

            ' Align labels in a single row
            lblSample.Location = New Point(0, 5)
            lblFontName.Location = New Point(lblSample.Width + 10, 5)

            ' Add row to main scrollable panel
            flowPanel.Controls.Add(rowPanel)
        Next

        ' Restore normal cursor
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub txtSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSize.KeyPress
        ' Allow only numbers, backspace, and delete
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block invalid input
        End If
    End Sub
    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown, txtSize.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True ' Prevents the beep sound when pressing Enter
                btnDisplay_Click(sender, e) ' Calls the button click event
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlwaysOnTop.CheckedChanged
        If chkAlwaysOnTop.Checked Then
            Me.TopMost = True ' Keep window always on top
        Else
            Me.TopMost = False ' Allow other windows to be on top
        End If
    End Sub

End Class
