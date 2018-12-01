$(window).load(function() {
//    $(document).ready(function() {
//        $('.pgwSlider').pgwSlider();
//    });
    $('.owl-carousel').owlCarousel({
        rtl: true,
        loop: true,
        autoplay: true,
        margin: 1,
        nav: true,
        navText: ["<i class='fa fa-angle-right fa-lg'></i>", "<i class='fa fa-angle-left fa-lg'></i>"],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 4
            }
        }
    });
    
    $('.owl-carousel2').owlCarousel({
        rtl: true,
        loop: true,
//        autoplay: true,
        margin: 30,
        nav: true,
        navText: [""],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    });
    
});