<%@ Page Language="C#" MasterPageFile="~/rto/rto.master" AutoEventWireup="true" CodeFile="viewllrapplications.aspx.cs" Inherits="rto_viewllrapplications" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="border: thin groove #FF9900">
        <tr>
            <td align="right" class="style2" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                &nbsp; LLR&nbsp;</td>
        </tr>
        <tr>
            <td class="style1" colspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    CellPadding="5" GridLines="None" Height="139px" ShowHeader="False" 
                    onselectedindexchanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~/IMAGES/{0}"
                            HeaderText="photo">
                            <ControlStyle Height="100px" Width="100px" />
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Licence No</td>
            <td class="style7">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="style6" style="width: 7px">
                </td>
        </tr>
        <tr>
            <td class="style8">
                Name</td>
            <td class="style3">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Son/Daughter/Wife of</td>
            <td class="style3">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Date Of Birth</td>
            <td class="style3">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Blood Group</td>
            <td class="style3">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Address </td>
            <td class="style3">
                <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                City</td>
            <td class="style3">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                State</td>
            <td class="style3">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Phone No</td>
            <td class="style3">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Mak Of identification</td>
            <td class="style3">
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Issue Date</td>
            <td class="style3">
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Validity</td>
            <td class="style3">
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Type</td>
            <td class="style3">
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Issued At</td>
            <td class="style3">
                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
            </td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Issued By</td>
            <td class="style5">
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </td>
            <td class="style4" style="width: 7px">
                </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td style="width: 7px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td style="width: 7px">
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

