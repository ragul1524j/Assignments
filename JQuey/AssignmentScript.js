$("#moveto").click(() => {
    $("#div2").html($("#div1").html());
    $("#div1").empty();
})

$("#comeback").click(() => {
    $("#div1").html($("#div2").html());
    $("#div2").empty();
})

$("#div2").click(function () {
    $(this).hide(2000);
});

$("#change").click(() => {
    $("#imgae").attr('src', 'https://fugitives.com/wp-content/uploads/2023/06/Demon-Slayer-Character-Kibutsuji-Muzan-Explained-2023-Series.jpg')
})

$("#colorchange").click(() => {
    $(".textbox").css({ "background-color": "blue" })
})


$("#validate").click(() => {
    var name = $("#name").val();
    var pass = $("#password").val();
    if (name == 'admin' && pass == 'sece@123') {
        alert("Login Successful");
        window.location = 'home.html';
    }
    else {
        alert("UserName or Password Invalid!!!");
        $(".login-css").css({ "background-color": "red" });
    }
})


$(".focusbox").focus(function () {
    $(".focusbox").addClass("focus-style");
});

$(".focusbox").blur(function () {
    $(".focusbox").removeClass("focus-style");
});

$(".focusbox2").focus(function () {
    $(".focusbox2").addClass("focus-style");
});

$(".focusbox2").blur(function () {
    $(".focusbox2").removeClass("focus-style");
});

$(".focusbox3").focus(function () {
    $(".focusbox3").addClass("focus-style");
});

$(".focusbox3").blur(function () {
    $(".focusbox3").removeClass("focus-style");
});



$("#mouse-coursor").mouseover(function()
{
    $("#mouse-coursor").css( {"background-color": "orange",
    "color": "white"})
})
$("#mouse-coursor").mouseout(function()
{
    $("#mouse-coursor").css( {"background-color": "lightblue",
    "color": "black"})
})

$("div").children("h1").css({"background-color" : "lightgreen"})

$(document).ready(function()
{
    let h1 = $("h1").length;
    let div = $("div").length;
    let p = $("p").length;

    $(".Count-outer").html(
        "No of H1 : " + h1 + "<br>" +
        "No of Div : " + div + "<br>" +
        "No of Paragraphs : " + p
    );
});
