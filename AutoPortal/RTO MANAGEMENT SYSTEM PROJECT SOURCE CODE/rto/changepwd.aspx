<%@ Page Language="C#" MasterPageFile="~/rto/rto.master" AutoEventWireup="true" CodeFile="changepwd.aspx.cs" Inherits="rto_changepwd" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <br />
    <span style="color: #ff3300"><strong>&nbsp;Change Password&nbsp;</strong></span><p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<strong> &nbsp;<span style="color: #000000">
            Id &nbsp; &nbsp;</span> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        </strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;</p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span style="color: #000000">
            <strong>&nbsp; Password &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </strong></span>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox><span
            style="color: #000000"><strong> </strong></span>
    </p>
    <p>
        <span style="color: #000000"><strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; New Password</strong></span> &nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
    </p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <strong><span style="color: #000000">
            &nbsp; Re-Password </span></strong>&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        &nbsp;</p>
    <p>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" />
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

