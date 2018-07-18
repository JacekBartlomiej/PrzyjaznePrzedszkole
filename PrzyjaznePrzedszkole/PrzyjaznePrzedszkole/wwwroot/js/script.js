if (window.location.pathname == '/notice-board') {
    let addNoticeBtn = document.getElementById("addNoticeBtn");
    let seeNoticeBtn = document.getElementById("seeNoticeBtn");
    addNoticeBtn.addEventListener("click", function () { location.replace("/add-notice") });
    seeNoticeBtn.addEventListener("click", function () { location.replace("/notice") });
}
