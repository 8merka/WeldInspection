var modal = document.getElementById("myModal");
        var btn = document.getElementById("add-button");
        var span = document.getElementsByClassName("close")[0];


        btn.onclick = function () {
            modal.style.display = "block";
        }

        span.onclick = function () {
            modals.style.display = "none";
        }

        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }