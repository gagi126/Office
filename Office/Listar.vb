Imports System.IO
Imports ExcelApp = Microsoft.Office.Interop.Excel
Public Class Listar
    Dim Archivo As FileStream
    Dim Grabar As StreamWriter
    Dim Leer As StreamReader
    Dim suma As Integer = 0
    Private Sub Listar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lvmeds.Columns.Count = 7 Then
        Else
            lvmeds.Columns.Add("Codigo")
            lvmeds.Columns.Add("Medicamento")
            lvmeds.Columns.Add("F.Elaboracion")
            lvmeds.Columns.Add("Laboratorio")
            lvmeds.Columns.Add("Formato")
            lvmeds.Columns.Add("Con Descuento")
            lvmeds.Columns.Add("Precio")
        End If
        lvmeds.View = View.Details
        Me.CenterToScreen()
        CMBLabs.Items.Add("POET")
        CMBLabs.Items.Add("BAYER")
        CMBLabs.Items.Add("BAGO")
        CMBLabs.Items.Add("GSK")
        CMBLabs.Items.Add("ECLEIR")
        CMBLabs.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        lvmeds.Items.Clear()
        If File.Exists("Medica.txt") Then
            Archivo = New FileStream("Medica.txt", FileMode.Open)
            Leer = New StreamReader(Archivo)
            Dim existe As Boolean = False
            While Not (Leer.EndOfStream)
                Dim resultado() As String = Leer.ReadLine().Split("|")
                If resultado(3) = CMBLabs.Text Then
                    existe = True
                    lvmeds.Items.Add(resultado(0))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(1))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(2))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(3))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(4))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(5))
                    lvmeds.Items(lvmeds.Items.Count - 1).SubItems.Add(resultado(6))
                End If
            End While
            If existe = True Then
            Else
                MessageBox.Show("El laboratorio no tiene medicamentos cargados")
            End If
            Leer.Close()
            Archivo.Close()
        End If
    End Sub

    Private Sub BTNExportar_Click(sender As Object, e As EventArgs) Handles BTNExportar.Click
        If lvmeds.Items.Count = 0 Then
            MessageBox.Show("No hay nada para exportar")
        Else
            Exportar()
        End If
    End Sub

    Private Sub Exportar()
        Dim excel As ExcelApp.Application
        Dim libro As ExcelApp.Workbook
        Dim hoja As ExcelApp.Worksheet
        Dim aux As Integer
        Dim filexcel As Integer = 2
        excel = New ExcelApp.Application
        libro = excel.Workbooks.Add()
        hoja = libro.Worksheets.Add()
        hoja.Range("A1").Value = "Codigo"
        hoja.Range("B1").Value = "Medicamento"
        hoja.Range("C1").Value = "F.Elaboracion"
        hoja.Range("D1").Value = "laboratorio"
        hoja.Range("E1").Value = "Formato"
        hoja.Range("F1").Value = "Con descuento"
        hoja.Range("G1").Value = "Precio"
        For aux = 0 To lvmeds.Items.Count - 1
            hoja.Range("A" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(0).Text
            hoja.Range("B" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(1).Text
            hoja.Range("C" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(2).Text
            hoja.Range("D" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(3).Text
            hoja.Range("E" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(4).Text
            hoja.Range("F" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(5).Text
            hoja.Range("G" + filexcel.ToString).Value = lvmeds.Items(aux).SubItems(6).Text
            filexcel += 1
        Next
        libro.SaveAs("Listado.xlsx")
        MessageBox.Show("Archivo generado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        libro.Close()
        excel.Quit()
    End Sub
End Class