
$(document).ready(function () {
    $('.carousel5').slick({
        speed: 500,
        dots: true,
        infinite: true,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        //centerMode: true,
        responsive: [{
            breakpoint: 1024,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
                // centerMode: true,

            }
        }, {
            breakpoint: 800,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2,
                dots: true,
                infinite: true,

            }
        }, {
            breakpoint: 480,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
                dots: true,
                infinite: true,
                autoplay: true,
                autoplaySpeed: 2000,
            }
        }]
    });
});

////var all_list = false;

////function all_li() {
////    debugger;
////    if (!all_list) {
////        document.getElementById('all-list').style.display = 'block';
////        document.getElementById('triangle').src = "./imgs/triangle-up.png";
////        all_list = true;
////    } else if (all_list) {
////        document.getElementById('all-list').style.display = 'none';
////        document.getElementById('triangle').src = "./imgs/triangle.svg";
////        all_list = false;
////    }
////}

////document.getElementById('ls-all').addEventListener('click', on_list);
////document.getElementById('ls-title').addEventListener('click', on_list);
////document.getElementById('ls-tv').addEventListener('click', on_list);
////document.getElementById('ls-celibs').addEventListener('click', on_list);
////document.getElementById('ls-comp').addEventListener('click', on_list);
////document.getElementById('ls-key').addEventListener('click', on_list);
////document.getElementById('ls-adv').addEventListener('click', off_list);

////function on_list() {
////    document.getElementById("present-list").innerHTML = this.innerText;
////    document.getElementById('all-list').style.display = 'none';
////    document.getElementById('triangle').src = "~/Content/imgs/triangle.svg";
////    all_list = false;
////}

////function off_list() {
////    document.getElementById('all-list').style.display = 'none';
////}