<%@ Page Trace="true" Title="Home Page"  Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    AsyncTimeout="10"
    CodeBehind="Default.aspx.cs" Inherits="PageAsyncTaskDemo._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        PageTaskAsync demo
    </h2>
    <div>
      <span id="TaskMessage" runat="server">
      </span>
    </div>
</asp:Content>
