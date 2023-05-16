function toggleStyle() {
    var darkStyle = document.getElementById('darkStyle');
    var defaultStyle = document.getElementById('defaultStyle');

    if (darkStyle.disabled) {
        darkStyle.disabled = false;
        defaultStyle.disabled = true;
        localStorage.setItem('selectedStyle', 'dark');
    } else {
        darkStyle.disabled = true;
        defaultStyle.disabled = false;
        localStorage.setItem('selectedStyle', 'default');
    }
}
