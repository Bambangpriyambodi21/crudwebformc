<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perkuliahan.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<head>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 127px;
        }
        .auto-style3 {
            width: 294px;
        }
    </style>
</head>
<form id="form1" runat="server">

<div>
    <div style="font-size:x-large" align="center">Perkuliahan information</div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">NIM</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">Kode Mata Kuliah</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">NIP</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">Nilai</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="429px">
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
</div>
</form>

