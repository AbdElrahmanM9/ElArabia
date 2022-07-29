
$(document).ready(function () {
    $("nav .dropdown").hover(
        function () {
            $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true, true).slideDown("400");
            $(this).toggleClass('open');
        },
        function () {
            $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true, true).slideUp("400");
            $(this).toggleClass('open');
        }
    );
    $('.carousel5').slick({
        speed: 500,
        dots: true,
        infinite: true,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        centerMode: true,
        responsive: [{
            breakpoint: 1024,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
                centerMode: true,

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


$('.color-menu .show').on('click', function () {

    $(this).parent('.color-menu').toggleClass('is-visible');

    if ($(this).parent('.color-menu').hasClass('is-visible')) {

        $(this).parent('.color-menu').animate({

            right: 0

        }, 500);

        $('body').animate({

            paddingleft: '80px'

        }, 50);
    } else {

        $(this).parent('.color-menu').animate({

            right: '-80px'

        }, 700);

        $('body').animate({

            paddingleft: 0

        }, 500);

    }
});


/////// Change Colors
$('.switch-colors li').on('click', function () {
    $(':root').css('--maincolor', $(this).data('color'));
    $(':root').css('--mainbackground', $(this).data('background'));
});

$("#cheeses-by-category-link").click(function () {
    $("#cheeses-by-category-sub").slideToggle("slow", function () {

    });
});
$("#cheese-facts-link").click(function () {
    $("#cheese-facts-sub").slideToggle("slow", function () {

    });
});

$('#back-to-top').on('click', function (e) {
    e.preventDefault();
    $('html,body').animate({
        scrollTop: 0
    }, 700);
});

(function () {
    "use strict";
    var toggles = document.querySelectorAll(".c-hamburger");
    for (var i = toggles.length - 1; i >= 0; i--) {
        var toggle = toggles[i];
        toggleHandler(toggle);
    };
    function toggleHandler(toggle) {
        toggle.addEventListener("click", function (e) {
            e.preventDefault();
            if (this.classList.contains("is-active") === true) {
                this.classList.remove("is-active");
                $("#sidenav").removeClass('showSidenav');
            } else {
                this.classList.add("is-active");
                $("#sidenav").addClass('showSidenav');
            };
        });
    }

})();

function themeToggle() { document.addEventListener("DOMContentLoaded", function (event) { (function (theme = localStorage.getItem("theme")) { if (localStorage.getItem("theme")) { document.documentElement.setAttribute("data-theme", theme); var b = document.querySelector("[data-toggle-theme='" + theme.toString() + "']"); if (b) { b.classList.add(b.getAttribute("data-act-class")) } } })(); if (document.querySelector("[data-toggle-theme]")) { document.querySelector("[data-toggle-theme]").addEventListener("click", function () { if (document.documentElement.getAttribute("data-theme") == this.getAttribute("data-toggle-theme")) { document.documentElement.removeAttribute("data-theme"); localStorage.removeItem("theme") } else { document.documentElement.setAttribute("data-theme", this.getAttribute("data-toggle-theme")); localStorage.setItem("theme", document.documentElement.getAttribute("data-theme")) } this.classList.toggle(this.getAttribute("data-act-class")) }) } }) } function themeBtn() { document.addEventListener("DOMContentLoaded", function (event) { (function (theme = localStorage.getItem("theme")) { if (localStorage.getItem("theme")) { document.documentElement.setAttribute("data-theme", theme); var b = document.querySelector("[data-set-theme='" + theme.toString() + "']"); if (b) { [...document.querySelectorAll("[data-set-theme]")].forEach(el => { el.classList.remove(el.getAttribute("data-act-class")) }); b.classList.add(b.getAttribute("data-act-class")) } } else { var b = document.querySelector("[data-set-theme='']"); if (b) { b.classList.add(b.getAttribute("data-act-class")) } } })();[...document.querySelectorAll("[data-set-theme]")].forEach(el => { el.addEventListener("click", function () { document.documentElement.setAttribute("data-theme", this.getAttribute("data-set-theme")); localStorage.setItem("theme", document.documentElement.getAttribute("data-theme"));[...document.querySelectorAll("[data-set-theme]")].forEach(el => { el.classList.remove(el.getAttribute("data-act-class")) }); el.classList.add(el.getAttribute("data-act-class")) }) }) }) } function themeSelect() { document.addEventListener("DOMContentLoaded", function (event) { (function (theme = localStorage.getItem("theme")) { if (localStorage.getItem("theme")) { document.documentElement.setAttribute("data-theme", theme); var optionToggler = document.querySelector("select[data-choose-theme] [value='" + theme.toString() + "']"); if (optionToggler) { optionToggler.selected = true } } })(); if (document.querySelector("select[data-choose-theme]")) { document.querySelector("select[data-choose-theme]").addEventListener("change", function () { document.documentElement.setAttribute("data-theme", this.value); localStorage.setItem("theme", document.documentElement.getAttribute("data-theme")) }) } }) } if (typeof exports != "undefined") { module.exports = { themeToggle: themeToggle, themeBtn: themeBtn, themeSelect: themeSelect } } else { themeToggle(); themeBtn(); themeSelect() }
