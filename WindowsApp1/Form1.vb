Public Class Form1
    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Dim nbre As String
        Dim compt As Integer
        Dim sauvegarde, supsauvegarde As Integer
        nbre = txtentrer.Text
        Dim Nbrechar = nbre.ToCharArray()
        lblresult.Text = ""
        compt = 1

        For i = Nbrechar.Length - 1 To 0 Step -1



            compt = compt + 1

            If (compt > 2) Then
                sauvegarde = Val(Nbrechar(i))
                supsauvegarde = Val(Nbrechar(i + 1))


                If (sauvegarde < supsauvegarde) Then


                    Nbrechar(i + 1) = Nbrechar(i)
                    Nbrechar(i) = CStr(supsauvegarde)


                    Exit For
                End If

            End If



        Next


        For i = 0 To Nbrechar.Length - 1

            afficher(Nbrechar(i))

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Function afficher(ByVal n As String) As String
        lblresult.Text += n
    End Function



End Class
