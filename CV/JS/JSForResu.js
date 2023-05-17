 
    var ShowHide = document.getElementById ("button");
    var magic = document.getElementById("magicDiv");
    
    ShowHide.onclick = function() {
        if(magic.style.display == "none") {
            magic.style.display="block";
        }
    
        else {
        magic.style.display="none";
        }
    } 

    /*
$('#button').click(function() {

    $('#')

})
*/