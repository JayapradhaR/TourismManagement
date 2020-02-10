<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="OnlineTourismManagement.LoginForm" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderLogin" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div>
        <table align="Center">
            <tr>
                <td>
                    <asp:Label ID="labelUsername" Text="Username" runat="server"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textUserId" placeholder="Enter your mail id"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelPassword" Text="Password" runat="server"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textPassword" TextMode="Password" placeholder="Enter your password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" Text="Sign In" OnClick="SignIn_Click" />
                </td>
                <td>
                    <asp:Button runat="server" Text="Sign Up" OnClick="SignUp_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>



