* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: sans-serif;
}

.tela-inicial {
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  background: #e0e0e0;
}

.logo-esporte {
  border: 2px solid #000;
  border-radius: 50%;
  width: 150px;
  height: 150px;
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  margin-bottom: 20px;
}

.botao-entrar {
  padding: 10px 20px;
  background: #000;
  color: #fff;
  text-decoration: none;
  border-radius: 5px;
}

.pagina-principal {
  padding: 20px;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.descricao {
  margin: 20px 0;
}

.galeria img {
  width: 30%;
  margin: 5px;
}

.conteudo {
  margin-top: 20px;
}

.imagem-grande img {
  width: 100%;
  max-height: 300px;
  object-fit: cover;
}

.texto p {
  margin: 10px 0;
}

.cards {
  display: flex;
  flex-wrap: wrap;
  gap: 10px;
  margin-top: 20px;
}

.card {
  width: calc(50% - 10px);
  height: 100px;
  background: #ccc;
}

footer {
  margin-top: 20px;
  text-align: center;
}

.logo {
  font-weight: bold;
}
