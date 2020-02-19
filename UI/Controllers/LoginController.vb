Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult

            Dim alwaysTrue = Session IsNot Nothing ' => always true
            Dim isUserLogin = Session("User") IsNot Nothing


            If isUserLogin Then
                Return RedirectToAction("Index", "Home")

            End If
            Return View()
        End Function

        ' POST: Login/Create
        <HttpPost()>
        Function Index(ByVal collection As FormCollection) As ActionResult
            Try
                Dim user = New UserVM(collection)

                ' check user to DB
                Session("User") = user

                Dim isUserLogin = Session("User") IsNot Nothing

                If isUserLogin Then
                    Return RedirectToAction("Index", "Home")

                End If
                Return View("Index")
            Catch
                Return View("Index")
            End Try
        End Function


    End Class
End Namespace