﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesList.aspx.cs" Inherits="EmployeeManagementSystem.EmployeesList" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-image: linear-gradient(to right, red,orange,yellow,green,blue); ">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="EmployeeListGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <Columns>
                     <asp:TemplateField>
            <ItemTemplate>
                <asp:Button Text="Update" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" OnClick="UpdateEmp" />
            </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField>
             <ItemTemplate>
                <asp:Button Text="Delete" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" OnClick="DeleteEmp" />
            </ItemTemplate>
        </asp:TemplateField>
                </Columns>
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
           
        </asp:GridView>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:GridView ID="gvarray" runat="server" Width="328px">
     <Columns>
          <asp:TemplateField HeaderText="Select One">
              <ItemTemplate>
               <%-- <asp:Label ID = "rdoday" runat = "server" text = '<%# DataBinder.Eval (Container.DataItem, "Item") %>' />--%>

              </ItemTemplate>
          </asp:TemplateField>
     </Columns>
            </asp:GridView>
    </form>
</body>
</html>
