// 显示模态框的函数
function showImageInModal(element) {
    var modal = document.getElementById("myModal");
    var modalImg = document.getElementById("img01");
    modal.style.display = "block";
    modal.className = "modal open";
    modalImg.src = element.src;
}

// 关闭模态框的函数
function closeModal() {
    var modal = document.getElementById("myModal");
    modal.className = "modal";
    setTimeout(function () {
        modal.style.display = "none";
    }, 500); // 动画结束后隐藏模态框
}

// 点击模态框背景关闭模态框
window.onclick = function (event) {
    if (event.target == document.getElementById("myModal")) {
        closeModal();
    }
}