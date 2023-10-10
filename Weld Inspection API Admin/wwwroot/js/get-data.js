function GetData(index)
{
    let number = index + 1;
    var url = '0';
    var blockID = 'data';
    switch (number){
        case 1:
            url = '/api/Inspectors/GetAllInspectors';
            blockID = 'data' + number;
            break;
        default:
            console.error('Variable was not a link');
            break;
    }
            fetch(url)
            .then(function (response) {
                responseClone = response.clone();
                console.log(responseClone); 
                return response.json();
            })
            .then(function (data) {
                let container = document.getElementById(blockID);
                if (!container) {
                    console.error('Element with id "data1" not found');
                    return;
                }
                if (!Array.isArray(data)) {
                    console.error('Data is not an array');
                    return;
                }
                
                const blockSize = data.length;
                const blockData = new Array(blockSize);
                for (let i = 0; i < blockSize; i++) {
                    blockData[i] = data.slice(i, i + 1);
                }
                const data1 = document.getElementById(blockID);
                for (let i = 0; i < blockSize; i++) {
                    const block = document.createElement('div');
                    block.classList.add('json-information');
                    const obj = blockData[i][0];
                    for (const key in obj) {
                        const value = obj[key];
                        const item = document.createElement('div');
                        item.textContent = value;
                        block.appendChild(item);
                    }
                    data1.appendChild(block);
                }
            })
            .catch(error => console.error(error));
            }