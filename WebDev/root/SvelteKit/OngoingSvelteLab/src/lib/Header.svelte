<script>
    export let headerTitle = "Ongoing Svelte Test";
</script>

<header>
    <h1>{headerTitle}</h1>
    <nav>
        <ul>
            <li><a href="/">Home</a></li>
            <li><a href="/About">About</a></li>
            <li><a href="/Contact">Contact</a></li>
        </ul>
    </nav>
</header>

<style>
li
{
    justify-self: center;
    justify-content: space-evenly;
    list-style-type: none;
    padding: 2em;
    display: inline;
}
</style>