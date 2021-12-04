function confirmFire(empNo, isFireClicked) {
    var fireSpan = document.getElementById("fireSpan_" + empNo + "");
    var confirmFireSpan = document.getElementById("confirmFireSpan_" + empNo + "");
    if (isFireClicked) {
        fireSpan.style.display = "none";
        confirmFireSpan.style.display = "inline";
    }
    else {
        fireSpan.style.display = "inline";
        confirmFireSpan.style.display = "none";
    }
}