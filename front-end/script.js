const listaTimes = document.getElementById('times-lista');
const apiUrl = 'http://localhost:5020/times';

const getTimes = async () => {
    try{
        const response = await fetch(apiUrl,{
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if(!response.ok){
            throw new Error('Erro ao buscar os times!');
        }

        const times = await response.json();
        
        times.forEach((time) => {
            const newLi = document.createElement('li');
            newLi.innerText = `Nome: ${time.nome}`;
            listaTimes.appendChild(newLi);
        });
        
    }
    catch(error){
        listaTimes.innerText = `${error.message}`;
    }
}

getTimes();
