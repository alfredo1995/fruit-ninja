Esse projeto inclui todos esses elementos de UI:

    UI inclui qualquer texto, botoes ou exibir algo que o usuario consiga ler ou interagir

    Temos a Tela de titulo, com botoes de meunu onde o jogador pode escolher a dificuldade.
    Durante o jogo, a Pontuação do jogador será rastreada e exibida.
    No final tera um tela Game Over capaz de reiniciar o jogo.
    
    Ui de Menu de opções de dificuldade (easy, medium e hard);
	
    Configuração easy faz com que os objetos sejam lançados lentamente;
    Configuração hard faz com que os objetos sejam lançados rapidamente;
    Qunado o EventListener do botão for chamado vai executar o metodo SetDifficult;
    O metodo SetDifficult tomará o valor da difuldade e comunicar para o script GameManager,
    responsavel por gerenciar a cena. 

    No script GameManager tera o metoodo StartGame será tomado esse valor de dificuldade e
    usado para alterar o spawRate(Lançamento dos Alvos)
    usando conceito de Ui Diegetic aplicando a animação "SCREEN SHAKE"  

Esse projeto inclui todos esses fundamentos: 

       Usei Random.Range
 
       Acessar a Position que será Randomizada para que os objetos apareçam em qualquer lugar.

       AddForce() onde a aplicação de força será aleatoria p/ q objetos voem ate alturas aleatoria.

       O giro ou Torque aplicados serão randomizados de modo que alguns objetos girem.

       Os objetos serão destruido atraves da entrada do input do mouse
       
       OnMouseEnter() para saber quando o mouse entra em uma área 

       OnMouseDown() para dizer quando o mouse foi precionado para baixo

       OnMouseUp() para dizer quando o mouse foi liberado

       OnDestroy() Detectar se o usuario clicou no objeto para nos o destruimos

       Canvas representando a exibição da tela

       exibir a pontuação;
       
       texto de game over;
	
       Sistema de particulas;
	
       botão restart, escrevendo um metodo chamado RestatGame() que vai recarregar a cena,
       
       atraves de um EventListener que será acionado ao clicar no botão;

