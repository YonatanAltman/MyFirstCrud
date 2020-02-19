Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Dim alwaysTrue = Session IsNot Nothing ' => always true
            Dim isUserLogin = Session("User") IsNot Nothing


            If isUserLogin Then
                Return View()

            End If
            Return RedirectToAction("Index", "Login")

        End Function


    End Class
End Namespace