<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_019_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 160px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><h2>Spy New Assignment Form</h2>
            <br />
            Spy Code Name:&nbsp; <asp:TextBox ID="myTextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:&nbsp;
            <asp:TextBox ID="myTextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="myCalendar1" runat="server" SelectedDate="2018-03-17"></asp:Calendar>
            <br />
            Start Date of New Assignment:<asp:Calendar ID="myCalendar2" runat="server" OnSelectionChanged="myCalendar2_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="myCalendar3" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="myButton" runat="server" OnClick="myButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
