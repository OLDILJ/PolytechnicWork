<script lang="ts">
    import type { PageData } from './$types';
    import Head from "$lib/Header.svelte";
    export let data: PageData;
</script>


<Head headerTitle = "Contact"/>

<p>Lorem ipsum dolor sit amet.
Eum officia nemo molestiae incidunt!</p>

<p></p>
<ul>
    <li>Name: <input type="text" name="" id=""></li>
    <li>Phone: <input type="tel" name="Phone" id=""></li>
    <li>Email: <input type="email" name="Email" id=""></li>
    Message Destination: <select name="" id="">
        <option value="Shredder">Shredder</option>
        <option value="Retail">Retail</option>
        <option value="Admin">Admin</option>
        <option value="Distribution">Distribution</option>
    </select>
</ul>

<style>
    ul > *{
        
    list-style-type: none;
    padding: 1em;
    }
    select
    {
        font-size-adjust: 5em;

    }
</style>