window.addEventListener('load', () => {
    $.get("/api/cartapi", function (data) {
        console.log(data); 
    });
});