(function ($) {
    "use strict";

    // Spinner
    var spinner = function () {
        setTimeout(function () {
            if ($('#spinner').length > 0) {
                $('#spinner').removeClass('show');
            }
        }, 10);
    };
    spinner();
    
    
    // Initiate the wowjs
    new WOW().init();


    // Fixed Navbar
    $(window).scroll(function () {
        if ($(window).width() < 992) {
            if ($(this).scrollTop() > 65) {
                $('.fixed-top').addClass('bg-white shadow');
            } else {
                $('.fixed-top').removeClass('bg-white shadow');
            }
        } else {
            if ($(this).scrollTop() > 45) {
                $('.fixed-top').addClass('bg-white shadow').css('top', -45);
            } else {
                $('.fixed-top').removeClass('bg-white shadow').css('top', 0);
            }
        }
    });
    
    /*
    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 300) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });*/


    // Testimonials carousel
    $(".testimonial-carousel").owlCarousel({
        autoplay: true,
        smartSpeed: 1000,
        margin: 25,
        loop: true,
        center: true,
        dots: false,
        nav: true,
        navText : [
            '<i class="bi bi-chevron-left"></i>',
            '<i class="bi bi-chevron-right"></i>'
        ],
        responsive: {
            0:{
                items:1
            },
            768:{
                items:2
            },
            992:{
                items:3
            }
        }
    });
    // Use jQuery to apply comma formatting every three digits
    $('.number-with-comma').each(function () {
        var originalNumber = $(this).text().trim();
        var formattedNumber = numeral(originalNumber).format('0,0');
        $(this).text(formattedNumber);
    });

    // Carosel product
    $('.product-carousel-left').click(function () {
        var productCarousel = $(this).closest('.product-carousel')
        var width = productCarousel.find('.product-item').first().outerWidth();
        productCarousel.find('.product-carousel-list').animate({ scrollLeft: '-=' + width }, 400);
    });
    $('.product-carousel-right').click(function () {
        var productCarousel = $(this).closest('.product-carousel')
        var width = productCarousel.find('.product-item').first().outerWidth();
        productCarousel.find('.product-carousel-list').animate({ scrollLeft: '+=' + width }, 400);
    });
    

})(jQuery);



