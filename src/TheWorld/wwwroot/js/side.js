// side.js
(function () {

    //get both sidebar and wrapper
    var $sidebarAndWrapper = $("#sidebar, #wrapper");

    $("#sidebarToggler")
        .on("click",
            function() {
                // add a class if it doesn't exist or remove if it does exist
                $sidebarAndWrapper.toggleClass("hide-sidebar");
                /* from site.css
                    #sidebar.hide-sidebar {
                        left: -250px;
                    }

                    #wrapper.hide-sidebar {
                        margin-left: 0;
                    }
                 */

                if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
                    //$(this).text("Show Sidebar");
                    $(this).attr("src", "img/hamburger.png");
                } else {
                    //$(this).text("Hide Sidebar");
                    $(this).attr("src", "img/arrow.png");
                }

            });

})();