<%@ Page Language="C#" MasterPageFile="~/employee/employee.master" AutoEventWireup="true" CodeFile="addrenewalperminentdetail.aspx.cs" Inherits="employee_addrenewalperminentdetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <table class="style1">
    <tr>
        <td align="center" class="style2" colspan="3">
            Renewal Of Permanent Licence</td>
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
            LLR No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Date Of Issue</td>
        <td class="style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="enter date" Operator="DataTypeCheck" 
                Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Date Of Renewal</td>
        <td class="style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="enter date" Operator="DataTypeCheck" 
                Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Type Of Licence</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>MCWG</asp:ListItem>
                <asp:ListItem>MCWOG</asp:ListItem>
                <asp:ListItem>HMC</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="DropDownList1" ErrorMessage="select any one"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Name</td>
        <td class="style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="enter name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Son/Daughter/Wife Of</td>
        <td class="style3">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox5" ErrorMessage="enter text"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Date Of Birth</td>
        <td class="style3">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator3" runat="server" 
                ControlToValidate="TextBox6" ErrorMessage="enter date" Operator="DataTypeCheck" 
                Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Blood Group</td>
        <td class="style3">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBox7" ErrorMessage="enter blood group"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Address 1</td>
        <td class="style3">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBox8" ErrorMessage="enter address1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Address 2</td>
        <td class="style3">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="TextBox9" ErrorMessage="enter address2"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            City
        </td>
        <td class="style3">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="TextBox10" ErrorMessage="enter city"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            State</td>
        <td class="style3">
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                ControlToValidate="TextBox11" ErrorMessage="enter state"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Phone No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox12" ErrorMessage="enter phone no" 
                ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Marks Of Identification 1</td>
        <td class="style3">
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="TextBox13" ErrorMessage="enter identification1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 2</td>
        <td class="style3">
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                ControlToValidate="TextBox14" ErrorMessage="enter identification2"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Licence Vaild From</td>
        <td class="style3">
            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator4" runat="server" 
                ControlToValidate="TextBox15" ErrorMessage="enter date" 
                Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To&nbsp;</td>
        <td class="style3">
            <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator5" runat="server" 
                ControlToValidate="TextBox16" ErrorMessage="enter date" 
                Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Challana No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                ControlToValidate="TextBox17" ErrorMessage="enter chalana no"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Amount</td>
        <td class="style3">
            <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                ControlToValidate="TextBox18" ErrorMessage="enter chalana amount"></asp:RequiredFieldValidator>
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
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" BackColor="#D15803" Text="SUBMIT" 
                onclick="Button1_Click" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" BackColor="#D15803" Text="CLEAR" 
                Width="62px"  />
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

</asp:Content>

