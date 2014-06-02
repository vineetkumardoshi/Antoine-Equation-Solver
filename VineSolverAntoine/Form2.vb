Imports System.IO

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        Dim T As Decimal



        Select Case ListBox1.SelectedIndex
            Case 0
                A = 14.3145
                B = 2756.22
                C = 228.06
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Valid Temperature Condition")
                Else

                    T = TextBox1.Text

                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -26 Or T > 77) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 247.15 and 350.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -26 and 77 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 1
                A = 15.0717
                B = 3580.8
                C = 224.65
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 24 Or T > 142) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 297.15 and 415.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 24 and 142 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 2
                A = 14.895
                B = 3413.1
                C = 250.523
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -27 Or T > 81) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 246.15 and 354.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -27 and 81 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 3
                A = 13.7819
                B = 2726.81
                C = 217.572
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 6 Or T > 104) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 279.15 and 377.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 6 and 104 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 4
                A = 13.8254
                B = 2181.79
                C = 248.87
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -83 Or T > 7) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 190.15 and 280.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -83 and 7 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 5
                A = 13.6608
                B = 2154.7
                C = 238.789
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -73 Or T > 19) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 200.15 and 292.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -73 and 19 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 6
                A = 15.3144
                B = 3212.43
                C = 182.739
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 37 Or T > 138) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 310.15 and 411.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 37 and 138 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If
            Case 7
                A = 15.1989
                B = 3026.03
                C = 186.5
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 25 Or T > 120) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 298.15 and 393.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 25 and 120 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 8
                A = 14.6047
                B = 2740.95
                C = 166.67
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 30 Or T > 128) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 303.15 and 401.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 30 and 128 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 9
                A = 14.8445
                B = 2658.29
                C = 177.65
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 10 Or T > 101) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 283.15 and 374.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 10 and 101 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 10
                A = 14.0572
                B = 2914.23
                C = 232.148
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -14 Or T > 101) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 259.15 and 374.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -14 and 101 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 11
                A = 13.8635
                B = 3174.78
                C = 211.7
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 29 Or T > 159) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 302.15 and 432.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 29 and 159 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 12
                A = 13.7965
                B = 2723.73
                C = 218.265
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -17 Or T > 79) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 256.15 and 352.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -17 and 79 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 13
                A = 13.7324
                B = 2548.74
                C = 218.552
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -23 Or T > 84) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 250.15 and 357.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -23 and 84 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 14
                A = 13.6568
                B = 2723.44
                C = 220.618
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 9 Or T > 105) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 282.15 and 378.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 9 and 105 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 15
                A = 13.9727
                B = 2653.9
                C = 234.51
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -35 Or T > 71) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 238.15 and 344.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -35 and 71 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 16
                A = 13.9748
                B = 3442.76
                C = 193.858
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 65 Or T > 203) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 338.15 and 476.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 65 and 203 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 17
                A = 13.9891
                B = 2463.93
                C = 223.24
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -38 Or T > 60) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 235.15 and 333.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -38 and 60 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 18
                A = 14.0735
                B = 2511.29
                C = 231.2
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -43 Or T > 55) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 230.15 and 328.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -43 and 55 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 19
                A = 15.0967
                B = 3579.78
                C = 240.337
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 20 Or T > 105) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 293.15 and 378.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 20 and 105 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 20
                A = 14.4575
                B = 4680.46
                C = 132.1
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 208 Or T > 379) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 481.15 and 652.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 208 and 379 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 21
                A = 16.8958
                B = 3795.17
                C = 230.918
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 3 Or T > 96) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 276.15 and 369.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 3 and 96 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 22
                A = 13.9726
                B = 3259.93
                C = 212.3
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 33 Or T > 163) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 306.15 and 436.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 33 and 163 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 23
                A = 15.7567
                B = 4187.46
                C = 178.65
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 100 Or T > 222) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 373.15 and 495.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 100 and 222 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 24
                A = 13.8622
                B = 2910.26
                C = 216.432
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 4 Or T > 123) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 277.15 and 396.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 4 and 123 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 25
                A = 13.8193
                B = 2696.04
                C = 224.317
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -19 Or T > 92) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 254.15 and 365.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -19 and 92 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 26
                A = 16.5785
                B = 3638.72
                C = 239.5
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -11 Or T > 83) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 262.15 and 356.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -11 and 83 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 27
                A = 14.2456
                B = 2662.78
                C = 219.69
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -23 Or T > 78) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 250.15 and 351.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -23 and 78 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 28
                A = 14.1334
                B = 2838.24
                C = 218.69
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -8 Or T > 103) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 265.15 and 376.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -8 and 103 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 29
                A = 14.7513
                B = 3331.7
                C = 227.6
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 56 Or T > 146) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 329.15 and 419.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 56 and 146 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 30
                A = 13.9854
                B = 3311.19
                C = 202.694
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 46 Or T > 178) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 319.15 and 451.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 46 and 178 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 31
                A = 13.6703
                B = 2896.31
                C = 220.767
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 2 Or T > 125) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 275.15 and 398.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 2 and 125 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 32
                A = 13.9346
                B = 3123.13
                C = 209.635
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 26 Or T > 152) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 299.15 and 425.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 26 and 152 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 33
                A = 13.7667
                B = 2451.88
                C = 232.014
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < -45 Or T > 58) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 228.15 and 331.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between -45 and 58 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 34
                A = 14.4387
                B = 3507.8
                C = 175.4
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 80 Or T > 208) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 353.15 and 481.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 80 and 208 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 35
                A = 16.1154
                B = 3483.67
                C = 205.807
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 20 Or T > 116) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 293.15 and 389.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 20 and 116 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 36
                A = 16.6796
                B = 3640.2
                C = 219.61
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 8 Or T > 100) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 281.15 and 373.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 8 and 100 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 37
                A = 13.932
                B = 3056.96
                C = 217.625
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 13 Or T > 136) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 286.15 and 409.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 13 and 136 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 38
                A = 16.3872
                B = 3885.7
                C = 230.17
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 0 Or T > 200) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 273.15 and 473.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 0 and 200 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 39
                A = 14.0415
                B = 3358.79
                C = 212.041
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 40 Or T > 172) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 313.15 and 445.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 40 and 172 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 40
                A = 14.1387
                B = 3381.81
                C = 216.12
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 35 Or T > 166) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 308.15 and 439.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 35 and 166 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case 41
                A = 14.0579
                B = 3331.45
                C = 214.627
                If (TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text)) Then
                    Me.TextBox1.Text = Nothing
                    MsgBox("Please Input Temperature Condition")
                Else
                    T = TextBox1.Text
                    If (RadioButton1.Checked = True) Then
                        T = TextBox1.Text - 273.15
                    End If
                    If (T < 35 Or T > 166) Then
                        Me.TextBox1.Text = Nothing
                        Me.TextBox2.Text = Nothing
                        If (RadioButton1.Checked = True) Then
                            MsgBox("Temperature Range is between 308.15 and 439.15 degree celcius")
                        Else

                            MsgBox("Temperature Range is between 35 and 166 degree celcius ")
                        End If
                    Else
                        TextBox2.Text = Math.Exp(A - (B / (T + C)))
                    End If
                End If

            Case Else
                MsgBox("Please Select From the List Box")

        End Select
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Process.Start("httP://vineetdoshi.tumblr.com")


    End Sub



    Private Sub WikipediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WikipediaToolStripMenuItem.Click
        Process.Start("http://en.wikipedia.org/wiki/Antoine_equation")
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        Dim result = MessageBox.Show(" Please follow three simple steps to use this solver. " & vbCrLf & "" & vbCrLf & "Click OK to proceed.", "How To", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        If result = vbOK Then
            MessageBox.Show("1. Click the desired compound from the given listbox on the left side. " & vbCrLf & "2. Select the Celcius or Kelvin radiobuttion and type temperature value in the text box below it." & vbCrLf & "3. Click on SOLVE button and see the output (in kiloPascals) on the Textbox which is partially overlapping the SOLVE button.", "Steps", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub InShortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Antoine Equation is a logarithmic equation with three distinct correlation constants (A, B and C) and one independent variable T (Temperature). This Equation is used to calculate saturated vapor pressure of several compounds within a fixed temperature domain." & vbCrLf & "" & vbCrLf & "      ln P = A - B/(T+C) → P = exp(A - (B / (T + C)))", "In Short", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub GoogleSeachToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Process.Start("https://www.google.co.in/search?q=antoine+equation+table&aq=f&oq=Antoi&aqs=chrome.0.59l2j57j59j60l2.1604&sourceid=chrome&ie=UTF-8#hl=en&safe=off&tbo=d&sclient=psy-ab&q=antoine+equation&oq=antoine+equation&gs_l=serp.3..0l4.2189.3313.0.3580.6.6.0.0.0.2.171.803.0j5.5.0.les%3B..0.0...1c.1.2.serp.fbgXD0XZR5c&pbx=1&bav=on.2,or.r_gc.r_pw.r_cp.r_qf.&bvm=bv.41867550,d.bmk&fp=1e89f4b496b30ae0&biw=1092&bih=541")
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox(" 2/2013 - Created by Vineet Kumar Doshi, CHEMICAL ENGG. IIT GUWAHATI " & vbCrLf & "Ref: Data for correlation constants - Introduction to Chemical Engineering Thermodynamics - J M Smith | H C Van Ness | M M Abbott" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "Conditions--This software is not for sale. Programmer is not responsible for any improper use of this software. ")

    End Sub

    Private Sub YoutubeSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoutubeSearchToolStripMenuItem.Click
        Process.Start("https://www.youtube.com/results?search_query=Antoine+Equation&oq=Antoine+Equation&gs_l=youtube.3..35i39.304131.310632.0.311272.10.9.1.0.0.0.784.2875.0j7j6-2.9.0...0.0...1ac.1.mcfyTdz5TKg")
    End Sub




End Class
