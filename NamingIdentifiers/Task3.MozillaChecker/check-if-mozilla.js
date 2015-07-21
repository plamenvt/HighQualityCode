function checkIfMozilla() {
    var MyWindow = window,
        currentBrowser = MyWindow.navigator.appCodeName,
        isMozilla = (currentBrowser === "Mozilla");
    if (isMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}