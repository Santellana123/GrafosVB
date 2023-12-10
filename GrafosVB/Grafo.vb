Public Class Grafo
    Private grafo As New Dictionary(Of Integer, List(Of Integer))()

    Public Sub AgregarVertice(vertice As Integer)
        If Not grafo.ContainsKey(vertice) Then
            grafo(vertice) = New List(Of Integer)()
        End If
    End Sub

    Public Sub AgregarArista(origen As Integer, destino As Integer)
        If grafo.ContainsKey(origen) AndAlso grafo.ContainsKey(destino) Then
            grafo(origen).Add(destino)
        End If
    End Sub

    Public Function ObtenerVecinos(vertice As Integer) As IEnumerable(Of Integer)
        If grafo.ContainsKey(vertice) Then
            Return grafo(vertice)
        Else
            Return Enumerable.Empty(Of Integer)()
        End If
    End Function

    Public Function ObtenerVertices() As IEnumerable(Of Integer)
        Return grafo.Keys
    End Function

    Public Sub EliminarVertice(vertice As Integer)
        If grafo.ContainsKey(vertice) Then
            grafo.Remove(vertice)

            For Each key As Integer In grafo.Keys
                grafo(key).Remove(vertice)
            Next
        End If
    End Sub

    Public Function DFS(origen As Integer, objetivo As Integer) As List(Of Integer)
        Dim stack As New Stack(Of Integer)()
        Dim padres As New Dictionary(Of Integer, Integer)()

        stack.Push(origen)
        padres(origen) = -1

        While stack.Count > 0
            Dim nodoActual As Integer = stack.Pop()

            If nodoActual = objetivo Then
                Dim camino As List(Of Integer) = ConstruirCamino(padres, objetivo)
                Return camino
            End If

            For Each vecino As Integer In grafo(nodoActual)
                If Not padres.ContainsKey(vecino) Then
                    stack.Push(vecino)
                    padres(vecino) = nodoActual
                End If
            Next
        End While

        Return New List(Of Integer)()
    End Function

    Private Function ConstruirCamino(padres As Dictionary(Of Integer, Integer), objetivo As Integer) As List(Of Integer)
        Dim camino As New List(Of Integer)()

        Dim actual As Integer = objetivo
        While actual <> -1
            camino.Insert(0, actual)
            actual = padres(actual)
        End While

        Return camino
    End Function
End Class
