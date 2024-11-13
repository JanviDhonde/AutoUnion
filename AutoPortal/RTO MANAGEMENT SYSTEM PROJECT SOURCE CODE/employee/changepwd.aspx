<%@ Page Language="C#" MasterPageFile="~/employee/employee.master" AutoEventWireup="true" CodeFile="changepwd.aspx.cs" Inherits="employee_changepwd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <span style="color: #ff3300"><strong>&nbsp;Change Password&nbsp;</strong></span><p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<strong> &nbsp;<span style="color: #000000">
            Id &nbsp; &nbsp;</span> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        </strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><strong> &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Enter correct Id"></asp:RequiredFieldValidator>&nbsp; </strong>
    </p>
    <p>
        <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="color: #330000">
            &nbsp; Name &nbsp;</span> &nbsp;</strong> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ControlToValidate="TextBox2" ErrorMessage="Enter Name" Font-Bold="True"></asp:RequiredFieldValidator></p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="color: #000000">
            <strong>&nbsp; Password &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </strong></span>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox><span
            style="color: #000000"><strong> &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Enter Password"></asp:RequiredFieldValidator></strong></span></p>
    <p>
        <span style="color: #000000"><strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; New Password</strong></span> &nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="Enter New Pwd" Font-Bold="True"></asp:RequiredFieldValidator></p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <strong><span style="color: #000000">
            &nbsp; Re-Password </span></strong>&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        &nbsp;&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4"
            ControlToValidate="TextBox5" ErrorMessage="CompareValidator" Font-Bold="True">RE-ENTER correct pwd</asp:CompareValidator></p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="CLEAR" />
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

