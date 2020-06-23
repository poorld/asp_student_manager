<%@ Page Language="C#" Theme="Login" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Student.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <div class="login-text">登陆</div>
            <div class="username">
                <svg t="1577768129737" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="2601" width="16" height="16"><path d="M511.808 512c121.344 0 219.84-100.352 219.84-224.128S633.152 63.808 511.808 63.808c-121.408 0-219.84 100.288-219.84 224.064s98.368 224.128 219.84 224.128z m302.848 139.84c-50.24-58.496-67.2-78.656-159.168-84.032h-287.04c-92.032 5.504-108.928 25.536-159.04 84.032-53.376 60.352-95.872 137.024-75.776 231.872 22.4 62.144 82.688 76.416 139.904 76.416H750.592c57.152 0 117.568-14.4 139.968-76.416 19.904-94.848-22.528-171.456-75.904-231.872z" p-id="2602" data-spm-anchor-id="a313x.7781069.0.i0" class="selected" fill="#ffffff"></path></svg>
                <input type="text" id="username" value="admin">
            </div>

            <div class="passowrd">
                <svg t="1577768133736" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="3316" data-spm-anchor-id="a313x.7781069.0.i2" width="16" height="16"><path d="M826.547856 388.599575h-29.288257v-103.168029a285.316915 285.316915 0 1 0-570.633829 0v103.168029h-29.230942A114.28725 114.28725 0 0 0 83.279525 502.714877v406.940558a114.28725 114.28725 0 0 0 114.115303 114.115303h629.153028a114.28725 114.28725 0 0 0 114.115303-114.115303v-406.940558a114.28725 114.28725 0 0 0-114.115303-114.115302zM306.810254 285.316915a205.075115 205.075115 0 1 1 410.15023 0v103.168028H306.810254z m553.553789 624.739729a33.930818 33.930818 0 0 1-33.873502 33.873503H197.394828a33.930818 33.930818 0 0 1-33.873503-34.102765v-406.940558a33.930818 33.930818 0 0 1 33.873503-33.873503h629.153028a33.930818 33.930818 0 0 1 33.873503 33.873503z" fill="#ffffff" p-id="3317" data-spm-anchor-id="a313x.7781069.0.i0" class="selected"></path><path d="M512 553.66842a107.180119 107.180119 0 0 0-22.295757 212.067615v58.060674a22.467704 22.467704 0 1 0 44.935408 0v-56.16926-1.891414a107.180119 107.180119 0 0 0-22.295758-212.067615z m0 168.507781a61.327661 61.327661 0 1 1 61.327661-61.327662A61.384977 61.384977 0 0 1 512 722.176201z" fill="#ffffff" p-id="3318" data-spm-anchor-id="a313x.7781069.0.i1" class="selected"></path></svg>
                <input type="text" id="password" value="12345">
            </div>

            <div class="record">
                <input type="checkbox" id="record-pass" name="r1"/>
			    <label for="record-pass">记住账号</label>  
            </div>

            <span class="btn" onclick="login()">
                登陆
            </span>

        </div>
    </form>

    <script language="javascript" src="/Js/jquery-3.5.1.min.js"></script>
</body>
</html>
