let ApiButton = document.getElementsByClassName("ApiCall");
//let webpage = document.getElementById("#Test");
let randpkm = getRandInt(1026);
let webpage = document.querySelector("body");
ApiButton[0].addEventListener("click", function (e)
{
    randpkm = getRandInt(1026);
    console.log(this.className);
    console.log(randpkm);
    console.log("https://pokeapi.co/api/v2/pokemon/" + randpkm)
    ApiFetch();
})

function getRandInt(max)
{
    return Math.floor(Math.random() * max);
}

async function ApiFetch()
{
    const res = await fetch ("https://pokeapi.co/api/v2/pokemon/" + randpkm);
    const pokemonData = await res.json();
    console.log(pokemonData);
    CreatePokemonCard(pokemonData);
}
function CreatePokemonCard(ObjData)
{
    const myCard = document.createElement("article");
    
    myCard.innerHTML = `
    <h2 class="Id">${ObjData.id}</h2>
    <h3 class="PokemonName">${ObjData.name}</h3>
    <p class="Sprite">${ObjData.sprites.front_default}</p>
    <p class="species">${ObjData.species}</p>
    `
    webpage.appendChild(myCard);
    
    ObjData.types.forEach(element => {
        myCard.innerHTML = `
    <p class="types">${element.type.name}</p>
    `
    console.log(element);
    webpage.appendChild(myCard);
    });
    
    
}
