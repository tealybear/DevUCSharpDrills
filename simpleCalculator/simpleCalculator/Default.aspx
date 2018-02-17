<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="simpleCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
        </div>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="Button1_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="Button4_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
