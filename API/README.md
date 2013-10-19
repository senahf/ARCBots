*** Alright so heres the API Documentation! ***

Basically ARCBots allows users to user the API system to create their own wonderful little scripts.
Right now, the API supports the GET method and does require an API key from the arcbots cpanel.
You can go grab your little API key here:
http://arcbots.com/cpanel/edit-account-info.html

Heres the format of the v2 api url:
http://arcbots.com/api-v2.html
&user=%username%
&apiToken=%APIToken%
&cmd=%cmd% // Basically the command you want to send out (restart, stop, sendCmd)
&xatBotCommand=%botcmd% // If the field was sendCmd, here is what the user will send to the bot. (OPTIONAL)
&botid=%botid%

An example JSON Array that outputs (with just the "user" and "apiToken" GET fields filled):
{"botids":["2","43","10147","11415","16087","30770","33893","33959","37910"],"favoriteBotid":null,"username":"matthieu503","error":0,"message":"You have successfully logged in"}

An example JSON Array that outputs (with the cmd "Restart" and the "botid" field filled):
{"error":0,"message":"Bot has been restarted."}

There are many many ways to actually "Decode" the JSON arrays.
In PHP there is a json_decode() function (http://php.net/manual/en/function.json-decode.php)
In the .NET Framework there is the JavaScriptSerializer class (http://msdn.microsoft.com/en-us/library/system.web.script.serialization.javascriptserializer.aspx)
You can even take the JSON Array and snip it up using ReGEX.

Here is an example for utilizing the API in PHP:
http://pastebin.com/XATJY45n

You can see the VB.NET Examples in the API Tools directory.

Remember that this api is not limited to JUST these languages, you can always use it in many others!

Unauthenticated API's can be found at http://arcbots.com/userinfo.php
Basically they are just xat things that can be grabbed.

Room to IP: http://arcbots.com/ip-api-sample.html
