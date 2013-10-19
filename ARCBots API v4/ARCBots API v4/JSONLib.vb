Public Class ARCBotsJSON
    Public botids As Integer()
    Public favoriteBotid As Integer
    Public username As String
    Public [error] As Integer '[ ] escapes error so it won't pop a message saying we can't use it globally.
    Public message As String

    'Example JSON Array
    '{"botids":["1","2","3","4","5"],"favoriteBotid":null,"username":"ARCBots","error":0,"message":"You have successfully logged in"}

End Class

Public Class ARCBotsCMDJSON
    Public [error] As Integer '[ ] escapes error so it won't pop a message saying we can't use it globally.
    Public message As String

    'Example JSON Array
    '{"error":0,"message":"Bot has been restarted."}

End Class

Public Class ARCBotsCMDSendJSON
    Public [error] As Integer '[ ] escapes error so it won't pop a message saying we can't use it globally.
    Public errorMessage As String
    Public message As String

    'Example JSON Array
    '{"error":0,"message":"Bot has been restarted."}

End Class