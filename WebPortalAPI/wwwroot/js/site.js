// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {   
    $('#header,#body,#detailproduct ').summernote({
        height: 150,   //set editable area's height
        codemirror: { // codemirror options
            theme: 'monokai'
        }
    });
    animateMenu(true);
    setDatatable(true);
    showDevices(true);
});

function animateMenu(enable)
{
    if (enable) {
        $(".admin-nav-box a").mouseenter(function () {
            var self = $(this);
            $(this).addClass("animated").addClass("flipInX"); console.log("In");
            setTimeout(function () {
                self.removeClass("flipInX");
            }, 500);
        });
    }
}

function setDatatable(enable)
{
    if (enable)
    {
        $("#adminusersTable").DataTable();
    }
}




