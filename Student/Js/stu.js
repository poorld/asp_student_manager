$(document).ready(function () {
    getStuInfo();
})

function getStuInfo() {

    $.ajax({
        url: "/api/Stu",
        contentType: "application/json",
        type: 'GET',
        success: function (res) {
            let resObj = JSON.parse(res)
            console.log(resObj)
            if (resObj.msg === "success") {

                $("#stu_name").text(resObj.data.StuName)
                $("#stu_grade").text(resObj.data.StuGrade)
                $("#stu_profession").text(resObj.data.StuProfession)
                $("#stu_class").text(resObj.data.StuClass)
                $("#stu_contact").text(resObj.data.StuContact)
                $("#stu_address").text(resObj.data.StuAddress)


                $("#stu_native_place").val(resObj.data.StuNativePlace)
                $("#stu_contact").val(resObj.data.StuContact)
                $("#stu_address").val(resObj.data.StuAddress)
            }
        }
    })
}

function stuUpdate() {
    let stuNativePlace = $("#stu_native_place").val();
    let stuContact = $("#stu_contact").val();
    let stuAddress = $("#stu_address").val()

    let obj = {
        stuNativePlace,
        stuContact,
        stuAddress
        }

    $.ajax({
        url: "/api/Stu",
        contentType: "application/json",
        type: 'PUT',
        data: "'" + JSON.stringify(obj) + "'",
        success: function (res) {
            let resObj = JSON.parse(res)
            console.log(resObj)
            if (resObj.msg === "success") {
                window.location.href = "/View/Student/Student.aspx"
            }
        }
    })

}

function update(){
    window.location.href = "/View/Student/StuUpdate.aspx"
}

function logout(){
    $.ajax({
        url: "/api/Stu",
        contentType: "application/json",
        type: 'DELETE',
        success: function (res) {
            let resObj = JSON.parse(res)
            if (resObj.msg === "success") {
                window.location.reload()
            }
        }
    })
}