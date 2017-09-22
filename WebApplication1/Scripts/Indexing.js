document.getElementById("indexing").onclick = function () {
    var perCent = document.getElementById("per-cent-of-indexing").value / 100;
    var prices = document.getElementsByClassName("price");
    for (var i = 0; i < prices.length; i++) {
        prices[i].innerHTML = prices[i].textContent * (perCent + 1);
        var k = i;
    }
}