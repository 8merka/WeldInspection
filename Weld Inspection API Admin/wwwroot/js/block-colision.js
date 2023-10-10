var links = document.querySelectorAll('.select-block a');
var blocks = document.querySelectorAll('.information-block .data-block');
var editingBlocks = document.querySelectorAll('.information-block .editing-block div');
for (var i = 0; i < links.length; i++) {
    links[i].addEventListener('click', function () {
        var current = document.querySelector('.select-block a.active');
        if (current) {
            current.classList.remove('active');
            var dataBlock = current.closest('.select-block').querySelector('.data');
            if (dataBlock) {
                dataBlock.innerHTML = '';
            }
        }
        this.classList.add('active');
        var index = Array.prototype.indexOf.call(links, this);
        for (var j = 0; j < blocks.length; j++) {
            if (j == index) {
                blocks[j].style.display = 'inline';
                console.log(index)
                GetData(index);
            } else {
                blocks[j].style.display = 'none';
            }
        }
        if (index > 6) {
            for (var k = 0; k < editingBlocks.length; k++) {
                editingBlocks[k].style.display = 'none';
            }
        } else {
            for (var k = 0; k < editingBlocks.length; k++) {
                editingBlocks[k].style.display = 'flex';
            }
        }
    });
}