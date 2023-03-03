function showModal(title, msg) {

    document.getElementById('lblModalTitle').innerText = title;
    document.getElementById('lblModalMessage').innerText = msg;

    var myModal = new bootstrap.Modal(document.getElementById("exampleModal"), {});
    document.onreadystatechange = function () {
        myModal.show();
    };
}