<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #FF6600;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
                <span class="auto-style1">Papa Bob&#39;s Pizza and Software</span></h1>
        </div>
        <asp:RadioButton ID="sizeRadio1" runat="server" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="sizeRadio2" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="sizeRadio3" runat="server" GroupName="Size" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="crustRadio1" runat="server" GroupName="Crust" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="crustRadio2" runat="server" GroupName="Crust" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenpeppersCheckBox" runat="server" Text="Green Peppers ($0.50)" />
        <br />
        <asp:CheckBox ID="redpeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <h2><span class="auto-style1">Papa Bob&#39;s </span><span class="auto-style2">Special Deal</span></h2>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Total:"></asp:Label>
            <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</p>
    </form>
</body>
</html>
