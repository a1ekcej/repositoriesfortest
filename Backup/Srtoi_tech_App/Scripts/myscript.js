$(document).ready(function(){
// hide #tpTop first
$("#toTop").hide();
 
// fade in #tpTop
$(function () {
$(window).scroll(function () {
if ($(this).scrollTop() > 100) {
$('#toTop').fadeIn();
} else {
$('#toTop').fadeOut();
}
});
// scroll body to 0px on click
$('#toTop span').click(function () {
$('body,html').animate({
scrollTop: 0
}, 400);
return false;
});
});
});

/*$(function() {
    $(window).scroll(function() {
        if ($(this).scrollTop()!=0) {
            $('#toTop').fadeIn();
        } else {
            $('#toTop').fadeOut();
        }
        });
        $('#toTop').click(function() {
            $('#body,html').animate({scrollTop:0}, 800);
        });
    });

    $(document).ready(function(){
// hide #tpTop first
$("#toTop").hide();
 */