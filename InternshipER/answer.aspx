﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="answer.aspx.cs" Inherits="InternshipER.answer" %>

<!DOCTYPE html>
<html>
<head>
  <title>Display Image on the Flag Folder</title>
</head>
<body>
<h1>Displaying an Image On the Flag Folder</h1>
<form method="post" action="">
    <div>
        Photo:
        <select name="photoChoice">
            <option value="Photo1.jpg">Photo 1</option>
            <option value="Photo2.jpg">Photo 2</option>
            <option value="Photo3.jpg">Photo 3</option>
        </select>
        &nbsp;
        <input type="submit" value="Submit" />
    </div>
    <div style="padding:10px;">
        @if(imagePath != ""){
            <img src="@imagePath" alt="Sample Image" width="300px" />
        }
    </div>
</form>
</body>
</html>
