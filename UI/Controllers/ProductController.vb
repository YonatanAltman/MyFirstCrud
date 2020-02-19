Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult


            SessionManager.Counter = SessionManager.Counter + 1

            Dim counter = SessionManager.Counter




            Dim friends = SessionManager.FriendVMList

            Dim manager = New ProductManager()

            Dim products = manager.GetAll()

            Return View(products)
        End Function
        <HttpGet>
        Function Edit(id As String) As ActionResult
            Dim manager = New ProductManager()
            Dim product = manager.GetProduct(id)

            Return View(product)
        End Function
        <HttpPost>
        Function Edit(collection As FormCollection) As ActionResult



            Dim manager = New ProductManager()
            Dim id = collection("CatalogID")
            Dim product = manager.GetProduct(id)
            product.Name = collection("Name")
            manager.UpdateProduct(product)
            Return RedirectToAction("Index")
        End Function





        Function List() As ActionResult
            Dim manager = New ProductManager
            Dim products = manager.GetAll()
            Return View(products)


        End Function
    End Class
End Namespace