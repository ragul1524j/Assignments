function ColorChange() {
    var res = document.getElementById("selection").value;
    document.getElementById("color").style.backgroundColor = res;
}


function Validate(event) {
    event.preventDefault();
    var name = document.getElementById("username").value;
    var pass = document.getElementById("password").value;
    if (name != "admin" || pass != "india") {
        document.getElementById("username").style.backgroundColor = 'red';
        document.getElementById("password").style.backgroundColor = 'red';
        alert("Invadil Username or Password")
    }
    else {
        window.location = "Home.html"
        alert("Login Successful");
    }
}




function ShowImage(btn) {
    var img = btn.closest("tr").querySelector("img");

    if (img.style.display === "none") {
        img.style.display = "block";
    } else {
        img.style.display = "none";
    }
}


function Iterator()
{
    var Name = document.getElementById("name").value;
    var Count = document.getElementById("count").value;
    var result = "";
    for(var i=0;i<Count;i++)
    {
        result += Name +"<br>";
    }
    document.getElementById("val").innerHTML = result;
}

var images = [
    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtXvtIEChpSeWTWq-Dg1YI7ewFcUBzjGMO0Q&s",
    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDBEQARk3CDehNreA3z07i5BZUSXQsSKXHqw&s",
    "https://media.assettype.com/thequint/2018-10/75446349-b14a-4db7-b23f-b25c46b15c2f/4939df75_e318_4ed2_ac05_519d56079cf8.jpeg?auto=format,compress&fmt=webp&format=webp&w=1200&h=900&dpr=1.0",
    "https://d23.com/app/uploads/2013/04/Marvel-Entertainment-1180x600.jpg",
    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSoFTrYc3wv_6KW6vwuwQBl2cyfymupJN0PsQ&s",
    "https://media.assettype.com/nationalherald%2F2019-10%2F337a7751-e25e-4f91-9b33-cb2785f6f4f1%2FKarthi_Kaithi.jpg?rect=0%2C27%2C700%2C394&auto=format%2Ccompress&fmt=webp&w=1200"
];

var index = 0;

setInterval(function(){
    index = (index + 1) % images.length;
    document.getElementById("selector").src = images[index];
},3000);

