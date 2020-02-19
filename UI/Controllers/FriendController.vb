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
        <HttpGet()>
        Function Create() As ActionResult
            TempData("message") = "Edit!"
            Return View()
        End Function

        ' POST: Friend/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Dim _friend = New FriendVM(collection)

                TempData("message") = _friend

                Return RedirectToAction("Index")
            Catch
                TempData("message") = "Error!"

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

        Function ConvertCollectioinToFriend(collection As FormCollection) As FriendVM
            Dim _friend = New FriendVM(collection("Name"),
                                       collection("Email"),
                                       collection("Age"))

            Dim email = _friend.Email ' get Email()
            _friend.Email = "yonatan" ' set Email() => Error
            _friend.Email = "yonatan@yaltman" ' get Email() => Good
            _friend.ID = "yonatan@yaltman" ' get Email() => Good
            'Dim _friend = New FriendVM()
            '_friend.Name = collection("Name")
            '_friend.Email = collection("Email")
            '_friend.Age = collection("Age")

            Return _friend

        End Function

    End Class
End Namespace