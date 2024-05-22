
'use strict'
// MAIN MODULE JAVASCRIPTS
var mainModule =  {

    // SET IMAGE TO INPUT COMPONENTS
    setImageToInput : function (inputElement) {
        var labelElement = $(inputElement).prev();
        if (inputElement && labelElement.length > 0) {
            labelElement.empty();

            var files = inputElement.files;

            if (files.length > 0) {
                var img = $('<img>').attr('src', URL.createObjectURL(files[0])).attr('alt', 'avatar').addClass('image-wrapper');

                img.on('load', function () {
                    URL.revokeObjectURL(this.src);
                });


                labelElement.append(img);
            }
        }
    }
};
$('.number-with-comma').each(function () {
    var originalNumber = $(this).text().trim();
    var formattedNumber = numeral(originalNumber).format('0,0');
    $(this).text(formattedNumber);
});