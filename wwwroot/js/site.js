
'use strict'
// MAIN MODULE JAVASCRIPTS
var mainModule = {
    // SET IMAGE TO INPUT COMPONENTS
    setImageToInput : function(inputElement) {
        var labelElement = $(inputElement).prev();
        if (inputElement && labelElement.length > 0) {
            labelElement.empty();

            var files = inputElement.files;

            if (files.length > 0) {
                var img = $('<img>').attr('src', URL.createObjectURL(files[0])).attr('alt', 'avatar').addClass('image-wrapper object-fit-cover');

                img.on('load', function () {
                    URL.revokeObjectURL(this.src);
                });

                labelElement.append(img);
            }
        }
    },

    useDebounce: function (func, delay) {
        let timer;
        return function () {
            clearTimeout(timer);
            timer = setTimeout(() => func(), delay);
        };
    },
    
};

$(document).ready(function () {
    //---------------RESPONSIVE---------------//
    // Function to check if the screen size is mobile or tablet
    function isnotWindow() {
        return $(window).width() < 768; // Adjust this threshold according to your needs
    }

    // Function to empty the .window-area classes
    function emptyWindowArea() {
        $('.window-area').empty();
    }
    // Call emptyWindowArea initially if on mobile or tablet
    if (isnotWindow()) {
        emptyWindowArea();
    }

    // Re-call emptyWindowArea when the window is resized
    $(window).resize(function () {
        if (isnotWindow()) {
            emptyWindowArea();
        }
    });


    function isnotMobileOrTablet() {
        return $(window).width() > 768; // Adjust this threshold according to your needs
    }

    // Function to empty the .mobile-tablet-area classes
    function emptyMobileTabletArea() {
        $('.mobile-tablet-area').empty();
    }

    // Call emptyMobileTabletArea initially if on mobile or tablet
    if (isnotMobileOrTablet()) {
        emptyMobileTabletArea();
    }

    // Re-call emptyMobileTabletArea when the window is resized
    $(window).resize(function () {
        if (isnotMobileOrTablet()) {
            emptyMobileTabletArea();
        }
    });

    //---------------END RESPONSIVE---------------//



    //---------------SEARCH PARTIAL---------------//
    $("#search-product-input").on('input', mainModule.useDebounce(function () {
        const searchText = $("#search-product-input").val();
        // Call API using Ajax
        $.ajax({
            url: '/Product/SearchProduct',
            type: 'GET',
            data: { searchText: searchText },
            success: function (response) {
                // Handle API response and display results
                $('#searchResults').empty();
                console.log(response)
                response.forEach((product) => {
                    console.log(product.name);
                })
                response.forEach( (product) => {
                    const resultHtml = `<div class="w-100 p-0 hover-darkness border-top">
                                          <a class="row p-0 m-0 text-dark" href="${product.url}">
                                            <div class="col-3 p-2">
                                                <img class="w-100 image-wrapper" src="${product.imageUrl}" alt="${product.name}">
                                            </div>
                                            <div class="col-9 d-flex flex-column justify-content-center">
                                                <div class="row"><h6>${product.name}</h6></div>
                                                <div class="row">
                                                    <span>Phân loại : ${product.category} ${product.gender}</span>
                                                </div>
                                            </div>
                                          </a>
                                        </div>`;
                    $('#searchResults').append(resultHtml);
                });
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });

    }, 300)
    )

    $('#dropdownSearchToggle').click(() => {
        $('#search-product-input').focus();
    });
    //---------------END SEARCH PARTIAL---------------//

    //---------------COLLECTION PARTIAL---------------//
    
    $('.collection-gender').on('click', function () {
        $('.collection-gender').removeClass('active');
        $(this).addClass('active');

        var gender = $(this).attr('attr-data');

        var categories = $('.collection-category-item');
        categories.each(function () {
            var category = $(this); // Chuyển đổi thành đối tượng jQuery

            var currentHref = category.attr('href');
            var url = new URL(currentHref, window.location.origin);

            // Thêm hoặc cập nhật tham số 'gender' trong URL
            url.searchParams.set('gender', gender); // Giả sử 'gender' là một biến chứa giá trị bạn muốn thêm vào

            // Cập nhật thuộc tính 'href' của thẻ a với URL mới
            category.attr('href', url.toString());
        });
    });

    //---------------END COLLECTION PARTIAL---------------//
});

