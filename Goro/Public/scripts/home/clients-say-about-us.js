(function () {
    var clientsSayAboutUsModule = (function () {
        var $customerTheaterWrapper = null,
            $customerTheater = null,
            $customerAvatarsClient = null;

        function loadDomElements() {
            $customerTheaterWrapper = $('.customer-theater-wrapper');
            $customerTheater = $customerTheaterWrapper.find('.customer-theater');
            $customerAvatarsClient = $('.customer-avatars-client');
        }

        function initEvents() {
            $customerAvatarsClient.click(clickCustomerAvatar)
        }

        function clickCustomerAvatar() {
            var $selectedCustomerAvatar = $(this),
                indexOfSelectedDomElement = parseInt($selectedCustomerAvatar.data('index')),
                $selectedCustomerTheater = $($customerTheater[indexOfSelectedDomElement]);

            $customerAvatarsClient.removeClass('active');
            $selectedCustomerAvatar.addClass('active');

            $customerTheater.addClass('closed')
                .removeClass('opened');

            $customerTheaterWrapper.prepend($selectedCustomerTheater);
            $selectedCustomerTheater.removeClass('closed')
                .addClass('opened');
        }

        function init() {
            loadDomElements();
            initEvents();

            $customerTheater.first()
                .removeClass('closed')
                .addClass('opened');
            $customerAvatarsClient.first()
                .addClass('active');
        }

        return {
            init: init
        }
    }())

    $(document).ready(function () {
        clientsSayAboutUsModule.init();
    });
}())