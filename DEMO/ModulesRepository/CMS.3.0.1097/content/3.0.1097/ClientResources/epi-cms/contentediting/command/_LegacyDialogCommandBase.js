//>>built
define("epi-cms/contentediting/command/_LegacyDialogCommandBase",["dojo/_base/declare","dojo/_base/lang","dojo/promise/all","dojo/topic","epi/routes","epi/shell/command/_Command","epi/UriParser","epi-cms/core/ContentReference","epi-cms/legacy/LegacyDialogPopup"],function(_1,_2,_3,_4,_5,_6,_7,_8,_9){return _1([_6],{dialogPath:null,raiseCloseEvent:null,routeParams:null,dialogParams:null,canExecute:true,getContentReference:function(_a){var _b=_2.getObject("model.contentData.contentLink",false,this),_c=_b?new _8(_b):null;if(_c){_c=_a?_c.toString():_c.createVersionUnspecificReference().toString();}return _c;},getRouteParams:function(){return {"id":this.getContentReference(),path:this.dialogPath,moduleArea:"LegacyCMS",IsInLegacyWrapper:true};},getDialogParams:function(){return {};},_createDialog:function(_d,_e){var _f={url:_5.getActionPath(_e),dialogArguments:window.document,autoFit:true,destroyOnHide:true,onClose:_2.hitch(this,function(){var _10=this.getContentReference();if(this.raiseCloseEvent&&_10){_4.publish("/epi/cms/contentdata/updated",{contentLink:_10,recursive:true});}})};return new _9(_2.mixin({},_f,_d));},_execute:function(){_3([this.getDialogParams(),this.getRouteParams()]).then(_2.hitch(this,function(_11){var _12=this._createDialog.apply(this,_11);_12.show();}));}});});