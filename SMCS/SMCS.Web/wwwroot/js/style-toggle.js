// Check if theme preference is stored in local storage
var storedTheme = localStorage.getItem('theme');

// Apply stored theme or default to light theme immediately
if (storedTheme === 'dark') {
    applyDarkTheme();
} else {
    applyLightTheme();
}

function applyLightTheme() {
    createThemeStylesheet('/css/style.css');
    localStorage.setItem('theme', 'light');
}

function applyDarkTheme() {
    createThemeStylesheet('/css/styleDark.css');
    localStorage.setItem('theme', 'dark');
}

function createThemeStylesheet(href) {
    var head = document.getElementsByTagName('head')[0];
    var themeStyle = document.getElementById('theme-style');

    if (themeStyle) {
        themeStyle.href = href;
    } else {
        var newStyle = document.createElement('link');
        newStyle.id = 'theme-style';
        newStyle.rel = 'stylesheet';
        newStyle.href = href;
        head.appendChild(newStyle);
    }
}

function toggleTheme() {
    var themeStyle = document.getElementById('theme-style');
    if (themeStyle.href.includes('/css/style.css')) {
        applyDarkTheme();
    } else {
        applyLightTheme();
    }
}
