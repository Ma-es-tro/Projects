python = "./Images/python.png";
java = "./Images/java.png";
javascript = "./Images/Javascript.png";
Csharp = "./Images/Csharp.png";
c = "./Images/c++.png";
perl = "./Images/perl.png";
php = "./Images/php.png";
typescript = "./Images/typescript.png";



const pics = [
  python,
  java,
  javascript,
  Csharp,
  c,
  perl,
  php,
  typescript,
];




const gameBoard = document.querySelector(".game-board");
const cards = [...pics, ...pics];
let firstCard, secondCard;
let flippedCards = 0;
let lockBoard = false;
var delayInMilliseconds = 5000;

function shuffle(array) {
  for (let i = array.length - 1; i > 0; i--) {
    let j = Math.floor(Math.random() * (i + 1));
    [array[i], array[j]] = [array[j], array[i]];
  }
  return array;
}

function createCard(pics) {
  const card = document.createElement("div");
  card.classList.add("card");
  card.innerHTML = `
    <div class="card-inner">
      <div class="card-front"><img src="${pics}" class="${pics}" alt="programming language logo"></div>
      <div class="card-back"></div>
    </div>`;
  card.addEventListener("click", flipCard);
  return card;
}


function flipCard() {
  if (lockBoard) return;
  if (this === firstCard) return;

  this.classList.add("flipped");

  if (!firstCard) {
    firstCard = this;
    return;
  }

  secondCard = this;
  checkForMatch();
}

function checkForMatch() {

  const Correct = document.getElementById("Correct");
  const Wrong = document.getElementById("Wrong");
  const audio1 = document.getElementById("CorAud");
  const audio = document.getElementById("WroAud");

  Fun_Fact();

  if (firstCard.querySelector(".card-front img").className === secondCard.querySelector(".card-front img").className) {
    disableCards();
    
    Correct.classList.add("animate");
    audio1.play();
    Correct.addEventListener("animationend", () => {
      Correct.classList.remove("animate");
    });
    
    return;
  }
  
  if (firstCard.querySelector(".card-front img").className !== secondCard.querySelector(".card-front img").className) {
    Wrong.classList.add("animate");
    audio.volume = 0.2;
    audio.play();
    Wrong.addEventListener("animationend", () => {
      Wrong.classList.remove("animate");
    });
  }

  
  unflipCards();
  
}

function Fun_Fact() {
  const fact = document.getElementById("Fact");

  if (
    firstCard.querySelector(".card-front img").src.includes("python.png") &&
    secondCard.querySelector(".card-front img").src.includes("python.png")
  ) {
    fact.style.visibility = "visible"; 
    fact.classList.add("fade-in");
    fact.textContent = "Python seems like an odd name for a programming language. There is no truth to the popular belief that Python is named after the famous non-venomous snake of the same name. It has a whole different story to tell. Guido was a huge fan of “Monty Python’s Flying Circus”, a comedy TV show on the BBC. Back in the 70s, Monty Python was a renowned British comedy group that performed in British colonies. In honor of Monty Python’s Flying Circus, Guido decided to name the language Python, since he was a big fan.";
    fact.addEventListener("animationend", () => {
      fact.classList.remove("fade-in");
    });
    }
  
    else if (firstCard.querySelector(".card-front img").src.includes("java.png") &&
    secondCard.querySelector(".card-front img").src.includes("java.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "Originally, the language was named “Oak,” but it was later changed to Java, evoking the rich coffee culture in Indonesia, where the best coffee beans are grown.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("Csharp.png") &&
    secondCard.querySelector(".card-front img").src.includes("Csharp.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "The name “C#” was chosen because the symbol '#' (pound or hash) resembles a combination of the C and the musical sharp symbols.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("php.png") &&
    secondCard.querySelector(".card-front img").src.includes("php.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "PHP originally stood for “Personal Home Page.” Why? Rasmus Lerdorf, its creator, originally created the language for personal web development.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("perl.png") &&
    secondCard.querySelector(".card-front img").src.includes("perl.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "Perl was initially named “Pearl.” Larry Wall gave it a short name with positive connotations. He also thought about providing the title to it after his wife, Gloria. Wall revealed the existing PEARL programming language before Perl’s official release and changed the spelling of the name.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("typescript.png") &&
    secondCard.querySelector(".card-front img").src.includes("typescript.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "TypeScript builds upon JavaScript by adding static typing and other features. This means that any valid JavaScript code is also valid TypeScript code.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("c++.png") &&
    secondCard.querySelector(".card-front img").src.includes("c++.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "C++ supports four different types of memory management: static storage duration objects, thread storage duration objects, automatic storage duration objects, and dynamic storage duration objects.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    else if (firstCard.querySelector(".card-front img").src.includes("Javascript.png") &&
    secondCard.querySelector(".card-front img").src.includes("Javascript.png"))
    {
      fact.style.visibility = "visible"; 
      fact.classList.add("fade-in");
      fact.textContent = "The real name is not “Javascript”, but ECMAScript. ECMAScript is usually referred to when talking about the version of this language, but in reality, “Javascript” is a trademark registered by Sun Microsystems.";
      fact.addEventListener("animationend", () => {
        fact.classList.remove("fade-in");
      });
    }

    
}




function disableCards() {
  firstCard.removeEventListener("click", flipCard);
  secondCard.removeEventListener("click", flipCard);

  resetBoard();
}

function unflipCards() {
  lockBoard = true;

  setTimeout(() => {
    firstCard.classList.remove("flipped");
    secondCard.classList.remove("flipped");

    resetBoard();
  }, 1000);
}

function resetBoard() {
  [firstCard, secondCard] = [null, null];
  lockBoard = false;
}

function init() {
  const shuffledCards = shuffle(cards);
  shuffledCards.forEach(pics => {
    const card = createCard(pics);
    gameBoard.appendChild(card);
  });
}


init();
