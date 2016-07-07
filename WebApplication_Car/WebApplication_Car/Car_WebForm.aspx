<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Car_WebForm.aspx.cs" Inherits="WebApplication_Car.Car_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Cars</title>
    <script src="scripts/MyJavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Add New Car</h3>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
           
        <table style="height: 504px; width: 388px">
            
            <tr>
                <td>
                    Company:
                </td>

                <td>
                    
                    <asp:DropDownList 
                        ID="ddlCompany" 
                        runat="server"  
                        Width="200px"
                        AutoPostBack="true" 
                        OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged">                       
                    </asp:DropDownList>
                </td>

             </tr>

             <tr>
                <td colspan="2"></td>
              </tr>



             <tr>
                <td>
                    Model:
                </td>

                <td>                    
                    <asp:DropDownList ID="ddlModel" runat="server" Width="200px"></asp:DropDownList>
                </td>

             </tr>

             <tr>
                <td colspan="2"></td>
              </tr>

            <tr>
                <td>
                    Year:
                </td>

                <td>
                    <asp:TextBox ID="txtYear" runat="server" Width="200px"></asp:TextBox>
                </td>

             </tr>

             <tr>
                <td colspan="2"></td>
              </tr>


            <tr>
                <td>
                    EngineSize:
                </td>

                <td>
                    <asp:TextBox ID="txtEngineSize" runat="server" Width="200px"></asp:TextBox>
                </td>

             </tr>

             <tr>
                <td colspan="2"></td>
              </tr>


            <tr>
                <td>
                    Price:
                </td>

                <td>
                    <asp:TextBox ID="txtPrice" runat="server" Width="200px"></asp:TextBox>
                </td>

             </tr>

             <tr>
                <td colspan="2"></td>
              </tr>


            <tr >
                    <td colspan="2"  >
                        <asp:Button ID="btnAddCar" runat="server"   Text="Add" OnClientClick="return CheckClientData();" OnClick="btnAddCar_Click"  />
                        
                        <asp:Button ID="btnFindCar" runat="server"   Text="Add"  OnClick="btnFindCar_Click"  />
                        <br />
                    </td> 
            </tr>

                <tr>
                    <td class="lblConfirm"  colspan="2" >
                        <asp:Label ID="lblAddCarStatus" CssClass="lblConfirm" runat="server" Text=""></asp:Label>
                    </td>
                </tr>               
                
            <tr>
                <td colspan="2">
                    <asp:ListBox ID="lstResult" runat="server" Width="400px" Height="200" ViewStateMode="Disabled"  ></asp:ListBox>
                </td>
            </tr>
        </table>
 </ContentTemplate>
 </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
