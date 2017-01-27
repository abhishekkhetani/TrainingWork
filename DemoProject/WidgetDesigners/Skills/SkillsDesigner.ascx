<%@ Control %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sf" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sfFields" Namespace="Telerik.Sitefinity.Web.UI.Fields" %>

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server">
    <sitefinity:ResourceFile Name="Styles/Ajax.css" />
</sitefinity:ResourceLinks>
<div id="designerLayoutRoot" class="sfContentViews sfSingleContentView" style="max-height: 400px; overflow: auto;">
    <ol>
        <li class="sfFormCtrl">
            <asp:Label runat="server" AssociatedControlID="TxtSkill_1" CssClass="sfTxtLbl">Skill 1</asp:Label>
            <asp:TextBox ID="TxtSkill_1" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Skill to be displayed</div>

            <asp:Label runat="server" AssociatedControlID="TxtPer_1" CssClass="sfTxtLbl">Percentage 1</asp:Label>
            <asp:TextBox ID="TxtPer_1" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Percentage to be displayed</div>
        </li>
    </ol>
    <ol>
        <li class="sfFormCtrl">
            <asp:Label runat="server" AssociatedControlID="TxtSkill_2" CssClass="sfTxtLbl">Skill 2</asp:Label>
            <asp:TextBox ID="TxtSkill_2" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Skill to be displayed</div>

            <asp:Label runat="server" AssociatedControlID="TxtPer_2" CssClass="sfTxtLbl">Percentage 2</asp:Label>
            <asp:TextBox ID="TxtPer_2" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Percentage to be displayed</div>
        </li>
    </ol>
    <ol>
        <li class="sfFormCtrl">
            <asp:Label runat="server" AssociatedControlID="TxtSkill_3" CssClass="sfTxtLbl">Skill 3</asp:Label>
            <asp:TextBox ID="TxtSkill_3" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Skill to be displayed</div>

            <asp:Label runat="server" AssociatedControlID="TxtPer_3" CssClass="sfTxtLbl">Percentage 3</asp:Label>
            <asp:TextBox ID="TxtPer_3" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Percentage to be displayed</div>
        </li>
    </ol>
    <ol>
        <li class="sfFormCtrl">
            <asp:Label runat="server" AssociatedControlID="TxtSkill_4" CssClass="sfTxtLbl">Skill 4</asp:Label>
            <asp:TextBox ID="TxtSkill_4" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Skill to be displayed</div>

            <asp:Label runat="server" AssociatedControlID="TxtPer_4" CssClass="sfTxtLbl">Percentage 4</asp:Label>
            <asp:TextBox ID="TxtPer_4" runat="server" CssClass="sfTxt" />
            <div class="sfExample">The Percentage to be displayed</div>
        </li>
    </ol>
</div>
