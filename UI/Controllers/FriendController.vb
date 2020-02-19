Imports System.Web.Mvc

Namespace Controllers
    Public Class FriendController
        Inherits Controller

        ' GET: Friend
        ' GET: Friend/Index
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Friend/Details/5
        Function Details(ByVal id As Integer) As ActionResult

            ' Go to DB and Select where id =5
            Return View()
        End Function

        ' GET: Friend/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Friend/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Friend/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Friend/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Friend/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Friend/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace