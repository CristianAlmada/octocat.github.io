h1 {
  color: blue;
}
@import url('https://fonts.googleapis.com/css?family=Montserrat:400,800');
body{
    font-family:'Montserrat', sans-serif;
}
@import url('https://fonts.googleapis.com/css?family=Montserrat:400,800');

body{
    background: #f6f5f7;
    font-family: 'Montserrat', sans-serif;
    color: #3E363F;
    }
#contenedor{
    width: 900px;
    height: 500px;
    text-align: center;
    /* Estas 3 lineas se encargan de centrar el div vertical y horizontalmente */
    position: absolute;
    inset: 0;
    margin: auto;
    overflow: hidden; 
    box-shadow: 0 14px 28px rgba(0,0,0,0.25), 
    0 10px 10px rgba(0,0,0,0.22);
}
#calculadora{
    background: white;
    /* Con estas 3 lineas vamos a hacer que los divs queden lado a lado */
    width: 50%;
    height: 100%;
    float: left;
}

#detalle{
    background: #FF416C;
    /* Con estas 3 lineas vamos a hacer que los divs queden lado a lado */
    width: 50%;
    height: 100%;
    float: left;
    color: #f6f5f7;
}
.contenido{
    /* Estas tres lineas van a centrar el contenido verticalmente dentro de cada div */
    position: relative;
    top: 50%;
    transform: translateY(-50%);
    overflow: hidden;
    padding: 40px;
}
input {
	width: 70%;
    padding: 12px 15px;
    border: none;
    background-color: #eee;
}

button {
  font-size: 15px;
	font-weight: bold;
	padding: 12px 45px;
	border-radius: 30px;
	background-color: #FF416C;
	border: 1px solid #FF416C;
	color: #FFFFFF;
	text-transform: uppercase;
	letter-spacing: 1px;
	transition: transform 20ms ease-in;
}

button:active {
	transform: scale(0.95);
}
#error{
    color: red;
    font-weight: bold;
    display: none;
}
.resultado{
    color: #0A81D1;
    font-weight: bold;
    font-size: 25px;
    margin-bottom: 5px;
    display: none;
}