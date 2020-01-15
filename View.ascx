<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="GIBS.Modules.GIBS_SSRS_Viewer.View" %>
<%@ Register Assembly=”Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91″ Namespace=”Microsoft.Reporting.WebForms” TagPrefix=”rsweb” %>

<h1>SSRS Viewer</h1>
<asp:ScriptManager runat=”server”></asp:ScriptManager>
  <rsweb:ReportViewer ID=”ReportViewer1″ runat=”server” ProcessingMode=”Remote” Width=”1200px” Height=”1200px”>
    <ServerReport ReportServerUrl=”http://sqlgibs/reportserver” ReportPath=”/HTC/SectionReport” />
  </rsweb:ReportViewer>