//>>built
define("epi-ecf-ui/contentediting/viewmodel/AssociationCollectionEditorModel",["dojo/_base/declare","dojo/_base/lang","dojo/when","./_BaseEntryCollectionEditorModel","epi/i18n!epi/cms/nls/commerce.contentediting.editors.associationcollectioneditor"],function(_1,_2,_3,_4,_5){return _1([_4],{storeKey:"epi.commerce.association",resources:_5,saveItem:function(_6){var _7=_3(this.store.get(_6.id),_2.hitch(this,function(_8){if(_8.groupName==_6.groupName&&_8.type==_6.type){return this.store.put(_6);}else{var _9=_2.clone(_6);delete _9.id;return _3(this.store.remove(_8.id),_2.hitch(this,function(){return this.store.add(_9);}));}}));_3(_7,_2.hitch(this,function(_a){this.emit("itemSaved",{id:_a.id});}));return _7;}});});