﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true"
    CodeFile="MachinePing.aspx.cs" Inherits="Pages_MachinePing" %>

<%@ Register Src="~/Control/MachineSideMenu.ascx" TagName="MachineSideMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <uc1:MachineSideMenu ID="SideMenu" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:UpdatePanel ID="upnlMain" runat="server">
        <ContentTemplate>
            <div id="pageDiv" runat="server">
                <table align="left" width="100%" dir="ltr">
                    <tr>
                        <td>
                            <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                DataKeyNames="MacID" CssClass="vGrid" GridLines="Horizontal" Width="100%"
                                AllowPaging="True" AllowSorting="false" HorizontalAlign="Center" OnDataBound="grdData_DataBound"
                                OnRowDataBound="grdData_RowDataBound" OnSorting="grdData_Sorting" OnRowCreated="grdData_RowCreated"
                                OnPageIndexChanging="grdData_PageIndexChanging" ShowFooter="True">
                                <Columns>
                                    <asp:BoundField DataField="IPAddress" HeaderText="IP Address" SortExpression="IPAddress">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="MachineNo" HeaderText="Machine No." SortExpression="MachineNo">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LocationAr" HeaderText="Location (Ar)" SortExpression="LocationAr">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LocationEn" HeaderText="Location (En)" SortExpression="LocationEn">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <asp:Image ID="imgMacStatus" runat="server" ImageUrl="" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    </asp:TemplateField>
                                    <%--<asp:TemplateField HeaderText="Status" SortExpression="UsrStatusText">
                                            <ItemTemplate>
                                                <%# getStatus(Eval("UsrStatus"))%>
                                            </ItemTemplate>
                                            
                                        </asp:TemplateField>--%>
                                </Columns>
                                <HeaderStyle CssClass="header" />
                                <FooterStyle CssClass="footer" />
                                <PagerStyle CssClass="pgr" />
                                <SelectedRowStyle CssClass="selected" />
                                <AlternatingRowStyle CssClass="alt" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
