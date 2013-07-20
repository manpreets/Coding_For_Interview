﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="JCropImageUpload.UploadImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="css/jquery.Jcrop.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3/jquery.min.js"></script>
        <script type="text/javascript" src="js/jquery.Jcrop.pack.js"></script>    <script type="text/javascript">
        jQuery(document).ready(function () {
            jQuery('#imgCrop').Jcrop({
                onSelect: storeCoords
            });
        });

        function storeCoords(c) {
            jQuery('#X').val(c.x);
            jQuery('#Y').val(c.y);
            jQuery('#W').val(c.w);
            jQuery('#H').val(c.h);
        };

</script></head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="pnlUpload" runat="server">
      <asp:FileUpload ID="Upload" runat="server" />
      <br />
      <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
      <asp:Label ID="lblError" runat="server" Visible="false" />
    </asp:Panel>
    <asp:Panel ID="pnlCrop" runat="server" Visible="false">
      <asp:Image ID="imgCrop" runat="server" />
      <br />
      <asp:HiddenField ID="X" runat="server" />
      <asp:HiddenField ID="Y" runat="server" />
      <asp:HiddenField ID="W" runat="server" />
      <asp:HiddenField ID="H" runat="server" />
      <asp:Button ID="btnCrop" runat="server" Text="Crop" OnClick="btnCrop_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlCropped" runat="server" Visible="false">
      <asp:Image ID="imgCropped" runat="server" />
    </asp:Panel>
  </div>
    </form>
</body>
</html>
