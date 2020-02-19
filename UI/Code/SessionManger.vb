Class SessionManager
    Const _COUNTER As String = "Counter"
    Const FriendVM_LIST As String = "FriendVMList"

    Private Shared ReadOnly Property Session As HttpSessionState
        Get
            Return HttpContext.Current.Session
        End Get
    End Property

    Public Shared Property Counter As Integer
        Get
            If Session(_COUNTER) Is Nothing Then Session(_COUNTER) = 0
            Return CInt(Session(_COUNTER))
        End Get
        Set(ByVal value As Integer)
            Session(_COUNTER) = value
        End Set
    End Property

    Public Shared Property FriendVMList As List(Of [FriendVM])
        Get
            If Session(FriendVM_LIST) Is Nothing Then Session(FriendVM_LIST) = New List(Of [FriendVM])()
            Return TryCast(Session(FriendVM_LIST), List(Of [FriendVM]))
        End Get
        Set(ByVal value As List(Of [FriendVM]))
            Session(FriendVM_LIST) = value
        End Set
    End Property
End Class
