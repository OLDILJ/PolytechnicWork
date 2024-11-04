<div class="wrapper">
    <p class="New">New</p>
    <p class="Load">Load</p>
    <p class="Options">Options</p>
    <p class="Prior">Prior Runs</p>
</div>
    
<style>

    .wrapper
    {
        margin-left: 10%;
        margin-right: 10%;
        width: 80%;
        border: 1px solid black;
        overflow: hidden;
    }
    .New
    {
        display: flex;
        justify-content: left;
        margin-left:15em;
        margin-right: 13em;
        float:left;
        font-size: 2em;
        
    }
    .Load
    {
        display: flex;
        justify-content: right;
        margin-right: 13em;
        float:left;
        font-size: 2em;
        
    }
    .Options
    {
        margin-top: 10%;
        display: flex;
        justify-content: left;
        margin-left:15em;
        margin-right: 11.8em;
        clear: both;
        float: left;
        font-size: 2em;
    }
    .Prior
    {
        margin-top: 10%;
        display: flex;
        justify-content: left;
        margin-right: 12em;
        float: left;
        font-size: 2em;
    }
    p
    {
        border: 0.1em solid black;
        transition: 1s cubic-bezier(0.075, 1, 0.765, 1);
        animation: flicker 0.25s infinite ease-out;
        animation-play-state: paused;
    }
    p:hover
    {
        animation-play-state: running;
    }
    p:not(:hover)
    {
        transition: 1s cubic-bezier(0.075, 1, 0.765, 1);
        animation: flicker 0.0s infinite ease-out;
        animation-play-state: paused;
        color: brown
    }
    @keyframes flicker
    {
        0%
        {
            color: brown
        }
        50%
        {
            color: rgb(199, 78, 48);
        }
        100%
        {
            color:rgb(255, 166, 0);
        }
    }

</style>