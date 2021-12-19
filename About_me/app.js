$(function(){
    $("[data-scroll]").on("click", function(event) {
        event.preventDefault();

        block_id = $(this).data('scroll');
        block_offset = $(block_id).offset().top;

        $("html, body").animate({
            scrollTop: block_offset - 50
        }, 700);
    });


    $("[data-modal]").on("click", function(event) {
        event.preventDefault();

        $(modal_resume).addClass('show');    
    });

    $(modal_resume).on("click", function(event) {
        $(modal_resume).removeClass('show');    
    });
    
});