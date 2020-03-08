// A $( document ).ready() block.
$(document).ready(function () {
    //$("#btn-submit").click(function (e) {
    //    e.preventDefault();
    //    console.log(e);

    //    let form = getForm();


    //});
    $("#form").on("submit", function (event) {
        event.preventDefault();
        const params = $(this).serialize();
        console.log('params: ', params);
        const url = '/api/pet/GetList?' + params;
            $.get(url, function (res) {

                console.log(res);

            });

    });
});


function getForm() {

    



}