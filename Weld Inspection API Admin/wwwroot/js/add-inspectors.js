document.getElementById('add-button-1').addEventListener('click', function (event) {
    event.preventDefault();

    var form = document.getElementById('form1');
    let data1 = document.getElementById('data1').children.length;
    var block = document.querySelectorAll('.information-block .data-block')[0];

    let data = {
        id: data1 + 1,
        firstName: document.getElementById('name').value,
        lastname: document.getElementById('lastName').value,
        login: document.getElementById('login').value,
        password: document.getElementById('password').value,
        phone: document.getElementById('phone').value,
        email: document.getElementById('email').value,
        dateOfBirdth: document.getElementById('birthday').value,
        yearsOfWorking: parseInt(document.getElementById('experience').value),
        rating: parseInt(document.getElementById('error_rate').value)
    };
    document.getElementById("myModal").style.display = "none";
    form.reset();


    fetch('/api/Inspectors/CreateInspector', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('HTTP error! status: ${ response.status }');
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);

        })
        .catch((error) => console.error('Error:', error));

    block.querySelector('.data').innerHTML = '';
    setTimeout(function () {
        GetData(0);
    }, 200);
});