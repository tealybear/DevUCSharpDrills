<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your name?&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            What is your IQ level?&nbsp;
            <asp:TextBox ID="iqTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="uploadButton" runat="server" OnClick="uploadButton_Click" Text="Click to begin upload!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
