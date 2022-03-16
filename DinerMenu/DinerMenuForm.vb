'Jamison Burton
'RCET0265
'Spring 2022
'Diner Menu Program
'https://github.com/Reimonoe17/DinerMenu

Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "Soup of the Day" & vbNewLine & vbNewLine & "Potatoe Leek Soup" & vbNewLine & "This savory, creamy soup has a hint of thyme and is topped with bacon and fresh chives"
    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "Salad Special" & vbNewLine & vbNewLine & "Forest Salad" & vbNewLine & "Dressed with a citrus vinegrette, this salad consists of brussel sprouts, radicchio, chives, pansies, and nasturtium flowers"
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "Catch of the Day" & vbNewLine & vbNewLine & "Pan-fried Rainbow Trout" & vbNewLine & "Fresh trout fillet breaded and served with shallots, parsley, lemon, and tartar sause"
    End Sub

End Class
