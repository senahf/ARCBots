Public Class JSONMAIN
    Public Property restartbot() As String
        Get
            Return m_restartbot
        End Get
        Set(value As String)
            m_restartbot = Value
        End Set
    End Property
    Private m_application_id As String
End Class
