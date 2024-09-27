<script>
    export let ImageSource = Miniature;
    import Miniature from "$lib/FrenchMiniature.png"
</script>

<div><img src={ImageSource} alt="Random Miniature"></div>

<style>
    div
    {
        display: flex;
        flex-direction: column;
        max-width: 50em;
    }
</style>