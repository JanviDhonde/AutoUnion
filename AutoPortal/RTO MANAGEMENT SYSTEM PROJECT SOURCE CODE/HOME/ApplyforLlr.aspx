<%@ Page Language="C#" MasterPageFile="~/HOME/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyforLlr.aspx.cs" Inherits="HOME_ApplyforLlr" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <p>
        <br />
    <table class="style1" style="background-color: #cccccc">
    <tr>
        <td align="center" class="style2" colspan="3">
            LLR&nbsp; Details</td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Image</td>
        <td class="style3" colspan="2">
            <asp:FileUpload ID="fileImgUpload" runat="server" />
                                </td>
    </tr>
    <tr>
        <td class="style4">
            Date</td>
        <td class="style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="enter the correct date" 
                Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Name</td>
        <td class="style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="enter the name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Son/Daughter/Wife of</td>
        <td class="style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="enter the text"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Date Of Birth</td>
        <td class="style3">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToValidate="TextBox5" ErrorMessage="enter the date" 
                Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Blood Group</td>
        <td class="style3">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox6" ErrorMessage="enter the text"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Address 1</td>
        <td class="style3">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBox7" ErrorMessage="enter the address1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Address&nbsp; 2</td>
        <td class="style3">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBox8" ErrorMessage="enter the address2"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            City</td>
        <td class="style3">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="TextBox9" ErrorMessage="enter city"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            State</td>
        <td class="style3">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="TextBox10" ErrorMessage="enter state"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Phone No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox11" ErrorMessage="RegularExpressionValidator" 
                ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Mak Of identification</td>
        <td class="style3">
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="TextBox12" ErrorMessage="enter the identification marks"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Licnce Type</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>MCWG</asp:ListItem>
                <asp:ListItem>MCWOG</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="DropDownList2" ErrorMessage="select any one"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Challana No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4" style="height: 21px">
            &nbsp;</td>
        <td class="style3" style="height: 21px">
            &nbsp;</td>
        <td style="height: 21px">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" BackColor="#D15803" Text="SUBMIT" OnClick="Button1_Click" 
               />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" BackColor="#D15803" Text="CLEAR" 
                Width="62px" OnClick="Button2_Click"  />
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

