// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let overlay = document.createElement("div");
overlay.className = "overlay";
overlay.addEventListener("click", () => {
    document.querySelector(".overlay").remove();
});
document.querySelector("[logout]").addEventListener("click", () => {
    document.body.appendChild(overlay);
    document.body.appendChild();
});