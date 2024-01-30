<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matakuliah.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<head>
    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
        .auto-style2 {
            height: 20px;
            width: 265px;
        }
        .auto-style3 {
            width: 465px;
        }
        .auto-style4 {
            height: 20px;
            width: 465px;
        }
        .auto-style5 {
            width: 135px;
        }
        .auto-style6 {
            height: 20px;
            width: 135px;
        }
    </style>
</head>
<form id="form1" runat="server">

<div>
        <div style="font-size:x-large" align="center">Mata Kuliah information</div>
        <br />
        <table class="nav-justified">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">Kode Mata Kuliah</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" ></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">Nama Mata Kuliah</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" ></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">SKS</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" ></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Btn_insert_MK" Text="Insert" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Btn_update_MK" Text="Update" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Btn_delete_MK" Text="Delete" />
                &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Btn_search_sks_MK" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
&nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" Width="435px">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</form>

