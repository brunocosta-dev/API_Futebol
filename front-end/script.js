const fetchAPI = fetch('http://localhost:5020/times', {
    method: 'GET',
    headers: {
        'Content-Type': 'application/json'
    }
}).then((res) => res.json()).then((data) => console.log(data));

console.log(fetchAPI);