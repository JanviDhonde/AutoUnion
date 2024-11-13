<%@ Page Language="C#" MasterPageFile="~/HOME/MasterPage.master" AutoEventWireup="true" CodeFile="RTO.aspx.cs" Inherits="HOME_RTO" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<strong><span style="color: #ff6600">&nbsp;<br />
        &nbsp;RTO Login <br />
     <asp:Image ID="Image2" runat="server" Height="62px" ImageUrl="~/IMAGES/k.jpg" Width="228px" /><br />
        <br />
        <table style="background-color: #99ff33; color: #ffffff;">
            <tr>
                <td style="width: 100px">
                    <span style="color: #ff0000">
                    RtoID</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="Enter Correct ID" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <span style="color: #ff0000">
                    Password</span></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                        ErrorMessage="Enter correct pwd" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" 
                        style="height: 26px" /></td>
                <td style="width: 100px">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label></td>
            </tr>
        </table>
        &nbsp;&nbsp;</span></strong>
</asp:Content>

