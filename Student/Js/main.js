
$(document).ready(function () {
    setHeight();
    loadData();

})

function loadData() {
    let stringbuilder = new Array();
    stringbuilder.push("<div class='stu-item'>")
    stringbuilder.push("<img src='https://teenyda-blog.oss-cn-shenzhen.aliyuncs.com/blog-image/avatar.jpg' />");
    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder,"学号", "1915100104");
    appendInfo(stringbuilder,"姓名", "露小哒哒");
    appendInfo(stringbuilder,"性别", "男");
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder, "年级", "2017级");
    appendInfo(stringbuilder, "专业", "计算机科学与技术");
    appendInfo(stringbuilder, "班级", "计17计算机专升本1班");
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='info'>");
    appendInfo(stringbuilder, "籍贯", "广西");
    appendInfo(stringbuilder, "联系方式", "15278389583");
    appendInfo(stringbuilder, "住址", "广西容县杨梅镇凤美村2号");
    stringbuilder.push("</div>");

    stringbuilder.push("<div class='btn-op'>");
    stringbuilder.push("<button class='button is-info is-light is-small'>修改</button>");
    stringbuilder.push("<button class='button is-danger is-light is-small'>删除</button>");
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

//添加学生
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

    $.ajax({
        url: "/api/Student",
        contentType: "application/json",
        data: "'" + JSON.stringify(obj) + "'",
        type: 'POST',

        success: function(){
            console.log("success")
        }
    })

}

//更改管理员密码
function updatePassword(){
    let admin_no = $("#admin_no").val()
    let admin_pass = $("#admin_pass").val()

}