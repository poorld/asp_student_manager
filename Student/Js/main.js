
$(document).ready(function () {
    setHeight();
    loadData();
    checkUpdate();
})

function loadData() {
    if(!$("#stu_query"))
        return

    $.ajax({
        url: "/api/Student",
        type: 'GET',
        success: function(res){
            //console.log(res)
            let jsonArray = JSON.parse(res)

            jsonArray.forEach(function(element){
                buildElement(element)
            })


        }
    })
    
}

function buildElement(obj){
    let stringbuilder = new Array();
    stringbuilder.push("<div class='stu-item'>")
    stringbuilder.push("<img src='https://teenyda-blog.oss-cn-shenzhen.aliyuncs.com/blog-image/avatar.jpg' />");
    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder,"学号", obj.StuNo);
    appendInfo(stringbuilder,"姓名", obj.StuName);
    appendInfo(stringbuilder,"性别", obj.StuSex);
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder, "年级", obj.StuGrade);
    appendInfo(stringbuilder, "专业", obj.StuProfession);
    appendInfo(stringbuilder, "班级", obj.StuClass);
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder, "籍贯", obj.StuNativePlace);
    appendInfo(stringbuilder, "联系方式", obj.StuContact);
    appendInfo(stringbuilder, "住址", obj.StuAddress);
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='btn-op'>");
    stringbuilder.push("<button class='button is-info is-light is-small' onclick='updateStu("+ obj.StuId+")'>修改</button>");
    stringbuilder.push("<button class='button is-danger is-light is-small' onclick='deleteStu("+ obj.StuId+")'>删除</button>");
    stringbuilder.push("</div>");
    stringbuilder.push("</div>");
    //console.log(stringbuilder);
    $("#cont2").append(stringbuilder.join("\n"));
}

function setHeight(){
    //168是footer高度
    let height = window.screen.height - 168;
    $("#content").css("min-height", height);
}

function appendInfo(sb,key, val) {
    sb.push("<p>");
    sb.push(`<span class='span-txt'>${key}</span>`);
    sb.push(`<span class='stu-value'>${val}</span>`);
    sb.push("</p>");
}

class BulmaModal {
    constructor(selector) {
        this.elem = document.querySelector(selector)
        this.close_data()
    }

    show() {
        this.elem.classList.toggle('is-active')
        this.on_show()
    }

    close() {
        this.elem.classList.toggle('is-active')
        this.on_close()
    }

    close_data() {
        var modalClose = this.elem.querySelectorAll("[data-bulma-modal='close'],.modal-background")

        var that = this
        modalClose.forEach(function(e) {
            e.addEventListener("click", function() {

                that.elem.classList.toggle('is-active')
                var event = new Event('modal:close')

                that.elem.dispatchEvent(event);
            })
        })
    }

    on_show() {
        var event = new Event('modal:show')

        this.elem.dispatchEvent(event);
    }

    on_close() {
        var event = new Event('modal:close')

        this.elem.dispatchEvent(event);
    }

    addEventListener(event, callback) {
        this.elem.addEventListener(event, callback)
    }
}

var btn = document.querySelector("#btn")
var mdl = new BulmaModal("#myModal")

btn.addEventListener("click", function () {
    //mdl.show()
})

mdl.addEventListener('modal:show', function () {
    console.log("opened")
})

mdl.addEventListener("modal:close", function () {
    console.log("closed")
})

