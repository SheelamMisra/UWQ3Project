<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	
<div class="w3-container w3-border-blue-grey">
	<h4>Register for classes of your choice, one at a time.</h4>
	<asp:RadioButtonList id="rblRegister" class="w3-hover-blue-gray"  runat="server" BorderStyle="Inset" BorderWidth="5px" CellPadding="15" CellSpacing="10" BorderColor="#666666" Height="69px" Width="1023px" BackColor="#333333" CssClass="breadcrumb" />
	<asp:Button CssClass="w3-button" Text="Register" OnClick="Index_Changed_register" runat="server" Font-Bold="True" Font-Size="16px" Font-Strikeout="False"></asp:Button>
</div>
<div class="w3-container w3-border-blue-grey">
	<br/><br/><br/>
	<h4>Classes already registered for can be opted out off by Unregistering, one at a time.</h4>
	<asp:RadioButtonList id="rblUnregister" class="w3-hover-blue-gray"  runat="server" BorderStyle="Inset" BorderWidth="5px" CellPadding="15" CellSpacing="10" BorderColor="#666666" Height="69px" Width="1023px" BackColor="#333333" CssClass="breadcrumb" />
	<asp:Button CssClass="w3-button" Text="Un-Register" OnClick="Index_Changed_unregister" runat="server" Font-Bold="True" Font-Size="16px"></asp:Button>
</div>
</asp:Content>


