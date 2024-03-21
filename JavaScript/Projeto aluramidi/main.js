 //Exemplo para reproduzir o som em apenas um botão // 
 /*
function tocaSomClap () {
    document.querySelector('#som_tecla_clap').play();
}

listaDeTeclas[1].onclick = tocaSomClap;
*/


function tocaSom (seletorAudio) {

  const elemento =  document.querySelector(seletorAudio);
  

  if (elemento != null && elemento.localName  == 'audio') {
      elemento.play();
  }

  else {
    console.log ('Elemento não encontrado');
  }

}


const listaDeTeclas = document.querySelectorAll('.tecla');


//repetição para
for (let contador = 0; contador < listaDeTeclas.length; contador++) {

   const tecla = listaDeTeclas[contador];
   const instrumento = tecla.classList[1];

   //template string
   const idAudio = `#som_${instrumento}`


   tecla.onclick = function () {
     tocaSom(idAudio);
   }

 // console.log(contador);

 tecla.onkeydown = function (evento) {

  if (evento.code === 'Space' || evento.code === 'Enter') {
      tecla.classList.add('ativa');
  }

}


  tecla.onkeyup = function () {
    tecla.classList.remove('ativa');
  }

}