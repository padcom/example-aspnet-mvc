<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="MongoDB.Driver" %>
<%@ Import Namespace="MongoDB.Bson" %>
<!DOCTYPE html>

<html>
<head runat="server">
    <title>Example</title>
</head>
<body>
    <h1><%= ViewData["Message"] %></h1>

    <ul>
        <% var posts = (MongoCursor<BsonDocument>)ViewData["Posts"]; %>
        <% foreach (var post in posts) { %>
            <li><%= post["text"] %></li>
        <% } %>
    </ul>
</body>
</html>
