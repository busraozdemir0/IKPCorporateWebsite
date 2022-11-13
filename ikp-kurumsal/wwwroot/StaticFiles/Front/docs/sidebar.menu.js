/*!
 * Sidebar menu
 * Copyright Zdeněk Papučík
 * MIT License
*/
(function (factory) {
	if (typeof define === 'function' && define.amd) {
		define(['jquery'], factory);
	} else if (typeof exports === 'object') {
		module.exports = factory(require('jquery'));
	} else {
		factory(jQuery);
	}
}(function($) {
	$('.list-item').each(function() {
		let el = $(this);
		let linkHasClass = (className) => {
			return el.parent().find('a')
				.hasClass(className);
		}
		if (linkHasClass('link-arrow')) {
			el.find('a').addClass('up');
			if (linkHasClass('link-current')) {
				let current = $('.link-current');
				current.addClass('active down');
				current.next('ul').show();
			}
		}
	});
	$('.link-arrow').on('click', function() {
		let el = $(this);
		el.addClass('transition')
			.toggleClass('active rotate');

		!(el.hasClass('link-current'))
			? el.addClass('link-current')
			: el.removeClass('link-current');

		el.next('.list-hidden').slideToggle('fast');
		if (el.parent().find('a').hasClass('down')) {
			el.toggleClass('rotate-revert')
		}
	});
}));
