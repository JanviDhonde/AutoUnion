<%@ Page Language="C#" MasterPageFile="~/employee/employee.master" AutoEventWireup="true" CodeFile="addregdetails.aspx.cs" Inherits="employee_addregdetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table class="style1">
    <tr>
        <td align="center" class="style2" colspan="3">
            Registration form</td>
    </tr>
    <tr>
        <td align="center" class="style2" colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            Registration No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            Registration Date</td>
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
        <td class="style4" colspan="3">
            Owner Details</td>
    </tr>
    <tr>
        <td class="style6">
            Full Name Of Applicant</td>
        <td class="style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="enter name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Son/Daughter/Wife of</td>
        <td class="style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="enter text"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Age</td>
        <td class="style3">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox5" ErrorMessage="enter age"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Address 1</td>
        <td class="style3">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBox6" ErrorMessage="enter address1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Address 2</td>
        <td class="style3">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBox7" ErrorMessage="enter address2"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            City</td>
        <td class="style3">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="TextBox8" ErrorMessage="enter city"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            State</td>
        <td class="style3">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="TextBox9" ErrorMessage="enter state"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Phone No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox10" ErrorMessage="enter phone no" 
                ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style5" colspan="3">
            Vehicle Details</td>
    </tr>
    <tr>
        <td class="style6">
            Name &amp; Address Of Dealer or from whome the vehicle Purchased
        </td>
        <td class="style3">
            <asp:TextBox ID="TextBox11" runat="server" Height="53px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="TextBox11" ErrorMessage="enter text"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Type of Vehicle</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>mc</asp:ListItem>
                <asp:ListItem>mcwog</asp:ListItem>
                <asp:ListItem>hmc</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                ControlToValidate="DropDownList1" ErrorMessage="select any one"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Date Of Manufacturer</td>
        <td class="style3">
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToValidate="TextBox12" ErrorMessage="enter date" 
                Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Chassis No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="TextBox13" ErrorMessage="enter chassis no"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Engine No</td>
        <td class="style3">
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                ControlToValidate="TextBox14" ErrorMessage="enter engine no"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Seating Capacity</td>
        <td class="style3">
            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                ControlToValidate="TextBox14" ErrorMessage="seating capacity"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Fuel Used
        </td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>petrol</asp:ListItem>
                <asp:ListItem>deasel</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                ControlToValidate="DropDownList2" ErrorMessage="select any one"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Chllana Amount</td>
        <td class="style3">
            <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                ControlToValidate="TextBox16" ErrorMessage="enter chalanna amt"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6" style="height: 26px">
            &nbsp;</td>
        <td class="style3" style="height: 26px">
            <asp:Button ID="Button1" runat="server" BackColor="#D15803" Text="SUBMIT" 
                onclick="Button1_Click" />
        </td>
        <td style="height: 26px">
            <asp:Button ID="Button2" runat="server" BackColor="#D15803" Text="CLEAR" 
                Width="62px" onclick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style3">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

