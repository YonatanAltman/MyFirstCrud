$("#submit1").click(function (e) {
    e.preventDefault();
    console.log(e);
    alert("Handler for .click() called.");
});
$("#submit2").on('click',function (e) {
    e.preventDefault();
    console.log(e);
    alert("Handler for .click() called.");

});
