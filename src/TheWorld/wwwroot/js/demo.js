// side js

// wrap the code in a function to avoid using global namespace 
//function startup() {
//    var ele = document.getElementById("username");
//    ele.innerHTML = "Richard Kuodis"

//    var main = document.getElementById("main");

//    main.onmouseenter = function() {
//        main.style.backgroundColor = "#888";
//    };

//    main.onmouseleave = function() {
//        main.style.backgroundColor = "";
//    };
//}

// call our function
//startup();


// or do it this way:
// anonymous function
//(function () {    


//    //var ele = document.getElementById("username");
//    //ele.innerHTML = "Richard Kuodis";
//    // some browsers might have this method:
//    //ele.innerHtml = "Richard Kuodis";

//    var main = document.getElementById("main");

//    main.onmouseenter = function() {
//        main.style.backgroundColor = "#888";
//    };

//    main.onmouseleave = function() {
//        main.style.backgroundColor = "";
//    };
//})(); // () - execute immidiately


// For crossbrowser support use jQuery
(function () {

    // JQuery can be accessed 2 ways:
    // through jQuery or through dollar sign - $ (short form)

    // uses css selector syntax
    var ele = $("#username");
    ele.text("Richard Kuodis");

    var main = $("#main");

    main.on("mouseenter",
        function() {
            main.style = "background-color: #888";
        });

    main.on("mouseleave",
        function() {
            main.style.backgroundColor = "";
        });

    // get <a> inside <li> of <ul class="menu">
    var menuItems = $("ul.menu li a");
    // without jQuery:
    // menuItems[0].onmouseenter()= ...
    // menuItems[1]....
    // etc
    // jQuery allows to add callbacks to all found items at once
    menuItems.on("click",
        function () {
            // get the object the function is related to
            var me = $(this);
            alert(me.text());
        });

})();