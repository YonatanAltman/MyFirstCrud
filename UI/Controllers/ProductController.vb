Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult
            Dim manager = New ProductManager()

            Dim products = manager.GetAll()

            Return View(products)
        End Function
    End Class
End Namespace