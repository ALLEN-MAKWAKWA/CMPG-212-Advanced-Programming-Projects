<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SU3_pRAC2_Makwakwa_35987782.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #808080">
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="TUTORSHIP FORM" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        </div>
        <table align="center">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name:" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXTNAME" runat="server" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TXTNAME" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Surname:" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXTSURNAME" runat="server" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TXTSURNAME" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="STUDENT ID:" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXTSTUDENTID" runat="server" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TXTSTUDENTID" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Email Address:" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXTEMAIL" runat="server" Width="160px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TXTEMAIL" ErrorMessage="Enter correct email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Select module" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Text="Select module" Value="" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="cmpg111" Value="cmpg111"></asp:ListItem>
                        <asp:ListItem Text="cmpg121" Value="cmpg121"></asp:ListItem>
                        <asp:ListItem Text="cmpg125" Value="cmpg125"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select a module" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="NUMBER OF HOURS" Font-Size="Larger"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TXTNUMHOURS" runat="server" Width="160px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TXTNUMHOURS" ErrorMessage="Enter correct number of working hours" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <div style="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            <asp:Label ID="LSubmited" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#3333CC" Text="Submitted"></asp:Label>
        </div>
    </form>
</body>
</html>
