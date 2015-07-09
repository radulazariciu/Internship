var jokerCoordonates = 1;
var jokerId = "canvasL1C1"; //default location
// List of Id's of canvas objects.
	var arrIdOfCanvas= ["canvasL1C1","canvasL1C2","canvasL1C3","canvasL1C4",
						"canvasL2C1","canvasL2C2","canvasL2C3","canvasL2C4",
						"canvasL3C1","canvasL3C2","canvasL3C3","canvasL3C4",
						"canvasL4C1","canvasL4C2","canvasL4C3","canvasL4C4"
						];

$(document).ready(function() {
	
	
	jokerCoordonates = Math.floor((Math.random() * 20) + 1); 
	while (jokerCoordonates > 16) {
		jokerCoordonates = Math.floor((Math.random() * 20) + 1); 
	}
    
    $('body').keydown(keyPressedHandler);
    generateCanvas();
});

function keyPressedHandler(e) {
	var code = (e.keyCode ? e.keyCode : e.which);
	
	switch(code) {
		case 37:
			moveDirection = 'left';
			//alert("left");
			clear();
			if(jokerCoordonates -1 > 0)jokerCoordonates  = jokerCoordonates -1;

			generateCanvas();
			//location.reload(); 
			break;
		case 38:
			moveDirection = 'up';
			clear();
			if(jokerCoordonates -4 > 0)	jokerCoordonates  = jokerCoordonates -4;
			generateCanvas();
			//alert("up");
			break;
		case 39:
			moveDirection = 'right';
			clear();
			if(jokerCoordonates +1 < 17) jokerCoordonates  = jokerCoordonates +1;
			generateCanvas();
			//alert("right");
			break;
		case 40:
			moveDirection = 'down';
			clear();
			if(jokerCoordonates +4 < 17) jokerCoordonates  = jokerCoordonates +4;
			generateCanvas();
			//alert("down");
			break;
	}
 }
 
function clear() {
	var ctx=[];
	var i=0;
	while (i < arrIdOfCanvas.length) {
	
			//alert("i"+i+"joker"+jokerCoordonates);
			//alert(arrIdOfCanvas[i]+"canvas");
			
	    	var c = document.getElementById(arrIdOfCanvas[i]);
			ctx[i] = c.getContext("2d");

			ctx[i].clearRect(0,0,200,200);
			//setTimeout(20000);
		
		i++;
	}
	
}

 function generateCanvas() {

	//alert(jokerCoordonates);
	
	switch(jokerCoordonates) {
		case 1:
			jokerId = "canvasL1C1"
		break;
		case 2:
			jokerId = "canvasL1C2"
		break;
		case 3:
			jokerId = "canvasL1C3"
		break;
		case 4:
			jokerId = "canvasL1C4"
		break;
		case 5:
			jokerId = "canvasL2C1"
		break;
		case 6:
			jokerId = "canvasL2C2"
		break;
		case 7:
			jokerId = "canvasL2C3"
		break;
		case 8:
			jokerId = "canvasL2C4"
		break;
		case 9:
			jokerId = "canvasL3C1"
		break;
		case 10:
			jokerId = "canvasL3C2"
		break;
		case 11:
			jokerId = "canvasL3C3"
		break;
		case 12:
			jokerId = "canvasL3C4"
		break;
		case 13:
			jokerId = "canvasL4C1"
		break;
		case 14:
			jokerId = "canvasL4C2"
		break;
		case 15:
			jokerId = "canvasL4C3"
		break;
		case 16:
			jokerId = "canvasL4C4"
		break;
	}
	
	
	//alert(arrIdOfCanvas.length);
	
	clear();

	var ctx=[];
	var i=0;
	while (i < arrIdOfCanvas.length) {
		if (arrIdOfCanvas[i] !=jokerId) {
			//alert("i"+i+"joker"+jokerCoordonates);
			//alert(arrIdOfCanvas[i]+"canvas");
			/*
	    	var c = document.getElementById(arrIdOfCanvas[i]);
			ctx[i] = c.getContext("2d");

			ctx[i].fillStyle = "yellow";
			ctx[i].fillRect(0, 0, 250,  Math.floor((Math.random() * 200) + 1) )

			ctx[i].transform(1, 0.5, -0.5, 1, 30, 10);
			ctx[i].fillStyle = "red";
			ctx[i].fillRect(0, 0, 250,  Math.floor((Math.random() * 150) + 1));

			ctx[i].transform(1, 0.5, -0.5, 1, 30, 10);
			ctx[i].fillStyle = "blue";
			ctx[i].fillRect(0, 0, 250,  Math.floor((Math.random() * 200) + 1));
			*/
			//setTimeout(20000);
		}
		i++;
	}
	
 	// Create joker image based of calculated position.
	var contextJoker = document.getElementById(jokerId);
	//clear();

	//--------
	var c = document.getElementById(jokerId);
			ctxClear = c.getContext("2d");

			ctxClear.clearRect(0,0,200,200);
	//--------
	//alert(jokerId+"idjoker");
	//alert(jokerId);
	var context = contextJoker.getContext("2d");

	var imageObj = new Image();
    imageObj.onload = function() {
        context.drawImage(imageObj, 0, 0);
    };
    imageObj.src = 'img/joker.jpg';
 }