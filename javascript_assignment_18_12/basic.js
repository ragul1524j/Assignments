
function GreatestAmongThree() {
    var a = 41;
    var b = 20;
    var c = 30;
    var res;
    if (a > b && a > c) {
        res = a;
    }
    else if (b > a && b > c) {
        res = b;
    }
    else {
        res = c;
    }
    document.getElementById("val1").innerText = "Greatest Value is " + res;
}


function SimpleInterest() {
    var num = 9020;
    var SI = (num * 5 * 2) / 100;
    document.getElementById("val2").innerText = "The Simple Interest Of " + num + " is " + SI;

}

function Difference() {
    var num = 15;
    var res;
    if (num <= 13) {
        res = 13 - num;
    }
    else {
        res = (num - 13) * 2;
    }
    document.getElementById("val3").innerText = "The Difference Between 13 and " + num + " is " + res;

}

function OddEnven() {
    for (var i = 0; i <= 15; i++) {
        var result = "";

        for (var i = 0; i <= 15; i++) {
            if (i % 2 == 0) {
                result += "The Number " + i + " is Even<br>";
            }
            else {
                result += "The Number " + i + " is Odd<br>";
            }
        }

        document.getElementById("val4").innerHTML = result;
    }
}