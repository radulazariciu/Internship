//>>built
define("epi/shell/layout/SimpleContainer",["dojo/_base/array","dojo/_base/declare","dojo/_base/lang","dojo/dom-class","dojo/dom-construct","dojo/dom-style","dijit/_WidgetBase","dijit/_Container","dijit/_Contained","dijit/_TemplatedMixin","dijit/layout/_LayoutWidget","dijit/form/_FormWidget","epi/shell/widget/CheckBox"],function(_1,_2,_3,_4,_5,_6,_7,_8,_9,_a,_b,_c,_d){var _e=_2([_7,_8,_9,_a],{templateString:"<li class='epi-parentContainer'><div class='epi-formsWidgetWrapper' data-dojo-attach-point='containerNode'></div></li>"});var _f=_2([_7,_8,_9,_a],{templateString:"<li><div class='epi-formsWidgetWrapper' data-dojo-attach-point='containerNode'></div></li>"});return _2([_b,_a],{templateString:"<div class=\"epi-containerLayout clearfix\"><ul data-dojo-attach-point=\"containerNode\"></ul></div>",_FieldItem:_2([_7,_8,_9,_a],{templateString:"<li class='epi-formsRow' data-dojo-attach-point='containerNodeWrapper'>                            <label for='${labelTarget}' title='${tooltip}'>                                <span class='dijitInline dijitReset dijitIcon epi-iconPenDisabled' data-dojo-attach-point='readonlyIcon'></span>${label}                            </label>                            <div class='epi-formsWidgetWrapper' data-dojo-attach-point='containerNode'></div>                        </li>",_setReadonlyIconDisplayAttr:function(_10){_6.set(this.readonlyIcon,"display",_10===true?"":"none");},_setHasFullWidthValueAttr:function(_11){if(_11){_4.add(this.containerNodeWrapper,"epi-formsRow--fullWidthValue");}}}),_HiddenFieldItem:_2([_7,_8,_9,_a],{templateString:"<li class='epi-formsRow'><div class='epi-formsWidgetWrapper' data-dojo-attach-point='containerNode'></div></li>"}),addChild:function(_12){var _13;switch(_12._type){case "field":_13=new this._FieldItem({labelTarget:_12.checkbox?_12.checkbox.id:_12.id,label:_12.label,tooltip:_12.tooltip,readonlyIconDisplay:_12.readOnly,hasFullWidthValue:_12.useFullWidth});this.own(_12.watch("readOnly",function(_14,_15,_16){_13.set("readonlyIconDisplay",_16);}));break;case "hiddenfield":_13=new this._HiddenFieldItem();break;case "parent":_13=new _e();break;case "group":_13=new _f();break;}this._addChildToWrapper(_13,_12);this.own(_13);return this.inherited(arguments,[_13]);},_addChildToWrapper:function(_17,_18){_17.addChild(_18);},layout:function(){_1.forEach(this.getChildren(),function(_19){var _1a=_19.getChildren()[0];if(_1a&&_1a.resize){_1a.resize();}});}});});