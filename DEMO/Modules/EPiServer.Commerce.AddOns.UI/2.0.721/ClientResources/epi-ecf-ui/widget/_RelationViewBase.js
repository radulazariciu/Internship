//>>built
define("epi-ecf-ui/widget/_RelationViewBase",["dojo/aspect","dojo/_base/declare","dojo/_base/lang","dojo/_base/array","dojo/Evented","dojo/topic","dojo/dom-geometry","dojo/dom-style","dojo/_base/window","dijit/layout/_LayoutWidget","epi-cms/widget/Breadcrumb","epi-cms/widget/BreadcrumbCurrentItem","./BackToPreviousViewNotification"],function(_1,_2,_3,_4,_5,_6,_7,_8,_9,_a,_b,_c,_d){return _2([_a],{contentPane:null,_backToPreviousViewNotification:null,postCreate:function(){this.inherited(arguments);this._backToPreviousViewNotification=new _d();this.own(this._backToPreviousViewNotification.watch("notification",_3.hitch(this,this._defaultNotificationWatchHandler)));},_defaultNotificationWatchHandler:function(_e,_f,_10){if(_f){this.notificationBar.remove(_f);}if(_10&&_10.content){this.notificationBar.add(_10);}},updateView:function(_11,_12){this.toolbar.update({currentContext:_12,viewConfigurations:{availableViews:_11.availableViews,viewName:_11.viewName}});this._backToPreviousViewNotification.showNotification();},resize:function(){this.inherited(arguments);var top=_7.position(this.contentPane.domNode).y;var _13=_7.position(_9.body()).h;_8.set(this.contentPane.domNode,"height",(_13-top)+"px");}});});