//添加学生 更新学生
function submit() {


    let stu_no = $("#stu_no").val()
    let stu_name = $("#stu_name").val()
    let stu_sex = $("#stu_sex").val()
    let stu_age = $("#stu_age").val()
    let stu_grade = $("#stu_grade").val()
    let stu_profession = $("#stu_profession").val()
    let stu_class = $("#stu_class").val()
    let stu_native_place = $("#stu_native_place").val()
    let stu_contact = $("#stu_contact").val()
    let stu_address = $("#stu_address").val()

    let obj = {
        stuNo: stu_no,
        stuName: stu_name,
        stuSex: stu_sex,
        stuAge: stu_age,
        stuGrade: stu_grade,
        stuProfession: stu_profession,
        stuClass: stu_class,
        stuNativePlace: stu_native_place,
        stuContact: stu_contact,
        stuAddress: stu_address
    }

    let action = $("#ContentPlaceHolder1_stuSett").val()

    // 更新
    if (action !== "insert"){
        obj.StuId = $("#stuId").val();
        console.log(obj)
        $.ajax({
            url: "/api/Student",
            contentType: "application/json",
            data: "'" + JSON.stringify(obj) + "'",
            type: 'PUT',

            success: function(res){
                console.log(res)
                let resObj = JSON.parse(res)
                if(resObj.msg === "success"){
                    alert("更新成功!")
                    window.location.href = "/View/Query/StuQuery.aspx"
                }
            }
        })
    }else{
        //添加
        console.log(obj)
        $.ajax({
            url: "/api/Student",
            contentType: "application/json",
            data: "'" + JSON.stringify(obj) + "'",
            type: 'POST',

            success: function (res) {
                let resObj = JSON.parse(res)
                if(resObj.msg === "success"){
                    alert("添加成功!")
                    window.location.href = "/View/Query/StuQuery.aspx"
                }
            }
        })
    }

    

}

//修改学生
function updateStu(stuId){

    window.location.href = "/View/Add/StuAdd.aspx?action=update&id=" + stuId;

    //$.ajax({
    //    url: "/api/UpdatePage/" + stuId,
    //    contentType: "application/json",
    //    //data: "'" + JSON.stringify(obj) + "'",
    //    type: 'PUT',

    //    success: function(){
    //        console.log("success")
    //    }
    //})
}

//删除学生
function deleteStu(stuId){
    $.ajax({
        url: "/api/Student/" + stuId,
        contentType: "application/json",
        //data: "'" + JSON.stringify(obj) + "'",
        type: 'DELETE',

        success: function(res){
            let resObj = JSON.parse(res)
            if(resObj.msg === "success"){
                alert("删除成功!")
                window.location.reload()
            }
        }
    })
}

//更改管理员密码
function updatePassword(){
    let admin_no = $("#admin_no").val()
    let admin_pass = $("#admin_pass").val()
    let admin_pass_confirm = $("#admin_pass_confirm").val()
    if (!admin_pass || !admin_pass_confirm) {
        alert("请输入密码")
        return
    }

    if (admin_pass !== admin_pass_confirm) {
        alert("密码不一致")
        return
    }

    let obj = {
        adminNo: admin_no,
        adminPass: admin_pass
    }

    $.ajax({
        url: "/api/Admin",
        contentType: "application/json",
        data: "'" + JSON.stringify(obj) + "'",
        type: 'PUT',
        success: function (res) {
            let resObj = JSON.parse(res)
            if (resObj.msg === "success") {
                alert("修改成功!")
                window.location.reload()
            }
        }
    })
}

function checkUpdate(){
    let action = $("#ContentPlaceHolder1_stuSett").val()
    // 添加
    if (action == "insert"){

    }else if(action){
        //id
        $.ajax({
            url: "/api/Student/" + action,
            contentType: "application/json",
            //data: "'" + JSON.stringify(obj) + "'",
            type: 'GET',

            success: function(res){
                let stu = JSON.parse(res)
                console.log(stu)
                $("#stuId").val(stu.StuId)
                $("#stu_no").val(stu.StuNo) 
                $("#stu_name").val(stu.StuName)
                $("#stu_sex").val(stu.StuSex)
                $("#stu_age").val(stu.StuAge)
                $("#stu_grade").val(stu.StuGrade)
                $("#stu_profession").val(stu.StuProfession)
                $("#stu_class").val(stu.StuClass)
                $("#stu_native_place").val(stu.StuNativePlace)
                $("#stu_contact").val(stu.StuContact)
                $("#stu_address").val(stu.StuAddress)
            }
        })
    }
}

