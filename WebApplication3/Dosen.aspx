<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dosen.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style="font-size:x-large" align="center">Dosen information</div>
        <br />
        <table class="nav-justified">
            <tr>
                <td class="modal-sm" style="width: 343px; height: 24px;"></td>
                <td class="modal-sm" style="width: 56px; height: 24px;">NIP</td>
                <td style="height: 24px">
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" style="margin-left: 0"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 343px">&nbsp;</td>
                <td class="modal-sm" style="width: 56px">Nama</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" style="margin-left: 0"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 343px; height: 20px"></td>
                <td class="modal-sm" style="width: 56px; height: 20px"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 343px">&nbsp;</td>
                <td class="modal-sm" style="width: 56px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                &nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 343px; height: 20px;"></td>
                <td class="modal-sm" style="width: 56px; height: 20px;"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 343px">&nbsp;</td>
                <td class="modal-sm" style="width: 56px">&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="405px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
