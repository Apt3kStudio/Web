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
    //CKEDITOR.replace("header"); 
    //CKEDITOR.replace("body");  
    //CKEDITOR.replace("detailproduct");  
    //CKEDITOR.replace("logo");  
    //console.log("site.js is connected");
     
});
