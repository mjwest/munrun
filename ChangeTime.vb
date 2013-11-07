Imports System.Windows.Forms

Public Class ChangeTime
    Dim nonNumberEntered As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckNonNumber(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudCT.KeyDown
        ' Handle the KeyDown event to determine the type of character entered into the control.

        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        ' Outside D0 to D9; or, from top of keyboard, but Shift pressed.
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 OrElse e.Shift = True Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub HandleNonNumber(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudCT.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If

    End Sub
End Class
