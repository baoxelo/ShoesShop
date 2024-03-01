
'use strict'
// MAIN MODULE JAVASCRIPTS
var mainModule = (function () {

    // SET IMAGE TO INPUT COMPONENTS    
    function setImageToInput(inputElement) {
        var labelElement = $(inputElement).prev();
        if (inputElement && labelElement.length > 0) {
            labelElement.empty();

            var files = inputElement.files;

            if (files.length > 0) {
                var img = $('<img>').attr('src', URL.createObjectURL(files[0]));

                img.on('load', function () {
                    URL.revokeObjectURL(this.src);
                });

                // Thêm CSS trực tiếp vào thẻ img
                img.css({
                    width: '100%',
                    height: '100%',
                    objectFit: 'cover'
                });

                labelElement.append(img);
            }
        }
    }
    return {
        setImageToInput: setImageToInput
    }
})();

mainModule();