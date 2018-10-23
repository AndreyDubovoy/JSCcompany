var holderBalance = document.getElementById("holder-balance");
var currentBalance = document.getElementById("current-balance");
holderBalance.innerText = currentBalance.innerText;
holderBalance.setAttribute("class", currentBalance.getAttribute("class"));