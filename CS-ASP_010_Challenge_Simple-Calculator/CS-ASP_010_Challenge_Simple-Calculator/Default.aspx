<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_010_Challenge_Simple_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
    
    </div>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractionButton" runat="server" OnClick="subtractionButton_Click" style="width: 18px" Text="-" />
&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" OnClick="multiplicationButton_Click" style="height: 26px" Text="*" />
&nbsp;
            <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="/" />
        </p>
        <asp:Label ID="resultLabel" runat="server" BackColor="#33CCFF" style="font-weight: 700; font-size: medium"></asp:Label>
    </form>
</body>
</html>
