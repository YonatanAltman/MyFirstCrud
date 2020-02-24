<div>

    <h2>Home</h2>

    <h1>
        @SessionManager.User
    </h1>
    <span id="time" style="color:darkblue;font-size:x-large">60</span>

</div>
<script>


        let time = 60;

    setInterval(() => {
        time--;
            document.getElementById('time').innerText = time;

        }, 1000)
 

</script>