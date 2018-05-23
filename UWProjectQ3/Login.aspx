<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div id="Login">
		User Id: <asp:TextBox id="txtLogin" CssClass="box" runat="server"> </asp:TextBox><br/>
		Password: <asp:TextBox id="txtPassword" CssClass="box" runat="server"> </asp:TextBox><br/>
		<asp:Button id="btnSubmit" class="w3-button" Text="Submit" OnClick="ValidateUserLogin" runat="server"></asp:Button>
	</div>
</asp:Content>

