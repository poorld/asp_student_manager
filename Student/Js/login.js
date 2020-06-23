function login() {
    let username = $("#username").val()
    let password = $("#password").val()
    let obj = {
        username,
        password
    }
    $.ajax({
        url: "/api/Admin",
        contentType: "application/json",
        data: "'" + JSON.stringify(obj) + "'",
        type: 'POST',
        success: function (res) {
            console.log(res)
            let resObj = JSON.parse(res)
            if (resObj.msg === "success") {
                alert("登录成功!")
                window.location.href = resObj.data
            }else{
                alert(resObj.data)
            }
        }
    })
}