Module rechnen
    Public Sub gettime()
        Dim Wert As Integer
        Dim Stunden As Integer
        Dim Minuten As Integer
        Dim Sekunden As Integer
        Sekunden = Stoppuhr.Zähler
        Stunden = 0
        Minuten = 0
        Sekunden = 0
        Stoppuhr.Zeit = ""

        Sekunden = Stoppuhr.Zähler

        If Sekunden > 3600 Then
            Stunden = Stunden + 1
            Sekunden = Sekunden - 3600
        End If

        If Sekunden > 60 Then
            Minuten = Minuten + 1
            Sekunden = Sekunden - 60
        End If



        Wert = Sekunden

        'Zeitanzeige basteln

        If Stunden < 10 Then
            Stoppuhr.Zeit = Stoppuhr.Zeit + "0" + Stunden.ToString
        Else
            Stoppuhr.Zeit = Stoppuhr.Zeit + Stunden.ToString
        End If

        Stoppuhr.Zeit = Stoppuhr.Zeit + ":"

        If Minuten < 10 Then
            Stoppuhr.Zeit = Stoppuhr.Zeit + "0" + Minuten.ToString
        Else
            Stoppuhr.Zeit = Stoppuhr.Zeit + Minuten.ToString
        End If

        Stoppuhr.Zeit = Stoppuhr.Zeit + ":"

        If Sekunden < 10 Then
            Stoppuhr.Zeit = Stoppuhr.Zeit + "0" + Sekunden.ToString
        Else
            Stoppuhr.Zeit = Stoppuhr.Zeit + Sekunden.ToString
        End If

        'Stoppuhr.Zeit = Stunden.ToString + " : " + Minuten.ToString + " : " + Sekunden.ToString

    End Sub

    Sub AddMinute()

    End Sub

    Sub AddHour()

    End Sub
End Module
