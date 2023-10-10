/* BEGIN EXTERNAL SOURCE */
function name0() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name1() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name2() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name3() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name4() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name5() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name6() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name7() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name8() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */
function name9() {
return false;
}
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

var modal = document.getElementById("myModal");
var btn = document.getElementById("add-button");
var span = document.getElementsByClassName("close")[0];


btn.onclick = function() {
  modal.style.display = "block";
}

span.onclick = function() {
  modal.style.display = "none";
}

window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}
    
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

        var modal = document.getElementById("myModal");
        var btn = document.getElementById("edit-button");
        var span = document.getElementsByClassName("close")[0];
        
        
        btn.onclick = function() {
          modal.style.display = "block";
        }
        
        span.onclick = function() {
          modal.style.display = "none";
        }
        
        window.onclick = function(event) {
          if (event.target == modal) {
            modal.style.display = "none";
          }
        }
            
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

        var links = document.querySelectorAll('.select-block a');
var blocks = document.querySelectorAll('.information-block .data-block');
var editingBlocks = document.querySelectorAll('.information-block .editing-block div');
for (var i = 0; i < links.length; i++) {
    links[i].addEventListener('click', function() {
        var current = document.querySelector('.select-block a.active');
        current.classList.remove('active');
        this.classList.add('active');
        var index = Array.prototype.indexOf.call(links, this);
        for (var j = 0; j < blocks.length; j++) {
            if (j == index) {
                blocks[j].style.display = 'inline';
            } else {
                blocks[j].style.display = 'none';
            }
        }
        if (index >6) {
            for (var k =0; k<editingBlocks.length;k++){
                editingBlocks[k].style.display='none';
            }
        } else {
            for (var k =0; k<editingBlocks.length;k++){
                editingBlocks[k].style.display='flex';
            }
        }
    });
}
        
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

            var links = document.querySelectorAll('.select-block a');
            var forms = document.querySelectorAll('.modal form');
            for (var i = 0; i < links.length; i++) {
                links[i].addEventListener('click', function() {
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
            
/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

      fetch('https://localhost:7070/swagger/index.htm')
      .then(response => response.json())
      .then(data => {
        let container = document.getElementById('data1');
        data.forEach(item => {
          let row = document.createElement('div');
          item.split(' ').forEach(word => {
            let block = document.createElement('div');
            block.classList.add('block');
            block.textContent = word;
            row.appendChild(block);
          });
          container.appendChild(row);
        });
      });
            
/* END EXTERNAL SOURCE */
