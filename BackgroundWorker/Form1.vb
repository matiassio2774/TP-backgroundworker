
Imports System.dll
    Public Class Form1
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BackgroundWorker1.RunWorkerAsync()
        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim i As Integer

            For i = 1 To 1000
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.ReportProgress(i / 10)

                Threading.Thread.Sleep(500)

            Next

        End Sub

        Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

            ProgressBar1.Value = e.ProgressPercentage

        End Sub



        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            MsgBox("listo")

        End Sub
    End Class

