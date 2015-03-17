<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_1_2_kassakvitto._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Receiptenator</title>
    <link type="text/css" rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
        <asp:TextBox ID="Price" runat="server"></asp:TextBox> kr<br />
        <asp:Button ID="Button1" runat="server" Text="Calculate price" OnClick="Button1_Click" />
        <asp:CompareValidator runat="server" ID="CompareValidator1" runat="server" ErrorMessage="Price must be a number bigger than 0" ControlToValidate="price" Type="Double" ValueToCompare="0" Operator="GreaterThan"  Display="None"></asp:CompareValidator>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" runat="server" ErrorMessage="You must enter a price" ControlToValidate="price" Display="None"></asp:RequiredFieldValidator>
        <asp:Placeholder runat="server" ID="Receipt" Visible="false">
            <div class="receipt">
                <h2>Receipt</h2>
                <hr />
                <div>Subtotal:<asp:Label runat="server" ID="Subtotal" CssClass="right kr"></asp:Label></div>
                <div>Discount:<asp:Label runat="server" ID="Discount" CssClass="right percent"></asp:Label></div>
                <div>Money off:<asp:Label runat="server" ID="MoneyOff" CssClass="right kr"></asp:Label></div>
                <div>Total:<asp:Label runat="server" ID="Total" CssClass="right kr"></asp:Label></div>
                <hr />
                Please come again!
            </div>
        </asp:Placeholder>
    </div>
    </form>
</body>
</html>
