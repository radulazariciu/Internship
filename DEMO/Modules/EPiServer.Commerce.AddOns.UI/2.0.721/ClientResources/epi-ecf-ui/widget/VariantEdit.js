//>>built
require({cache:{"url:epi-ecf-ui/widget/templates/VariantEdit.html":"<div>\r\n    <div data-dojo-attach-point=\"toolbar\" data-dojo-type=\"epi-cms/contentediting/StandardToolbar\" class=\"epi-viewHeaderContainer epi-localToolbar\"></div>\r\n    <div data-dojo-attach-point=\"notificationBar\" data-dojo-type=\"epi-cms/contentediting/NotificationBar\" data-dojo-props=\"region:'top'\"></div>\r\n    \r\n    <div data-dojo-type=\"dijit/layout/ContentPane\" data-dojo-attach-point=\"contentPane\" class=\"epi-linkEdit\">\r\n        <h1>${resources.title}</h1>\r\n        <div data-dojo-attach-point=\"collectionList\" data-dojo-type=\"epi-ecf-ui/contentediting/editors/VariantCollectionEditor\"></div>\r\n        <div data-dojo-attach-point=\"dropContainer\" class=\"epi-content-area-actionscontainer\"></div>\r\n    </div>\r\n</div>"}});define("epi-ecf-ui/widget/VariantEdit",["dojo/aspect","dojo/_base/declare","dojo/_base/lang","dojo/topic","dijit/_TemplatedMixin","dijit/_WidgetsInTemplateMixin","epi/shell/widget/_ModelBindingMixin","epi/shell/dnd/Target","epi-cms/widget/Breadcrumb","epi-cms/widget/BreadcrumbCurrentItem","epi-cms/contentediting/editors/_TextWithActionLinksMixin","../contentediting/editors/VariantCollectionEditor","./_RelationViewBase","dojo/text!./templates/VariantEdit.html","epi/i18n!epi/cms/nls/commerce.contentediting.editors.variantcollectioneditor","epi-cms/contentediting/NotificationBar","epi-cms/contentediting/StandardToolbar"],function(_1,_2,_3,_4,_5,_6,_7,_8,_9,_a,_b,_c,_d,_e,_f){return _2([_d,_5,_6,_7,_b],{templateString:_e,_dndTarget:null,resources:_f,contentPane:this.contentPane,postCreate:function(){this.inherited(arguments);this.setupActionLinks(this.dropContainer);},buildRendering:function(){this.inherited(arguments);this._dndTarget=new _8(this.dropContainer,{accept:this.collectionList.allowedDndTypes,insertNodes:function(){}});this.own(_1.after(this._dndTarget,"onDropData",_3.hitch(this,function(_10){this.collectionList._addItem(_10[0],true);}),true));},updateView:function(_11,_12){this.inherited(arguments);this.set("value",_12.id);},getTemplateString:function(){return {templateString:this.resources.drophere,actions:this.resources.actions};},executeAction:function(_13){_4.publish("/epi/layout/pinnable/tools/toggle",true);},_setValueAttr:function(_14){this.collectionList.set("value",_14);}});});