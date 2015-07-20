//>>built
require({cache:{"url:epi-cms/contentediting/templates/CreateContent.html":"<div class=\"epi-createContent\">\r\n    <div data-dojo-attach-point=\"layoutContainer\" data-dojo-type=\"dijit/layout/BorderContainer\" data-dojo-props=\"gutters: false, livesplitters: false\">\r\n        <div class=\"epi-static-node\" data-dojo-attach-point=\"topPanel\" data-dojo-type=\"dijit/layout/ContentPane\" data-dojo-props=\"region:'top'\">\r\n            <div data-dojo-attach-point=\"headingPanel\">\r\n                <h1><span data-dojo-attach-point=\"headingTextNode\"></span>:&nbsp;<span data-dojo-attach-point=\"contentTypeNameNode\"></span></h1>\r\n            </div>\r\n            <div data-dojo-attach-point=\"toolbar\" class=\"epi-localToolbar epi-viewHeaderContainer\" data-dojo-type=\"epi/shell/widget/ToolbarSet\" data-dojo-props=\"region:'top'\"></div>\r\n            <div data-dojo-attach-point=\"namePanel\">\r\n                <label>${sharedResources.header.name}</label>\r\n                <input data-dojo-attach-point=\"nameTextBox\" data-dojo-type=\"dijit/form/ValidationTextBox\" data-dojo-attach-event=\"onChange: _onContentNameChange\" maxlength=\"255\" />\r\n            </div>\r\n        </div>\r\n        <div class=\"epi-newContentContainer epi-animation-node\" data-dojo-attach-point=\"stackContainer\" data-dojo-type=\"dijit/layout/StackContainer\" data-dojo-props=\"region: 'center'\">\r\n            <div data-dojo-attach-point=\"contentTypeList\" data-dojo-type=\"epi-cms/widget/ContentTypeList\" data-dojo-attach-event=\"onContentTypeSelected: _onContentTypeSelected\">\r\n                <div data-dojo-attach-point='subHeadingPanel' class=\"push-padding--left\">\r\n                    <h1 data-dojo-attach-point=\"subHeadingTextNode\"></h1>\r\n                    <p data-dojo-attach-point=\"subHeadingDescNode\"></p>\r\n                </div>\r\n            </div>\r\n            <div data-dojo-attach-point=\"propertiesForm\" data-dojo-type=\"epi-cms/widget/PropertiesForm\" data-dojo-attach-event=\"onPropertyValidStateChange: _onPropertyValidStateChange\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"}});define("epi-cms/contentediting/CreateContent",["dojo/_base/declare","dojo/_base/lang","dojo/aspect","dojo/dom-style","dojo/dom-class","dojo/topic","dojo/when","dijit/_TemplatedMixin","dijit/_WidgetsInTemplateMixin","dijit/form/ValidationTextBox","dijit/layout/_LayoutWidget","dijit/layout/BorderContainer","dijit/layout/ContentPane","dijit/layout/StackContainer","epi/dependency","epi/shell/widget/_ModelBindingMixin","epi/shell/widget/dialog/Dialog","epi-cms/contentediting/NewContentNameInputDialog","epi-cms/contentediting/viewmodel/CreateContentViewModel","epi-cms/widget/ContentTypeList","epi-cms/widget/PropertiesForm","epi-cms/widget/Breadcrumb","epi-cms/widget/BreadcrumbCurrentItem","dojo/text!./templates/CreateContent.html","epi/i18n!epi/nls/episerver.shared"],function(_1,_2,_3,_4,_5,_6,_7,_8,_9,_a,_b,_c,_d,_e,_f,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19){return _1([_b,_8,_9,_10],{templateString:_18,sharedResources:_19,modelType:_13,_contextService:null,_beingSuspended:null,modelBindingMap:{"parent":["parent"],"requestedType":["requestedType"],"metadata":["metadata"],"isContentTypeSelected":["isContentTypeSelected"],"headingText":["headingText"],"createAsLocalAssetHelpText":["createAsLocalAssetHelpText"],"contentName":["contentName"],"wizardStep":["wizardStep"],"showAllProperties":["showAllProperties"],"createAsLocalAsset":["createAsLocalAsset"],"seamlessTopPanel":["seamlessTopPanel"],"namePanelIsVisible":["namePanelIsVisible"],"headingPanelIsVisible":["headingPanelIsVisible"],"saveButtonIsVisible":["saveButtonIsVisible"],"saveButtonDisabled":["saveButtonDisabled"],"showCurrentNodeOnBreadcrumb":["showCurrentNodeOnBreadcrumb"],"notificationContext":["notificationContext"],"actualParentLink":["actualParentLink"],"propertyFilter":["propertyFilter"]},_setParentAttr:function(_1a){if(_1a){this.toolbar.setItemProperty("currentcontent","currentItemInfo",{name:_1a.name,dataType:_1a.typeIdentifier});}},_setPropertyFilterAttr:function(_1b){this._set("propertyFilter",_1b);this.propertiesForm.propertyFilter=_1b;},_setRequestedTypeAttr:function(_1c){this.contentTypeList.set("requestedType",_1c);},_setMetadataAttr:function(_1d){if(_1d){this.propertiesForm.set("metadata",_1d);}},_setHeadingTextAttr:function(_1e){this.headingTextNode.innerHTML=this.subHeadingTextNode.innerHTML=_1e;},_setCreateAsLocalAssetAttr:function(_1f){this._set("createAsLocalAsset",_1f);var _20=this.model.get("parent");if(_20){this.toolbar.setItemProperty("breadcrumbs","contentLink",_1f&&this.model.canChangeLocalAssetName?_20.assetsFolderLink:_20.contentLink);}},_setCreateAsLocalAssetHelpTextAttr:{node:"subHeadingDescNode",type:"innerHTML"},_setContentNameAttr:function(_21){this.nameTextBox.set("value",_21);},_setWizardStepAttr:function(_22){var _23;var _24;if(_22<0||_22===this.wizardStep){return;}_23=this.stackContainer.getChildren();if(_22<_23.length){_24=_23[_22];this.stackContainer.selectChild(_24);this._set("wizardStep",_22);}},_setShowAllPropertiesAttr:function(_25){this._set("showAllProperties",_25);this.propertiesForm.set("showAllProperties",_25);},_setSeamlessTopPanelAttr:function(_26){_5.toggle(this.topPanel.domNode,"epi-listingTopContainer",_26);},_setNamePanelIsVisibleAttr:function(_27){_4.set(this.namePanel,"display",_27?"":"none");},_setHeadingPanelIsVisibleAttr:function(_28){_4.set(this.headingPanel,"display",_28?"":"none");_4.set(this.subHeadingPanel,"display",_28?"none":"");},_setSaveButtonIsVisibleAttr:function(_29){this.toolbar.setItemVisibility("saveButton",_29);},_setSaveButtonDisabledAttr:function(_2a){this.toolbar.setItemProperty("saveButton","disabled",_2a);},_setShowCurrentNodeOnBreadcrumbAttr:function(_2b){this.toolbar.setItemProperty("breadcrumbs","showCurrentNode",_2b);this.toolbar.setItemVisibility("currentcontent",!_2b);},_setNotificationContextAttr:function(_2c){this.toolbar.setItemProperty("notificationCenter","notificationContext",_2c);},_setActualParentLinkAttr:function(_2d){this.contentTypeList.set("parentLink",_2d);},_setContentTypeNameAttr:{type:"innerHTML",node:"contentTypeNameNode"},postMixInProperties:function(){this.inherited(arguments);this.model=new this.modelType();this.own(this.model.on("saveSuccess",_2.hitch(this,this._onSaveSuccess)));this.own(this.model.on("saveError",_2.hitch(this,this._onSaveError)));this.own(this.model.on("invalidContentName",_2.hitch(this,this._onInvalidContentName)));},postCreate:function(){this.inherited(arguments);this._contextService=this._contextService||_f.resolve("epi.shell.ContextService");this._setupToolbar();},layout:function(){if(this._started){this.layoutContainer.resize(this._containerContentBox||this._contentBox);_5.add(this.stackContainer.domNode,"epi-animation-node-reset");}},updateView:function(_2e){this.view=_2e.view;this._setCreateMode();this._beingSuspended=false;this.set("contentTypeName","");_7(this.model.update(_2e),_2.hitch(this,function(){this.layout();}),function(err){});},_onSaveSuccess:function(_2f){this._clearCreateMode();this._beingSuspended=true;if(_2f.changeContext){this._changeContext(_2f.newContentLink);}else{this._backToCurrentContext();}if(this.createAsLocalAsset===true){_6.publish("/epi/cms/action/createlocalasset");}},_onSaveError:function(){this._clearCreateMode();_6.publish("/epi/cms/action/showerror");},_onInvalidContentName:function(_30){var _31=new _12({defaultContentName:_30});var _32=new _11({defaultActionsVisible:false,content:_31,title:_31.title,destroyOnHide:true});this.own(_3.after(_32,"onExecute",_2.hitch(this,function(){var _33=_31.get("value");if(_33===_30){this.model.set("ignoreDefaultNameWarning",true);}this.model.set("contentName",_33);this.model.save();}),true),_3.after(_32,"onCancel",_2.hitch(this,function(){if(this.contentTypeList.shouldSkipContentTypeSelection){this._cancel();}else{this.model.set("isContentTypeSelected",false);}}),true));_32.show();},_onContentTypeSelected:function(_34){if(!this.isContentTypeSelected){this.model.set("contentTypeId",_34.id);this.set("contentTypeName",_34.name);}},_onPropertyValidStateChange:function(_35,_36){if(_36){this.model.addInvalidProperty(_35,_36);}else{this.model.removeInvalidProperty(_35);}},_onContentNameChange:function(_37){this.model.set("contentName",_37);},_onSave:function(){if(this._beingSuspended){return;}this.propertiesForm.validate();this.model.set("properties",this.propertiesForm.get("value"));this.model.save();},_onCancel:function(){this._cancel();},_cancel:function(){this._clearCreateMode();this.model.cancel();this._backToCurrentContext();},_setupToolbar:function(){var _38=[{name:"leading",type:"toolbargroup",settings:{region:"leading"}},{name:"trailing",type:"toolbargroup",settings:{region:"trailing"}}];var _39=[{parent:"leading",name:"breadcrumbs",widgetType:"epi-cms/widget/Breadcrumb",settings:{showCurrentNode:false}},{parent:"leading",name:"currentcontent",widgetType:"epi-cms/widget/BreadcrumbCurrentItem"},{parent:"trailing",name:"notificationCenter",widgetType:"epi-cms/widget/NotificationStatusBar"},{parent:"trailing",name:"saveButton",title:_19.action.create,label:_19.action.create,type:"button",action:_2.hitch(this,this._onSave),settings:{"class":"epi-boldButton Salt"}},{parent:"trailing",name:"cancelButton",title:_19.action.cancel,label:_19.action.cancel,type:"button",action:_2.hitch(this,this._onCancel),settings:{"class":"epi-boldButton"}}];_7(this.toolbar.add(_38),_2.hitch(this,function(){this.toolbar.add(_39);}));},_changeContext:function(_3a){_6.publish("/epi/shell/context/request",{uri:"epi.cms.contentdata:///"+_3a},{sender:this,viewName:this.view,forceContextChange:true});},_backToCurrentContext:function(){_6.publish("/epi/shell/action/changeview/back");},_setCreateMode:function(){_2.mixin(this._contextService.currentContext,{"currentMode":"create"});_6.publish("/epi/cms/action/togglecreatemode",true);},_clearCreateMode:function(){_5.remove(this.stackContainer.domNode,"epi-animation-node-reset");_2.mixin(this._contextService.currentContext,{"currentMode":undefined});_6.publish("/epi/cms/action/togglecreatemode",false);}});});