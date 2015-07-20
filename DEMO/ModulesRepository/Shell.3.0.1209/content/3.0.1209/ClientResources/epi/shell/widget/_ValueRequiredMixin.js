//>>built
define("epi/shell/widget/_ValueRequiredMixin",["dojo/_base/declare","dojo/_base/lang","dijit/_CssStateMixin","dijit/Tooltip"],function(_1,_2,_3,_4){return _1([_3],{required:null,missingMessage:"",destroy:function(){this.displayMessage(null);this.inherited(arguments);},_onFocus:function(){this.inherited(arguments);this.validate();},_onBlur:function(){this.inherited(arguments);this.validate();},validate:function(_5){var _6=this.isValid(_5);this.set("state",_6?"":"Error");this.set("message",this.getErrorMessage(_5));this.displayMessage(_6?"":this.getErrorMessage());return _6;},isValid:function(_7){return (!this.required||this.value||this.value===0||(_2.isArray(this.value)&&this.value.length===0));},displayMessage:function(_8){var _9=this.tooltipNode||this.domNode;if(_8&&this.focused&&!this.isShowingChildDialog){_4.show(_8,_9,this.tooltipPosition,!this.isLeftToRight());}else{_4.hide(_9);}},getErrorMessage:function(_a){var _b=this.get("state")!=="Error";return _b?"":this.missingMessage;}});});