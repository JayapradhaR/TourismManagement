﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="PackageDetails.aspx.cs" Inherits="OnlineTourismManagement.PackageDetails" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:GridView ID="GridPackageDetails" runat="server" AutoGenerateColumns="false" DataKeyNames="PackageId" AutoGenerateDeleteButton="true" AutoGenerateEditButton="true" OnRowCancelingEdit="PackageDetails_RowCancelingEdit" OnRowDeleting="PackageDetails_RowDeleting" OnRowEditing="PackageDetails_RowEditing" OnRowUpdating="PackageDetails_RowUpdating" OnRowCommand="GridPackageDetails_RowCommand" OnRowCreated="GridPackageDetails_RowCreated" CellSpacing="2" OnSelectedIndexChanged="GridPackageDetails_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="PackageId">
                <EditItemTemplate>
                    <asp:TextBox ID="textPackageId" runat="server" Text='<%# Bind("packageId") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="labelPackageId" runat="server" Text='<%# Bind("packageId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PackageName">
                <EditItemTemplate>
                    <asp:TextBox ID="textPackageName" runat="server" Text='<%# Bind("packageName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="labelPackageName" runat="server" Text='<%# Bind("packageName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PackageType">
                <EditItemTemplate>
                    <asp:TextBox ID="textPackageType" runat="server" Text='<%# Bind("packageType") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="labelPackageType" runat="server" Text='<%# Bind("packageType") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PackagePrice">
                <EditItemTemplate>
                    <asp:TextBox ID="textPackagePrice" runat="server" Text='<%# Bind("packagePrice") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="labelPackagePrice" runat="server" Text='<%# Bind("packagePrice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
