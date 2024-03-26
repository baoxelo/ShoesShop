
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
                var img = $('<img>').attr('src', URL.createObjectURL(files[0])).attr('alt', 'avatar').addClass('image-wrapper object-fit-cover');

                img.on('load', function () {
                    URL.revokeObjectURL(this.src);
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