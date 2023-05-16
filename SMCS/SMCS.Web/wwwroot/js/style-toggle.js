function toggleStyle() {
    // Make an AJAX call to the server to toggle the style in the cookie
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/SMCS/ToggleStyle", true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onload = function () {
        if (xhr.status === 200) {
            location.reload();
        }
    };
    xhr.send();
}
