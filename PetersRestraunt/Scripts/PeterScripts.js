$(function(){
    $("form[data-pr-Send='true']").submit(ajaxSubmitSearchForm);
});
function  ajaxSubmitSearchForm(){

    var $form = $(this);

    var options = {
        type: $form.attr("method"),
        url: $form.attr("action"),
        data: $form.serialize() //Encode a set of form elements as a string for submission
    }
    $.ajax(options).done(function(data){
        $target = $($form.attr("data-pr-target"));
        $newHtml = $(data);
        $target.replaceWith($newHtml);
    });

    return false;
}