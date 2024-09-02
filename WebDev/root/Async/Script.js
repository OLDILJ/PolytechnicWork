async function GetCatFact()
{
    const response = await fetch('https://meowfacts.herokuapp.com/?count=2')
    const CatData = await response.json();
    console.log(CatData.data)
    ShowCatFact(CatData.data);
}
const container = document.querySelector("#Fact")
function ShowCatFact(CatData)
{
    const myArticle = document.createElement("article");
    myArticle.innerHTML = `
        <p>${CatData[0]}</p>
        <p>${CatData[1]}</p>
        `;
    container.appendChild(myArticle);  
}

