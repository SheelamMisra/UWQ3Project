<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="Default2" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<style type="text/css">
	#LoginRequest {
		width: 626px;
	}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div id="LoginRequest">
    
		Name: <br/><asp:TextBox id="txtName" CssClass="box" runat="server"> </asp:TextBox><br/>
		Email Address: <br/><asp:TextBox id="txtEmail" CssClass="box" runat="server"> </asp:TextBox><br/>
		Login Name: <br/><asp:TextBox id="txtLogin" CssClass="box" runat="server"> </asp:TextBox><br/>
		Reason for access ? <br/><asp:TextBox id="txtReasonForAccess" CssClass="box" runat="server" TextMode="MultiLine"> </asp:TextBox><br/>
		<asp:Button id="btnSubmit" class="w3-button" Text="Submit" OnClick="GetUserLoginData" runat="server"></asp:Button>
		<div><asp:TextBox ID="txtMessage" runat="server" CssClass="" Width="100%" ForeColor="#3333cc" Font-Bold="true"></asp:TextBox></div>
	</div>

</asp:Content>

