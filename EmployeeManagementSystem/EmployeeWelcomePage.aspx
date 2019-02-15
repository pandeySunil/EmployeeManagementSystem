<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeWelcomePage.aspx.cs" Inherits="EmployeeManagementSystem.EmployeeWelcomePage" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <!DOCTYPE html>
   
   <head>
        <title>Registration Page</title>
   </head>
   <body>
        <form id="f1" method="post" runat="server" class="" >
            <fieldset class="form-table">
            <legend>Registration Form</legend>
            <table style="margin:0 auto" >            
                <tr>
                     <td>First Name:</td><td> <asp:textbox id="txtFristName" runat="server" ></asp:textbox></td>
                     <td> <asp:RequiredFieldValidator ID="validfname" runat="server" ControlToValidate="txtFristName" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Last Name:</td><td> <asp:textbox id="txtLastName" runat="server" ></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validlname" runat="server" ControlToValidate="txtLastName" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>User Name:</td><td> <asp:textbox id="txtUserName" runat="server"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validuser" runat="server" ControlToValidate="txtUserName" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Password:</td><td><asp:textbox ID="txtPwd" runat="server" TextMode="Password"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validpwd" runat="server" ControlToValidate="txtPwd" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Confirm Password:</td><td><asp:textbox ID="Textbox1" runat="server" TextMode="Password"></asp:textbox></td>
                </tr>
                <tr>
                    <td>Email:</td><td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="validemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Mobile:</td><td><asp:TextBox ID="txtMobile" runat="server" TextMode ="Phone"></asp:TextBox></td>
                </tr>
                <tr>                    
                    <td>Gender:</td><td><asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Text="Male" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                                             </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td>DOB: </td><td><asp:TextBox ID="txtDob" runat="server" TextMode="Date" Width="168px"></asp:TextBox> </td>
                    <td><asp:RequiredFieldValidator ID="validdob" runat="server" ControlToValidate="txtDob" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>                
                <tr>
                    <td>State: </td><td><asp:DropDownList CssClass="drp-state" ID="drpState" runat="server" datavaluefield="Course" Width="173px">
                        <asp:ListItem Text="Maharashtra" Value="Maharashtra"></asp:ListItem>
                        <asp:ListItem Text="Telangana" Value="Telangana"></asp:ListItem>
                                         </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator InitialValue="-1" ID="validcourse" runat="server" ControlToValidate="drpState" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>City: </td><td><asp:DropDownList CssClass="drp-city" ID="drpCity" runat="server" datavaluefield="Course" Width="173px">
                       <asp:ListItem Text="Nagpur" Value="Nagpur"></asp:ListItem>
                        <asp:ListItem Text="Hyedrabad" Value="Hyedrabad"></asp:ListItem>
                        <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>
                                         </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator1" runat="server" ControlToValidate="drpCity" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <td>Nationality:</td><td><asp:CheckBox ID="checkNationality" Text="Indian" runat="server"/><asp:CheckBox id="checkNat" Text="Others" runat="server" /></td>
                 </tr>
                <tr>
                    <td>Profile: </td><td><asp:Image id="img" ImageUrl="images/new/new-member.png" runat="server" /></td>
                </tr>
                <tr>
                    <td></td><td><asp:FileUpload ID="imgupload" runat="server" Enabled="true" /></td>
                </tr>
               <tr>
                    <td><asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click"></asp:Button></td>
                    <td><asp:Button ID="btn2" runat="server" Text="Reset"></asp:Button></td>
                </tr>                
            </table>
          </fieldset>
       </form>
    </body>
    <style>
    .form-table {
        margin:0 auto;
        border:1px solid;
        border-color:aqua;
        border-radius:2px ;
        box-shadow:2px 2px 2px 2px;
        width:50%;
    }
        input {
            border-radius: 5px;
            height: 28px;
        }
        .drp-state {
            border-radius: 5px;
            height: 28px
        }
        .drp-city {
            border-radius: 5px;
            height: 28px
        }

</style>
</asp:Content>

