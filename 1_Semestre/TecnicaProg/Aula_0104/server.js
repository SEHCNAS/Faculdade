const app = require('./app');

//Define a porta 
app.set('port', 7777);

const server = app.listen(app.get('port'), () =>{
    console.log("O servidor rodando na porta: " + server.address().port);
});