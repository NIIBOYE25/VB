Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnER.Click
        Dim ENGLISH, SCIENCE, SOCIAL, MATHEMATICS As Integer


        'INPUT
        ENGLISH = InputBox("Please Enter English score:")
        SCIENCE = InputBox("Please Enter Science score:")
        SOCIAL = InputBox("Please Enter Social Score:")
        MATHEMATICS = InputBox("Please Enter Mathematics score:")


        'ADDING VALUES FROM MARKS BOX TO TEXT BOX
        engbox1.Text = ENGLISH
        sciencebox3.Text = SCIENCE
        socialbox4.Text = SOCIAL
        mathsbox2.Text = MATHEMATICS



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        'Clear
        engbox1.Clear()
        mathsbox2.Clear()
        socialbox4.Clear()
        sciencebox3.Clear()

        gradeBox1.Clear()
        gradeBox2.Clear()
        gradebox3.Clear()
        gradeBox4.Clear()



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        'END

        Dim Message As String = "Are you sure you want to Exit? "
        Dim title As String = "Exit Program"
        Dim result = MessageBox.Show(Message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            End
        End If


    End Sub

    Private Sub Btncal_Click(sender As Object, e As EventArgs) Handles Btncal.Click

        'Declearatons
        Dim grade1, grade2, grade3, grade4 As String
        Dim ENGLISH, SCIENCE, SOCIAL, MATHEMATICS As Integer
        Dim D1, D2, D3, D4 As String


        ENGLISH = engbox1.Text
        SCIENCE = sciencebox3.Text
        SOCIAL = socialbox4.Text
        MATHEMATICS = mathsbox2.Text


        grade1 = gradeBox1.Text
        grade2 = gradeBox2.Text
        grade3 = gradebox3.Text
        grade4 = gradeBox4.Text

        D1 = Dbox1.Text
        D2 = Dbox2.Text
        D3 = Dbox3.Text
        D4 = Dbox4.Text

        'Calculating grade for ENGLISH

        If (ENGLISH >= 100) Then
            gradeBox1.Text = "A"
            Dbox1.Text = "EXCELLENT"

        ElseIf (ENGLISH >= 80) Then
            gradeBox1.Text = "B+"
            Dbox1.Text = "VERY GOOD"

        ElseIf (ENGLISH >= 70) Then
            gradeBox1.Text = "B"
            Dbox1.Text = "GOOD"

        ElseIf (ENGLISH >= 60) Then
            gradeBox1.Text = "C+"
            Dbox1.Text = "AVERAGE"

        ElseIf (ENGLISH >= 50) Then
            gradeBox1.Text = "C"
            Dbox1.Text = "FAIR"

        ElseIf (ENGLISH >= 40) Then
            gradeBox1.Text = "D+"
            Dbox1.Text = "BARELY SATISFACTORY"

        ElseIf (ENGLISH >= 30) Then
            gradeBox1.Text = "D"
            Dbox1.Text = "WEAK PASS"

        ElseIf (ENGLISH >= 20) Then
            gradeBox1.Text = "E"
            Dbox1.Text = "FAIL"
        End If


        'Calculating grade for MATHEMATICS

        If (MATHEMATICS >= 100) Then
            gradeBox2.Text = "A"
            Dbox2.Text = "EXCELLENT"

        ElseIf (MATHEMATICS >= 80) Then
            gradeBox2.Text = "B+"
            Dbox2.Text = "VERY GOOD"

        ElseIf (MATHEMATICS >= 70) Then
            gradeBox2.Text = "B"
            Dbox2.Text = "GOOD"

        ElseIf (MATHEMATICS >= 60) Then
            gradeBox2.Text = "C+"
            Dbox2.Text = "AVERAGE"

        ElseIf (MATHEMATICS >= 50) Then
            gradeBox2.Text = "C"
            Dbox2.Text = "FAIR"

        ElseIf (MATHEMATICS >= 40) Then
            gradeBox2.Text = "D+"
            Dbox2.Text = "BARELY SATISFACTORY"

        ElseIf (MATHEMATICS >= 30) Then
            gradeBox2.Text = "D"
            Dbox2.Text = "WEAK PASS"

        ElseIf (MATHEMATICS >= 20) Then
            gradeBox2.Text = "E"
            Dbox2.Text = "FAIL"
        End If



        'Calculating grade for SCIENCE

        If (SCIENCE >= 100) Then
            gradebox3.Text = "A"
            Dbox3.Text = "EXCELLENT"

        ElseIf (SCIENCE >= 80) Then
            gradebox3.Text = "B+"
            Dbox3.Text = "VERY GOOD"

        ElseIf (SCIENCE >= 70) Then
            gradebox3.Text = "B"
            Dbox3.Text = "GOOD"

        ElseIf (SCIENCE >= 60) Then
            gradebox3.Text = "C+"
            Dbox3.Text = "AVERAGE"

        ElseIf (SCIENCE >= 50) Then
            gradebox3.Text = "C"
            Dbox3.Text = "FAIR"

        ElseIf (SCIENCE >= 40) Then
            gradebox3.Text = "D+"
            Dbox3.Text = "BARELY SATISFACTORY"

        ElseIf (SCIENCE >= 30) Then
            gradebox3.Text = "D"
            Dbox3.Text = "WEAK PASS"

        ElseIf (SCIENCE >= 20) Then
            gradebox3.Text = "E"
            Dbox3.Text = "FAIL"

        End If



        'Calculating grade for SOCIAL

        If (SOCIAL >= 100) Then
            gradeBox4.Text = "A"
            Dbox4.Text = "EXCELLENT"

        ElseIf (SOCIAL >= 80) Then
            gradeBox4.Text = "B+"
            Dbox4.Text = "VERY GOOD"

        ElseIf (SOCIAL >= 70) Then
            gradeBox4.Text = "B"
            Dbox4.Text = "GOOD"

        ElseIf (SOCIAL >= 60) Then
            gradeBox4.Text = "C+"
            Dbox4.Text = "AVERAGE"

        ElseIf (SOCIAL >= 50) Then
            gradeBox4.Text = "C"
            Dbox4.Text = "FAIR"

        ElseIf (SOCIAL >= 40) Then
            gradeBox4.Text = "D+"
            Dbox4.Text = "BARELY SATISFACTORY"

        ElseIf (SOCIAL >= 30) Then
            gradeBox4.Text = "D"
            Dbox4.Text = "WEAK PASS"

        ElseIf (SOCIAL >= 20) Then
            gradeBox4.Text = "E"
            Dbox4.Text = "FAIL"
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Message As String = "Are you sure you want to close? "
        Dim title As String = "Close Program"
        Dim result = MessageBox.Show(Message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub
End Class
