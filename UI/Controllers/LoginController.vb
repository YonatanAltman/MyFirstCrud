Imports System.Web.Mvc
Imports System.Configuration
Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult


            Dim appName As String = ConfigurationManager.AppSettings("appName")

            If ConfigurationManager.AppSettings("IsDebug") = "true" Then
                ' go DB and save

            End If

            Dim time = Session.Timeout

            ViewBag.AppName = appName

            Dim alwaysTrue = Session IsNot Nothing ' => always true
            'Dim isUserLogin = Session("User") IsNot Nothing
            Dim isUserLogin = SessionManager.User IsNot Nothing

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
                'Session("User") = user
                Dim tempUser = SessionManager.Users.Find(Function(u) u.Email = user.Email)
                SessionManager.User = tempUser
                'user.Email1 = "dfad"
                'Dim isUserLogin = Session("usre") IsNot Nothing
                'Dim isUserLogin = SessionManager.User IsNot Nothing

                'If isUserLogin Then
                If SessionManager.IsConnect Then
                    Return RedirectToAction("Index", "Home")

                End If
                ViewBag.Error = "Email or Password is incurrect"
                Return View("Index")
            Catch
                Return View("Index")
            End Try
        End Function


    End Class
End Namespace