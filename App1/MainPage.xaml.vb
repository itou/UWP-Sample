' 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

Imports Windows.Storage
''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click

        Dim picker As Windows.Storage.Pickers.FileOpenPicker = New Windows.Storage.Pickers.FileOpenPicker()
        picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail
        picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.HomeGroup
        picker.FileTypeFilter.Clear()
        picker.FileTypeFilter.Add("*")

        Dim file As Windows.Storage.StorageFile = picker.PickSingleFileAsync()
        If file IsNot Nothing Then
            ' Do something with the file.
        Else
            ' No file returned. Handle the error.
        End If

    End Sub

End Class
