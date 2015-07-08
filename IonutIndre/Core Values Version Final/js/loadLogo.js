$(document).ready(function() {
var context = document.getElementById("logo");
ctxClear = context.getContext("2d");
var imageObj = new Image();
imageObj.onload = function() {
      context.drawImage(imageObj, 0, 0);
};
imageObj.src = 'img/wrench.png';
};