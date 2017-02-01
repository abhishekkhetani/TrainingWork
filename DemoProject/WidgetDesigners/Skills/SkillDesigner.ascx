<%@ Control %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sf" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sfFields" Namespace="Telerik.Sitefinity.Web.UI.Fields" %>

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server">
    <sitefinity:ResourceFile Name="Styles/Ajax.css" />
</sitefinity:ResourceLinks>
<div id="designerLayoutRoot" class="sfContentViews sfSingleContentView" style="max-height: 400px; overflow: auto; ">
<ol>        
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="Skill_1" CssClass="sfTxtLbl">Skill_1</asp:Label>
    <asp:TextBox ID="Skill_1" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="Percentage_1" CssClass="sfTxtLbl">Percentage_1</asp:Label>
    <asp:TextBox ID="Percentage_1" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="Skill_2" CssClass="sfTxtLbl">Skill_2</asp:Label>
    <asp:TextBox ID="Skill_2" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="Percentage_2" CssClass="sfTxtLbl">Percentage_2</asp:Label>
    <asp:TextBox ID="Percentage_2" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
</ol>
</div>
