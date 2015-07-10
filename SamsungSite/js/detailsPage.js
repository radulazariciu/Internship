function checklist(ctrl) {
       
    var list = document.getElementById("menuList").getElementsByTagName('li');
       
    for(i=0; i<list.length; i++)
    {
            list[i].style.background = '#ffffff';
    }
       
    ctrl.style.background = 'gray';
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

