ZuluTradeRestApi
================

ZuluTradeRestApi is a class library to consume easily the ZuluTrade RestApi with a simple C# Client.

As you probably already know you can enable the RestApi on your Zulutrade Signal Provider Account.

As you can see, in the solution there is one test project with most of the test "commented" to avoid any issue with your zulutrade account.
To start using the Code with your account you have to add in your config UserName and Password for your Signal Provider Account and start running the tests.

<appSettings>
    <add key="ZuluUserName" value="XXXX"/>
    <add key="ZuluPwd" value="XXXXX"/>

For further information on ZuluTrade Rest Api this is the link to the reference page
https://www.zulutrade.com/restapi-reference

In this project I have used a bit of CQRS to give a structure to the code.
It comes well with Log4Net for Logging and Json.net for Json Serialization.

Happy trading and Good luck spreading your signal on Zulutrade
