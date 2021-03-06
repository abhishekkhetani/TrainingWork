Type.registerNamespace("SitefinityWebApp.WidgetDesigners.Skills");

SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner = function (element) {
    /* Initialize Skill_1 fields */
    this._skill_1 = null;
    
    /* Initialize Percentage_1 fields */
    this._percentage_1 = null;
    
    /* Initialize Skill_2 fields */
    this._skill_2 = null;
    
    /* Initialize Percentage_2 fields */
    this._percentage_2 = null;
    
    /* Initialize Skill_3 fields */
    this._skill_3 = null;
    
    /* Initialize Percentage_3 fields */
    this._percentage_3 = null;
    
    /* Initialize Skill_4 fields */
    this._skill_4 = null;
    
    /* Initialize Percentage_4 fields */
    this._percentage_4 = null;
    
    /* Calls the base constructor */
    SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner.callBaseMethod(this, 'dispose');
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

        /* RefreshUI Skill_3 */
        jQuery(this.get_skill_3()).val(controlData.Skill_3);

        /* RefreshUI Percentage_3 */
        jQuery(this.get_percentage_3()).val(controlData.Percentage_3);

        /* RefreshUI Skill_4 */
        jQuery(this.get_skill_4()).val(controlData.Skill_4);

        /* RefreshUI Percentage_4 */
        jQuery(this.get_percentage_4()).val(controlData.Percentage_4);
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

        /* ApplyChanges Skill_3 */
        controlData.Skill_3 = jQuery(this.get_skill_3()).val();

        /* ApplyChanges Percentage_3 */
        controlData.Percentage_3 = jQuery(this.get_percentage_3()).val();

        /* ApplyChanges Skill_4 */
        controlData.Skill_4 = jQuery(this.get_skill_4()).val();

        /* ApplyChanges Percentage_4 */
        controlData.Percentage_4 = jQuery(this.get_percentage_4()).val();
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
    set_percentage_2: function (value) { this._percentage_2 = value; },

    /* Skill_3 properties */
    get_skill_3: function () { return this._skill_3; }, 
    set_skill_3: function (value) { this._skill_3 = value; },

    /* Percentage_3 properties */
    get_percentage_3: function () { return this._percentage_3; }, 
    set_percentage_3: function (value) { this._percentage_3 = value; },

    /* Skill_4 properties */
    get_skill_4: function () { return this._skill_4; }, 
    set_skill_4: function (value) { this._skill_4 = value; },

    /* Percentage_4 properties */
    get_percentage_4: function () { return this._percentage_4; }, 
    set_percentage_4: function (value) { this._percentage_4 = value; }
}

SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner.registerClass('SitefinityWebApp.WidgetDesigners.Skills.SkillsDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);
