document.addEventListener("DOMContentLoaded", function(event) { 

makeGray();

    var overviewID = document.getElementById("overviewID");
    var aboutID = document.getElementById("aboutID");
    var specsID = document.getElementById("specsID");
    var reviewsID = document.getElementById("reviewsID");
    var accessoriesID = document.getElementById("accessoriesID");
    var manualID = document.getElementById("manualID");

    overviewID.addEventListener("click", checklist);
    aboutID.addEventListener("click", checklist);
    specsID.addEventListener("click", checklist);
    reviewsID.addEventListener("click", checklist);
    accessoriesID.addEventListener("click", checklist);
    manualID.addEventListener("click", checklist);

function checklist(e) {
       
    var Item =  e.target.id;
    console.log(Item);
    var elemItem = document.getElementById(Item);
    console.log(elemItem);
    elemItem.style.background = '#ffffff !important';
    
   
};

function makeGray()
{
    var list = document.getElementById("menuList").getElementsByTagName('li');
    for(i=0; i<list.length; i++)
    {
            list[i].style.background = '#ffffff';
    }
       
    list[0].style.background = 'gray';

}

});