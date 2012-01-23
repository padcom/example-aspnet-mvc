<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Example</title>
</head>
<body>
    <h1><%= ViewData["Message"] %></h1>
</body>
</html>
