//>>built
define("epi-ecf-ui/command/PasteCatalogContent",["dojo/_base/declare","epi/shell/TypeDescriptorManager","epi-cms/command/PasteContent","../contentediting/ModelSupport"],function(_1,_2,_3,_4){return _1([_3],{typeDescriptorManager:_2,_onModelChange:function(){var _5=this.get("selectionData");if(_5&&this._typeIsAssignableFrom(_5.typeIdentifier,_4.contentTypeIdentifier.nodeContentBase)){this.inherited(arguments);this.set("isAvailable",true);return;}this._hideCommand();},_typeIsAssignableFrom:function(_6,_7){return this.typeDescriptorManager.isBaseTypeIdentifier(_6,_7);},_hideCommand:function(){this.set("isAvailable",false);}});});