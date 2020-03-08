Imports System.Net
Imports System.Web.Http




Namespace Controllers
    Public Class PetController
        Inherits ApiController

        ' GET: api/Pet
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"Maayan", "yonatan"}
        End Function

        ' GET: api/Pet/5
        Public Function GetValue(ByVal id As Integer) As Pet
            Dim allPets = GetPets()
            Dim _pet = allPets.Find(Function(pet) pet.Id = id)

            Return _pet
        End Function

        Public Function GetList(ByVal fromPrice As Integer, ByVal toPrice As Integer) As List(Of Pet)
            Dim pets = GetPets().FindAll(Function(p) p.Price >= fromPrice And p.Price <= toPrice)
            Return pets

        End Function

        ' POST: api/Pet
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Pet/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Pet/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub


        Private Function GetPets() As List(Of Pet)
            Return New List(Of Pet)() From {
                New Pet(1, "Harel", 100),
                New Pet(2, "Fish", 30),
                New Pet(3, "Lion", 12),
                New Pet(4, "Yonatan", 11),
                New Pet(5, "Cat", 1300),
                New Pet(6, "Zebra", 790)
                }




        End Function
    End Class



End Namespace