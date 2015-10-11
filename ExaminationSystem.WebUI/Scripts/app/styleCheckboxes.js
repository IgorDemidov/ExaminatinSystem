var styleCheckboxes = function () {
    var checkboxImg = document.createElement("img");
    checkboxImg.src = "/Content/app/images/transp.png";
    checkboxImg.style.width = "14px";
    checkboxImg.style.height = "14px";
    checkboxImg.style.backgroundImage = 'url("/Content/app/images/my_checkbox.png")';
    checkboxImg.style.backgroundPosition = "0px 0px";
    checkboxImg.style.backgroundSize = "auto 14px";
    var checkboxLabelImg = document.createElement("label");
    checkboxLabelImg.appendChild(checkboxImg);

    var checkboxes = document.querySelectorAll('input[type="checkbox"]');
    for (var i = 0; i < checkboxes.length; i++) {
        var par = checkboxes[i].parentNode;
        var imgLabelClone = checkboxLabelImg.cloneNode(true);
        imgLabelClone.firstChild.id = "img-" + checkboxes[i].id;
        imgLabelClone.htmlFor = checkboxes[i].id;
        par.insertBefore(imgLabelClone, checkboxes[i]);
        checkboxes[i].hidden = "true";
        checkboxes[i].onchange = function () {
            if (this.checked) {
                document.getElementById("img-" + this.id).style.backgroundPosition = "14px 0px";
            } else {
                document.getElementById("img-" + this.id).style.backgroundPosition = "0px 0px";
            };
        };
    }
}