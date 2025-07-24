<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_35987782_Makwakwa_SU3_Prac4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #C0C0C0">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 290px;
        }
        .auto-style2 {
            width: 144px;
        }
        .auto-style3 {
            width: 290px;
            height: 17px;
        }
        .auto-style4 {
            width: 144px;
            height: 17px;
        }
        .auto-style5 {
            height: 17px;
            text-align: left;
        }
        .auto-style6 {
            width: 188px;
        }
        .auto-style7 {
            height: 17px;
            width: 188px;
        }
        .auto-style8 {
            width: 114px;
        }
        .auto-style9 {
            height: 17px;
            width: 114px;
        }
        .auto-style10 {
            width: 271px;
        }
        .auto-style14 {
            width: 190px;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style18 {
            width: 271px;
            height: 25px;
        }
        .auto-style20 {
            width: 252px;
            height: 25px;
        }
        .auto-style21 {
            width: 183px;
            height: 25px;
            text-align: left;
        }
        .auto-style22 {
            width: 190px;
            height: 25px;
        }
        .auto-style23 {
            height: 25px;
            text-align: left;
        }
        .auto-style24 {
            text-align: left;
        }
        .auto-style25 {
            width: 286px;
        }
        .auto-style26 {
            width: 175px;
        }
        .auto-style27 {
            width: 252px;
        }
        .auto-style28 {
            width: 183px;
        }
        .auto-style29 {
            width: 346px;
            height: 25px;
        }
        .auto-style30 {
            width: 346px;
        }
        .auto-style31 {
            width: 286px;
            height: 191px;
        }
        .auto-style32 {
            width: 175px;
            height: 191px;
        }
        .auto-style33 {
            height: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style15">
        <div class="auto-style15">
            SI Consultation Bookimg</div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextName" ErrorMessage="Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text="Surname"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextSurname" ErrorMessage="Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextSurname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Stud_ID"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextStudID" ErrorMessage="Required" BackColor="#CCCCCC" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextStudID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label5" runat="server" Text="Select Module"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownSELECTmodule" runat="server" OnSelectedIndexChanged="DropDownSELECTmodule_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownSELECTmodule" ErrorMessage="Select Module" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="Select prefered time slot:"></asp:Label>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style18"></td>
                    <td class="auto-style29">&nbsp;</td>
                    <td class="auto-style20">
                        <asp:RadioButtonList ID="TimeSlotRadioButtonList" runat="server" OnSelectedIndexChanged="TimeSlotRadioButtonList_SelectedIndexChanged" Width="103px">
    <asp:ListItem Text="Mon 10am" Value="Mon"></asp:ListItem>
    <asp:ListItem Text="Tues 9am" Value="Tue"></asp:ListItem>
    <asp:ListItem Text="Wed 10am" Value="Wed"></asp:ListItem>
    <asp:ListItem Text="Thur 11am" Value="Thur"></asp:ListItem>
</asp:RadioButtonList>

                    </td>
                    <td class="auto-style21">
                        <asp:Label ID="Label8" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style27">
                        <asp:Button ID="BTNback" runat="server" OnClick="BTNback_Click" Text="Book" Width="135px" />
                    </td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style31">
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ForeColor="#3399FF"></asp:Calendar>
                </td>
                <td class="auto-style32"></td>
                <td class="auto-style33">
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    
                   </asp:GridView>

                </td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style26">
                    <asp:Label ID="Label7" runat="server" Text="Your next session"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
