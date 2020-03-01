Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class UserController
        Inherits ApiController

        ' GET: api/User
        Public Function GetValues() As IEnumerable(Of String)

            Dim arr As List(Of String) = New List(Of String)() From {
                "Yonatan",
                "Maayan",
                "Harry",
                "Orya",
                "Uri"
            }
            Try
                Dim name1 = arr(2).ToString()
                Dim name2 = arr(7).ToString()

            Catch ex As Exception
                Dim userError = ex.Message

            End Try



            Return arr
        End Function

        ' GET: api/User/5
        Public Function GetValue(ByVal id As Integer) As String
            Dim name As String
            Dim arr As List(Of String) = New List(Of String)() From {
                "Yonatan",
                "Maayan",
                "Harry",
                "Orya",
                "Uri"
            }
            Try
                name = arr(id).ToString()


            Catch ex As Exception
                name = ex.Message
                name = "המשתמש אינו קיים"

            End Try


            Return name
        End Function

        ' POST: api/User
        Public Function PostValue(<FromBody()> ByVal request As RequestLogin) As LoginResponse
            Dim user As User = New User()
            user.Email = "yonatan@yaltman.com"
            user.FirstName = "Yonatan"
            user.LastName = "Altman"


            Dim response As LoginResponse = New LoginResponse()
            response.User = user



            Dim loginError = "Email or Password is incorrect"
            Try
                Dim email = request.Email.ToString()

                Dim password = request.Password.ToString()

                If email = user.Email & password = user.Password Then
                    response.Rc = 0
                    response.Desc = "Hello " + email

                    Return response

                End If

                response.Rc = 99
                response.Desc = loginError




            Catch ex As Exception
                ' Write to log that we had error
            End Try
            Return response



        End Function

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class




    Public Class RequestLogin
        Public Email As String
        Public Password As String



    End Class
    Public Class LoginResponse
        Inherits Response




    End Class
    Public Class Response
        Public Rc As Integer
        Public Desc As String
        Public User As User
    End Class

    Public Class User
        Public FirstName As Integer
        Public LastName As String
        Public Email As String
        Public Password As String

    End Class



End Namespace