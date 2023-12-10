Public Class Form1
    Private grafo As New Grafo()


    Private Sub ActualizarListBox()
        listGrafo.Items.Clear()

        For Each vertice In grafo.ObtenerVertices()
            listGrafo.Items.Add($"Vértice: {vertice}")
            For Each vecino In grafo.ObtenerVecinos(vertice)
                listGrafo.Items.Add($"  -> Vecino: {vecino}")
            Next
        Next
    End Sub

    Private Sub btnAgregarVertice_Click_1(sender As Object, e As EventArgs) Handles btnAgregarVertice.Click
        Dim vertice As Integer

        If Not String.IsNullOrWhiteSpace(txtVertice.Text) AndAlso Integer.TryParse(txtVertice.Text, vertice) Then
            grafo.AgregarVertice(vertice)
            ActualizarListBox()
        Else
            MessageBox.Show("Ingrese un número válido para el vértice.")
        End If

        txtVertice.Clear()
    End Sub

    Private Sub btnAgregarArista_Click_1(sender As Object, e As EventArgs) Handles btnAgregarArista.Click
        Dim origen, destino As Integer

        If Integer.TryParse(txtOrigen.Text, origen) AndAlso Integer.TryParse(txtDestino.Text, destino) Then
            grafo.AgregarArista(origen, destino)
            ActualizarListBox()
        Else
            MessageBox.Show("Ingrese números válidos para el origen y destino de la arista.")
        End If

        txtOrigen.Clear()
        txtDestino.Clear()
    End Sub

    Private Sub btnEliminarVertice_Click_1(sender As Object, e As EventArgs) Handles btnEliminarVertice.Click
        Dim vertice As Integer = Nothing

        If listGrafo.SelectedItem IsNot Nothing Then
            Dim partes As String() = listGrafo.SelectedItem.ToString().Split(":"c)

            If partes.Length >= 2 AndAlso Integer.TryParse(partes(1).Trim(), vertice) Then
                grafo.EliminarVertice(vertice)
                ActualizarListBox()
            Else
                MessageBox.Show("Error al extraer el vértice seleccionado.")
            End If
        Else
            MessageBox.Show("Seleccione un vértice para eliminar.")
        End If
    End Sub

    Private Sub btnEncontrarCamino_Click(sender As Object, e As EventArgs) Handles btnEncontrarCamino.Click
        Dim origen, destino As Integer

        If Integer.TryParse(txtOrigen.Text, origen) AndAlso Integer.TryParse(txtDestino.Text, destino) Then
            ' Llama al método DFS para encontrar el camino y obtén el resultado
            Dim camino As List(Of Integer) = grafo.DFS(origen, destino)

            If camino.Count > 0 Then
                Dim caminoStr As String = String.Join(" -> ", camino)
                MessageBox.Show($"Camino encontrado: {caminoStr}")
            Else
                MessageBox.Show($"No se encontró un camino desde el vértice {origen} hasta el vértice {destino}.")
            End If
        Else
            MessageBox.Show("Ingrese números válidos para el origen y destino del camino.")
        End If

        ' Limpia los cuadros de texto después de la búsqueda
        txtOrigen.Clear()
        txtDestino.Clear()
    End Sub
End Class
