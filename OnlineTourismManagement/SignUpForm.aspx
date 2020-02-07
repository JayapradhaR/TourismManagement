<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SignUpForm.aspx.cs" Inherits="OnlineTourismManagement.SignUpForm" %>

<%--<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>--%>
<asp:Content ID="contentPlaceHolderSignUp" runat="server" ContentPlaceHolderID="ContentPlaceHolder">
    <link rel="stylesheet" type="text/css" href="Styles.css" />
    <div class="SignIn">
        <table align="Center";>
            <tr>
                <td><asp:Label ID="labelFirstName" runat="server" Text="First Name"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textFirstName"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="validateFirstName" runat="server" ControlToValidate="textFirstName" ErrorMessage="First name required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validateName" runat="server" ControlToValidate="textFirstName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="labelLastName" runat="server" Text="Last Name"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textLastName"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="validateLastName" runat="server" ControlToValidate="textLastName" ErrorMessage="Last name required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rgvName" runat="server" ControlToValidate="textLastName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="labelMobileNumber" runat="server" Text="Mobile Number"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textMobileNumber"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="validateMobileNumber" runat="server" ControlToValidate="textMobileNumber" ErrorMessage="Mobile number required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rgvMobileNumber" runat="server" ControlToValidate="textMobileNumber" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="labelDOB" runat="server" Text="DOB"></asp:Label></td>
                <td>
                    <asp:TextBox ID="textDOB" runat="server" TextMode="Date"></asp:TextBox></td>
            
            <td>
                <asp:RequiredFieldValidator ID="validateDOB" runat="server" ControlToValidate="textDOB" ErrorMessage="DOB required" Style="color: red"></asp:RequiredFieldValidator>
            </td>
                </tr>
            <tr>
                <td><asp:Label ID="labelGender" runat="server" Text="Gender"></asp:Label></td>
                <td>
                    <asp:RadioButton ID="rdoMale" runat="server" Text="Male" GroupName="Gender" />
                    <asp:RadioButton ID="rdoFemale" runat="server" Text="Female" GroupName="Gender" />
                </td>
            </tr>
            <td><asp:Label ID="labelMailId" runat="server" Text="Mail Id"></asp:Label></td>
            <td>
                <asp:TextBox runat="server" ID="textMailId" TextMode="Email"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="validateMailId" runat="server" ControlToValidate="textMailId" ErrorMessage="Mail id required" Style="color: red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rgvMailId" runat="server" ControlToValidate="textMailId" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
            </td>
            </tr>
                <tr>
                    <td><asp:Label ID="labelPassword" runat="server"  Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="textPassword" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="textPassword" ErrorMessage="Password required" Style="color: red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            <tr>
                <td><asp:Label ID="labelConfirmPassword" runat="server" Text="Confirm Password"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textConfirmPassword" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="rfvConfirmPassword" ControlToValidate="textConfirmPassword" ErrorMessage="Confirm password required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="validatePassword" ControlToValidate="textConfirmPassword" ControlToCompare="textPassword" ErrorMessage="Password and Confirm password must be same"></asp:CompareValidator>
                </td>
                 <tr>
                <td><asp:Label ID="labelRoleID" runat="server" Text="Role ID"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textRoleId"></asp:TextBox>
                </td>
            </tr>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button runat="server" ID="buttonSignUp" Text="Sign up" OnClick="Signup_Click" />
                </td>
            </tr>
           
        </table>
        <asp:ValidationSummary ID="validationSummary" runat="server" />
    </div>
</asp:Content>
