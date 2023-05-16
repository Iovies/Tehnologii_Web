document.addEventListener('DOMContentLoaded', function () {
    var selectedStyle = localStorage.getItem('selectedStyle');
    var darkStyle = document.getElementById('darkStyle');
    var defaultStyle = document.getElementById('defaultStyle');

    if (selectedStyle === 'dark') {
        darkStyle.disabled = false;
        defaultStyle.disabled = true;
    } else {
        darkStyle.disabled = true;
        defaultStyle.disabled = false;
    }
});
