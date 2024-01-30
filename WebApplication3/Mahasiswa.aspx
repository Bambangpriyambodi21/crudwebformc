<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mahasiswa.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<head>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 121px;
        }
        .auto-style3 {
            width: 241px;
        }
        .auto-style4 {
            width: 241px;
            height: 30px;
        }
        .auto-style5 {
            width: 121px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style7 {
            width: 241px;
            height: 26px;
        }
        .auto-style8 {
            width: 121px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<form id="form1" runat="server">

<div>
    <div style="font-size:x-large" align="center">Mahasiswa Information</div>
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
            <td class="auto-style2">Nama Mahasiswa</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">Tanggal Lahir</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" placeholder="ex: 2000-01-01"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">Alamat</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">Jenis Kelamin</td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownList1" runat="server" >
                    <asp:ListItem>Laki-laki</asp:ListItem>
                    <asp:ListItem>Perempuan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5"></td>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
            &nbsp;<asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            &nbsp;<asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            &nbsp;<asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="413px">
                </asp:GridView>
            </td>
        </tr>
        </table>
&nbsp;</div>
    <br />
</div>
</form>

