document.addEventListener("DOMContentLoaded", function(event) { 

//makeGray();

    var overviewID = document.getElementById("overviewID");
    overviewID.style.background = 'gray';
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

    overviewID.style.background = 'white';
    aboutID.style.background = 'white';
    specsID.style.background = 'white';
    reviewsID.style.background = 'white';
    accessoriesID.style.background = 'white';
    manualID.style.background = 'white';

    elemItem.style.background = 'gray';
   
};

});