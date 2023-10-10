var links = document.querySelectorAll('.select-block a');
        var forms = document.querySelectorAll('.modal form');
        for (var i = 0; i < links.length; i++) {
            links[i].addEventListener('click', function () {
                var current = document.querySelector('.select-block a.active');
                current.classList.remove('active');
                this.classList.add('active');
                var index = Array.prototype.indexOf.call(links, this);
                for (var j = 0; j < forms.length; j++) {
                    if (j == index) {
                        forms[j].style.display = 'flex';
                    } else {
                        forms[j].style.display = 'none';
                    }
                }
            });
        }