//Fazer import do express
const express = require('express');

//Rotas - quando o servidor for acessado, para onde ele vai?
const router  = express.Router();

//Primeira rota e função anonima com dois parametros
router.get('/', (req, res) => {
    res.send('Ola mundo!');

});

//Configurações basicas do app
const app = express();
app.use('/', router);

//Exportamos o app, iremos importa-lo no servidor
module.exports = app;