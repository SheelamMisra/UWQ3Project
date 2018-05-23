<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllClasses.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<asp:GridView id="gvAllClasses" runat="server" BackColor="Black" Width="1126px" AllowSorting="True" CellPadding="15" CellSpacing="15" Font-Size="12pt"  >
		<AlternatingRowStyle BackColor="#666666" Font-Bold="False" />
		<HeaderStyle Font-Bold="True" Font-Size="12pt" Font-Underline="True" />
	</asp:GridView>
</asp:Content>

