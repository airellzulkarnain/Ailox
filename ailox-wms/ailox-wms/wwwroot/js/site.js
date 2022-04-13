// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.querySelector("[logout]").addEventListener("click", () => {
    let x = document.querySelector(".overlay");
    let y = document.querySelector(".card");

    y.classList = "card active";
    x.classList = "overlay active";

    x.addEventListener("click", () => {
        x.classList = "overlay";
        y.classList = "card";
    });
});

document.querySelector(".overlay + .card > .button").addEventListener("click", () => {
    document.querySelector(".overlay").classList = "overlay";
    document.querySelector(".card").classList = "card";
});