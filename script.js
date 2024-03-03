function showCountries() {
    const imageElement = document.getElementById('imageContainer');
    imageElement.src = "C:/Users/Asus/Desktop/My First Step/Belfa.Web/Files for BF.Web/FlagP.png";
    const buttonElement = document.getElementsByTagName('button')[0];
    buttonElement.style.display = 'none';
}

let TotalCountries = 4;
let CurrentIndex = 1;

function Next() {
    CurrentIndex += 1;  // Corrected this line

    if (CurrentIndex === 2) {
        const imageElement = document.getElementById('imageContainer');
        imageElement.src = "C:/Users/Asus/Desktop/My First Step/Belfa.Web/Files for BF.Web/FlagMa.png";
        const Poland = document.getElementById('Poland')
        Poland.classList.toggle('Info')
        const temp = Poland.innerHTML;
    }
    else if (CurrentIndex === 3) {
        const imageElement = document.getElementById('imageContainer');
        imageElement.src = "C:/Users/Asus/Desktop/My First Step/Belfa.Web/Files for BF.Web/FlagMa.png";
        const Malta = document.getElementById('Malta');
        Malta.classList.toggle('Info');
        Poland.innerHTML = Malta.innerHTML;
        Malta.innerHTML = temp;
    }
    // You can add more conditions for other country indices if needed
}
