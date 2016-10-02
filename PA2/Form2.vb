Public Class Form2

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim leave, hrs As Integer
        Dim basic, allowance, total As Double
        Dim category As String

        basic = 0
        allowance = 0
        total = 0

        category = cmbCat.SelectedItem.ToString()

        If (category = "Executive") Then


            hrs = Convert.ToInt32(txtNOH.Text) + 8 * Convert.ToInt32(txtLeave.Text)
            basic = Convert.ToDouble(txtPayrate.Text) * hrs
            allowance = basic * 0.1 + basic * 0.05
            total = basic + allowance


        End If

        If (category = "Non-Executive") Then

            Dim ot_hrs As Integer
            Dim ot_amount As Double

            ot_hrs = Convert.ToInt32(txtOT.Text)
            If (ot_hrs > 45) Then
                ot_amount = 45 * 1.5 * Convert.ToDouble(txtPayrate.Text)
            Else
                ot_amount = ot_hrs * 1.5 * Convert.ToDouble(txtPayrate.Text)

            End If


            hrs = Convert.ToInt32(txtNOH.Text) + 8 * Convert.ToInt32(txtLeave.Text)
            basic = Convert.ToDouble(txtPayrate.Text) * hrs + ot_amount
            allowance = basic * 0.05
            total = basic + allowance


        End If

        If (category = "Casual") Then



            basic = Convert.ToDouble(txtPayrate.Text) * Convert.ToInt32(txtNOH.Text)
            total = basic

        End If

        MessageBox.Show("Basic :" + FormatNumber(basic, 2) + "    Allowance :" + FormatNumber(allowance, 2) + "    Total :" + FormatNumber(total, 2))

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Visible = False
        Panel2.Visible = False

    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged



        If (cmbCat.SelectedIndex = 0 Or cmbCat.SelectedIndex = 1) Then         'hide leave days for casual workers 
            Panel1.Visible = True

        Else
            Panel1.Visible = False
        End If




        If (cmbCat.SelectedIndex = 1) Then        'show ot hrs for non-excutive workers
            Panel2.Visible = True

        Else
            Panel2.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

End Class