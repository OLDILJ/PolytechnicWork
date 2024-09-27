<script>
    const d = new Date();
    export let year = d.getFullYear();
    let CurTime = d.toDateString();
</script>

<p>Footer &copy; Local Date and Time: {CurTime} {d.getHours()}:{d.getMinutes()} {year}</p>




<style>
p
{
    background-color: sandybrown;
    padding: 2em;
    font-weight: bolder;
    font-size: larger;
    border: 0.25em dotted;
}
</style>