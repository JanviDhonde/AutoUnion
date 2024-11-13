<%@ Page Language="C#" MasterPageFile="~/rto/rto.master" AutoEventWireup="true" CodeFile="IssuingofPerminentLicence.aspx.cs" Inherits="rto_IssuingofPerminentLicence" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="DRIVING LICENCE" 
        style="position:absolute; top: 231px; left: 391px; width: 256px;" 
        Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
            <asp:ListItem>--SELECT--</asp:ListItem>
        </asp:DropDownList>
        &nbsp;</p>
                        <p>
                            &nbsp;</p>
    <table class="style18" style="border: thin groove #FF9900">
        <tr>
            <td style="background-color: #EC9C62; color: #000000; font-weight: bold;" 
                align="center">
                INDIAN UNION DRIVING LICENCE<br />
                ANDHARA PARDESH</td>
        </tr>
    </table>
<p>
</p>
<p>
</p>
    <table class="style19" style="border: thin groove #FF9933">
        <tr>
            <td class="style21" rowspan="3">
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="1" GridLines="None" ShowHeader="False" PageIndex="1" 
                    Width="17px">
                    <Columns>
                        <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~/IMAGES/{0}">
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
                <br />
            </td>
            <td class="style20">
                Licence No</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20">
                Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20">
                Address</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        </table>
<p>
</p>
<p>
</p>
<p>
</p>
    <table class="style22" style="border: thin groove #FF9900">
        <tr>
            <td class="style21">
                Licence type</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Date Of Birth</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Blood Group</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Issued Date</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Validity</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Issued at</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>Ongole</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Visakhapatnam</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Issued By</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style21">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#CC6600" Height="26px" 
                    Text="ISSUE" onclick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#CC6600" Height="26px" 
                    Text="CLEAR" onclick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
<p>
</p>
<p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
</asp:Content>

