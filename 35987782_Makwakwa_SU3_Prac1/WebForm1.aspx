<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="act1_SU3_Makwakwa_359877782.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 9px;
            margin-top: 24px;
        }
        .auto-style3 {
            height: 678px;
        }
        .auto-style2 {
            margin-left: 0px;
            margin-top: 0px;
        }
        .auto-style4 {
            margin-left: 0px;
            margin-top: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3" style="background-color: #C0C0C0">
            <asp:Label ID="Label10" runat="server" BorderColor="#FF0066" ForeColor="Red" Text="GROCERY LIST CREATOR"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="#00CCFF" Text="Enter your name to create your own personalized GROCERY list!!!!!!"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Label ID="Label9" runat="server" ForeColor="#0066FF" Text="Name:"></asp:Label>
&nbsp;
            <asp:TextBox ID="texName" runat="server" CssClass="auto-style4" Height="16px" Width="223px" OnTextChanged="texName_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" BackColor="#CCFFFF" Height="23px" OnClick="Button1_Click" Text="Add to list" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" ForeColor="Aqua" Text="Item needed from the store:"></asp:Label>
            <asp:TextBox ID="textItems" runat="server" CssClass="auto-style1" Height="26px" Width="223px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" ForeColor="#33CC33" Text="GROCERY LIST"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="groceryList" runat="server" CssClass="auto-style2" Height="153px" Width="316px" OnSelectedIndexChanged="groceryList_SelectedIndexChanged">
                <asp:ListItem>Pepsi</asp:ListItem>
                <asp:ListItem>Shimba Beef Large</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="#FF33CC" Text="Slect items from the list to remove them"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server" ForeColor="#FF3300" Text="[Message]"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
