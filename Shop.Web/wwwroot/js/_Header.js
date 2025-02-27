window.onload = function() {
    handleSubmenu()
    openMenu()
    closeMenu()
}
function handleSubmenu() {
    const menuItems = document.querySelectorAll('.c-nav__item')
    Array.from(menuItems).forEach(item => {
        const submenu = document.getElementById(item.getAttribute('link-for'))
        if(submenu) {
           const events = ['mouseenter', 'click', 'mouseleave']
           const changeClass = this.changeClass
           events.forEach(function(event) {
               item.addEventListener(event, function() {
                   if (event == 'mouseenter' || 'click') {
                       changeClass(submenu, 'is-visible', 100)
                       changeClass(submenu, 'is-open', 200)
                       return
                   }
                   changeClass(submenu, 'is-open', 200)
                   changeClass(submenu, 'is-visible', 500)
               })
           })
        }
    })
}

function changeClass(element, className, time) {
    setTimeout(() => {
        element.classList.toggle(className)
    }, time)
}

function openMenu() {
    const navMenu =  document.querySelector('.js-nav__menu');
    const toggleButton = document.querySelector('.js-nav__toggle');
    if(toggleButton && navMenu) {
        toggleButton.addEventListener('click', function(event) {
            navMenu.classList.add('is-open')
        })
    }
}

function  closeMenu() {
    const navMenu = document.querySelector('.js-nav__menu')
    const closeButton = document.querySelector('.js-nav__close');
    if(closeButton && navMenu) {
        closeButton.addEventListener('click', function(event) {
            navMenu.classList.remove('is-open')
        })
    }
}