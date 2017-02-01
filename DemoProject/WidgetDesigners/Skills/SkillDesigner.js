Type.registerNamespace("SitefinityWebApp.WidgetDesigners.Skills");

SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner = function (element) {
    /* Initialize Skill_1 fields */
    this._skill_1 = null;
    
    /* Initialize Percentage_1 fields */
    this._percentage_1 = null;
    
    /* Initialize Skill_2 fields */
    this._skill_2 = null;
    
    /* Initialize Percentage_2 fields */
    this._percentage_2 = null;
    
    /* Calls the base constructor */
    SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {
        var controlData = this._propertyEditor.get_control().Settings; /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI Skill_1 */
        jQuery(this.get_skill_1()).val(controlData.Skill_1);

        /* RefreshUI Percentage_1 */
        jQuery(this.get_percentage_1()).val(controlData.Percentage_1);

        /* RefreshUI Skill_2 */
        jQuery(this.get_skill_2()).val(controlData.Skill_2);

        /* RefreshUI Percentage_2 */
        jQuery(this.get_percentage_2()).val(controlData.Percentage_2);
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control().Settings;

        /* ApplyChanges Skill_1 */
        controlData.Skill_1 = jQuery(this.get_skill_1()).val();

        /* ApplyChanges Percentage_1 */
        controlData.Percentage_1 = jQuery(this.get_percentage_1()).val();

        /* ApplyChanges Skill_2 */
        controlData.Skill_2 = jQuery(this.get_skill_2()).val();

        /* ApplyChanges Percentage_2 */
        controlData.Percentage_2 = jQuery(this.get_percentage_2()).val();
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */

    /* Skill_1 properties */
    get_skill_1: function () { return this._skill_1; }, 
    set_skill_1: function (value) { this._skill_1 = value; },

    /* Percentage_1 properties */
    get_percentage_1: function () { return this._percentage_1; }, 
    set_percentage_1: function (value) { this._percentage_1 = value; },

    /* Skill_2 properties */
    get_skill_2: function () { return this._skill_2; }, 
    set_skill_2: function (value) { this._skill_2 = value; },

    /* Percentage_2 properties */
    get_percentage_2: function () { return this._percentage_2; }, 
    set_percentage_2: function (value) { this._percentage_2 = value; }
}

SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner.registerClass('SitefinityWebApp.WidgetDesigners.Skills.SkillDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);
