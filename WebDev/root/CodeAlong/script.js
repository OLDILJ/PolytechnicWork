const MovieData =
[
{
    id: 1,
    title: "The Mask",
    director: "Russell Chuck",
    year: 1994,
    genre: "comedy",
    rating: 9,
    starring:"Jim Carrey",
},
{
    id: 2,
    title: "Ace Ventura: Pet Detective",
    director: "Tom Shadyac",
    year: 1994,
    genre: "comedy",
    rating: 8,
    starring: "Jim Carrey",
},
{        
    id: 3,
    title: "Liar Liar",
    director: "Tom Shadyac",
    year: 1997,
    genre: "comedy",
    rating: 7,
    starring: "Jim Carrey"
}        
        
    
    

]

const container = document.querySelector("#DataTaker");
const webpage = document.querySelector("body");
const MovieCard = document.createElement("div");
for (const obj of MovieData)
{
const objData = document.createElement("div");
objData.innerHTML = 
`
<h2 class="Id">${obj.id}</h2>
<h3 class="MovieTitle">${obj.title}</h3>
<p class="Director">${obj.director}</p>
<p class="Genre">${obj.genre}</p>
<p class="Year">${obj.year}</p>
`
webpage.appendChild(objData);
}
getMovies();

async function getMovies()
{
    const res = await fetch("https://web1-z04e.onrender.com/movies")
    const fetchedMovies = await res.json();
    console.log("DEBUG");
    console.log(fetchedMovies);
    ShowMovie(fetchedMovies);
}
function ShowMovie(fetchedMovies)
{
    for (const obj2 of fetchedMovies)
        {
        const obj2Data = document.createElement("div");
        GrabList(fetchedMovies);
        obj2Data.innerHTML = 
        `
        <h2 class="Id">${obj2.id}</h2>
        <h3 class="MovieTitle">${obj2.title}</h3>
        <p class="Director">${obj2.director}</p>
        <p class="Director">${obj2.genre}</p>
        <p class="Year">${obj2.year}</p>
        `
        webpage.appendChild(obj2Data);
        }
}
function GrabList(fetchedMovies)
{
    

}
/*
MovieCard.innerHTML = 
`
<h2 class="Id">${MovieData[0].id}</h2>
<h3 class="MovieTitle">${MovieData[0].title}</h3>
<p class="Director">${MovieData[0].director}</p>
<p class="Year">${MovieData[0].year}</p>
`


webpage.appendChild(MovieCard);
*/
/*
function ShowMovieData(MovieData)

{
    const myArticle = document.createElement("article");
    myArticle.innerHTML = `
        <p>"Hello World"</p>
        <p>${MovieData[0]}</p>
        `;
    container.appendChild(myArticle);  
}

*/