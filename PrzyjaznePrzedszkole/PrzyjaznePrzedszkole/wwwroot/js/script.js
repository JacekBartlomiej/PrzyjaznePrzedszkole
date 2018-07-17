if (window.location.pathname == '/notice-board') {
    let addNoticeBtn = document.getElementById("addNoticeBtn");
    let seeNoticeBtn = document.getElementById("seeNoticeBtn");
    console.log(addNoticeBtn);
    addNoticeBtn.addEventListener("click", function () { location.replace("/add-notice") });
    seeNoticeBtn.addEventListener("click", function () { location.replace("/notice") });
}
