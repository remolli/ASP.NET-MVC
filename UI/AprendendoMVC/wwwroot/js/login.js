
$('form').on('submit', function (event) {

    event.preventDefault();

    var formData = {
        email: $("#email").val(),
        password: $("#password").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5251/api/User",
        success: function (result) {
            if (result.response == 'OK')
                alert("Login Success")
            else
                alert("Credenciais inválidas")
        },
        error: function (error) { console.log(error) }
    })
});