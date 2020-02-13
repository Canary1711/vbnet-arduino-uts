Public Class Form1
    Dim lamp As Boolean = False
    Dim lamp2 As Boolean = False
    Dim dapurLamp As Boolean = False
    Dim tamuLamp As Boolean = False
    Dim mandiLamp As Boolean = False
    Dim lampTiles(4) As MetroFramework.Controls.MetroTile
    Dim boolLamp(4) As Boolean
    Dim allLamp As Boolean = False
    Dim win As Boolean = False
    Dim door As Boolean = False

    Private Sub lampKamar2_Click(sender As Object, e As EventArgs) Handles lampKamar2.Click
        If lamp2 = True Then
            lampKamar2.Style = MetroFramework.MetroColorStyle.Orange
            lamp2 = False
        Else
            lampKamar2.Style = MetroFramework.MetroColorStyle.Default
            lamp2 = True
        End If
        lampKamar2.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lampTiles = New MetroFramework.Controls.MetroTile() {lampKamar, lampKamar2, lampDapur, lampMandi, lampTamu}
        boolLamp = New Boolean() {lamp, lamp2, dapurLamp, mandiLamp, tamuLamp}
        For i = 0 To 4
            lampTiles(i).Style = MetroFramework.MetroColorStyle.Orange
        Next
    End Sub

    Private Sub btnAllLamp_Click(sender As Object, e As EventArgs) Handles btnAllLamp.Click
        If allLamp = True Then
            For i As Integer = 0 To 4
                If boolLamp(i) = True Then
                    lampTiles(i).Style = MetroFramework.MetroColorStyle.Orange
                    lampTiles(i).Refresh()
                    boolLamp(i) = False
                Else
                    lampTiles(i).Style = MetroFramework.MetroColorStyle.Orange
                    lampTiles(i).Refresh()
                End If
            Next
            allLamp = False
        Else
            For i As Integer = 0 To 4
                If boolLamp(i) = False Then
                    lampTiles(i).Style = MetroFramework.MetroColorStyle.Default
                    lampTiles(i).Refresh()
                    boolLamp(i) = True
                Else
                    lampTiles(i).Style = MetroFramework.MetroColorStyle.Default
                    lampTiles(i).Refresh()
                End If
            Next
            allLamp = True
        End If
    End Sub

    Private Sub lampKamar_Click(sender As Object, e As EventArgs) Handles lampKamar.Click
        If lamp = True Then
            lampKamar.Style = MetroFramework.MetroColorStyle.Orange
            lamp = False
        Else
            lampKamar.Style = MetroFramework.MetroColorStyle.Default
            lamp = True
        End If
        lampKamar.Refresh()
    End Sub

    Private Sub lampDapur_Click(sender As Object, e As EventArgs) Handles lampDapur.Click
        If dapurLamp = True Then
            lampDapur.Style = MetroFramework.MetroColorStyle.Orange
            dapurLamp = False
        Else
            lampDapur.Style = MetroFramework.MetroColorStyle.Default
            dapurLamp = True
        End If
        lampDapur.Refresh()
    End Sub

    Private Sub lampMandi_Click(sender As Object, e As EventArgs) Handles lampMandi.Click
        If mandiLamp = True Then
            lampMandi.Style = MetroFramework.MetroColorStyle.Orange
            mandiLamp = False
        Else
            lampMandi.Style = MetroFramework.MetroColorStyle.Default
            mandiLamp = True
        End If
        lampMandi.Refresh()
    End Sub

    Private Sub lampTamu_Click(sender As Object, e As EventArgs) Handles lampTamu.Click
        If tamuLamp = True Then
            lampTamu.Style = MetroFramework.MetroColorStyle.Orange
            tamuLamp = False
        Else
            lampTamu.Style = MetroFramework.MetroColorStyle.Default
            tamuLamp = True
        End If
        lampTamu.Refresh()
    End Sub

    Private Sub btnWindow_Click(sender As Object, e As EventArgs) Handles btnWindow.Click
        If win = True Then
            btnWindow.Text = "Close"
            btnWindow.Refresh()
            win = False
        Else
            btnWindow.Text = "Open"
            btnWindow.Refresh()
            win = True
        End If
    End Sub

    Private Sub btnCurt_Click(sender As Object, e As EventArgs) Handles btnDoor.Click
        If door = True Then
            btnDoor.Text = "Close"
            btnDoor.Refresh()
            door = False
        Else
            btnDoor.Text = "Open"
            btnDoor.Refresh()
            door = True
        End If
    End Sub
End Class
