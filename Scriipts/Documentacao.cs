//using static UnityEngine.UIElements.UxmlAttributeDescription;
//using System;
//using TMPro;
//using UnityEditor;
//using UnityEngine.SocialPlatforms.Impl;

//progrando um jogo para testar os reflexos do jogador, onde o objetivo é clicar e destruir objetos jogados aleatoriamente no ar antes que eles possam cair. testando o reflexo do jogador



//----------------------------------------  Mecânica de Jogabilidade ---------------------------------------- 


//Crie o projeto e alterne para a visualização 2D

//1. Abra o Unity Hub e crie um projeto "Prototype 5" vazio no diretório do Unity. 
//2. Extraia a pasta compactada(Prototype 5 Starter Files) e, em seguida, importe o .unitypackage para o seu projeto. 
//3. Abra a cena do Protótipo 5 e exclua a cena de exemplos em salvar
//4. Clique no ícone 2D na visualização Cena para colocar a visualização Cena em 2D.


//Crie alvos bons e ruins

//1. NaBiblioteca, arraste 3 objetos "bons" e 1 objeto "ruim" para a Cena, renomeie-os como "Bom 1", "Bom 2", "Bom 3" e "Ruim 1"
//2. Adicione os componentes Rigid BodyeBox Collider e, em seguida, certifique-se de que os Colliders rodeiam os objetos corretamente
//3. Crie uma nova pasta Scripts, um novo script "Target.cs" dentro dela, anexe-o aosobjetos Target
//4. Arraste todos os 4 destinos para apasta Prefabspara criar "pré-fabricados originais" e, em seguida, exclua-osda cena


//Jogue objetos aleatoriamente no ar

//1. EmTarget.cs, declare um novoalvo privado de RigidbodyRb; e inicializá-lo emStart()
//2.EmStart(), adicione uma força ascendentemultiplicada por umavelocidade aleatória
//3. Adicionar umtorque com valores xyz aleatórios
//4. Defina aposiçãocom umvalor X aleatório


//Substitua o código confuso por novos métodos

//1. Declare e inicialize novas variáveis flutuantes privadas para minSpeed, maxSpeed, maxTorque, xRange eySpawnPos;
//2.Crie uma nova função para Vector3 RandomForce() e chame-a em Start()
//3.Crie uma nova função para float RandomTorque() e chame-a em Start()
//4.Crie uma nova função para RandomSpawnPos(), faça com que ele retorne um novo Vector3e chame-o em Start() 


//Criar lista de objetos no Game Manager

//1. Crie um novo objeto vazio do "Game Manager", anexe um novo script .cs GameManagere abra-o 
//2. Declarar um novodestino público List<GameObject>; e, em seguida, no inspetor do Game Manager, altere o Tamanho da listapara 4 e atribua suaspré-fabricadas


//Crie uma co-rotina para gerar objetos

//1. Declarar e inicializar uma novavariável spawnRate flutuante privada
//2. Criar um novo método IEnumerator SpawnTarget ()
//3.Dentro do novo método,while (true),aguarde1 segundo, gere um índice aleatório e gere umdestino aleatório 
//4. Em Start(), use o método StartCoroutinepara começar a gerar objetos


//Destrua o alvo com clique e sensor do Mouse

//1. Em Target.cs, adicione um novo método parao vazio privado OnMouseDown() { }
//e, dentro desse método, destrua o gameObject
//2. Adicione um novo método para o vazio privado OnTriggerEnter(Collider other) e, dentro dessa função, destrua o gameObject


//---------------------------------------- Mantendo a Pontuação ---------------------------------------- 


//Adicionar texto Pontuação posicioná-lo na tela

//1. Na hierarquia, crie > interface do usuário > texto TextMeshPro e, se solicitado, clique no botão paraImportar TMP Essentials 
//2. Renomeie o novo objeto "Texto de pontuação" ediminuao zoom para ver atelano modo de exibição Cena
//3. Altere oponto de ancoragempara que ele seja ancorado a partir docanto superior esquerdo
//4. No inspetor, altere seu Pos X ePos Ypara que ele fique no canto superior esquerdo


//Edite as propriedades do Score Text

//1. Altere seu texto para "Pontuação:"
//2. Escolha umativo de fonte, estilo, tamanho e cor do vérticepara ter uma boa aparência com seu plano de fundo


//Inicialize o texto e a variável da pontuação

//1. Na parte superior doGameManager.cs, adicione "usando TMPro; "
//2. Declare um novoscoreText TextMeshProUGUI público e, em seguida, atribua essa variável no inspetor
//3. Crie uma nova variável de pontuação int privadae inicialize-a emStart()asscore = 0;
//4.Também emStart(), definascoreText.text = "Score: " + score;


//Criar um novo método UpdateScore

//1. Criar um novo método UpdateScore vazio privadoque exija umparâmetro int scoreToAdd
//2. Recortar e colarscoreText.text = "Score: " + score; no novo método e, em seguida, chameUpdateScore(0)emStart()
//3.Em UpdateScore(), incremente a pontuação adicionandoscore += scoreToAdd;
//4.Chame UpdateScore(5) na função spawnTarget()


//Adicione pontuação quando os alvos forem destruídos referenciando os scripts

//1. No GameManager.cs, torne o método UpdateScore público
//2. Em Target.cs, crie uma referência ao gameManager privado do GameManager //private GameManager gameManager;
//3. Inicialize o GameManager em Start()usando o método Find() //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
//4.Quando um destino é destruído, chame UpdateScore(5); e, em seguida, excluaa chamada de método de SpawnTarget()


//Atribua um valor de ponto a cada destino

//1. Em Target.cs, crie uma novavariável int pointValue pública
//2. Em cada um dosinspetores pré-fabricados do Target, defina o Valor do Pontopara o que eles valem, incluindo o valor negativo do alvo incorreto
//3. Adicione a nova variável aUpdateScore(pointValue);


//Adicione uma explosão de partículas

//1. Em Target.cs, adicione uma novavariável ParticleSystem explosionParticle pública
//2. Para cada um dos pré-fabricados de destino, atribua umapartícula pré-fabricadada Biblioteca docurso > Partículasàvariável Partícula de explosão
//3. Na função OnMouseDown(),instancieuma nova explosão pré-fabricada


//---------------------------------------- Tela de Game Over ---------------------------------------- 

//Criar um objeto de texto Game Over

//1. Clique com o botão direito do mouse noCanvas, crie uma novainterface do usuário >TextMeshPro - Objeto de textoe renomeie-o como "Game Over Text"
//2. No inspetor, edite seutexto, Pos X, Pos Y, Ativo de fonte, Tamanho, Estilo, Cor ealinhamento
//3. Defina a configuração "Wrapping" como "Disabled"


//Faça com que o texto do GameOver apareça

//1. No GameManager.cs, crie um novoTextMeshProUGUI gameOverText público; e atribuir o objeto Game Overa ele no inspetor
//2. Desmarquea caixa de seleção Ativo paradesativaro texto Game Over por padrão
//3. Em Iniciar(), ative o texto Game Over


//Criar função GameOver

//1. Crie uma nova função GameOver()public void emova o código que ativa o texto do jogo sobre ele
//2. Em Target.cs, chamegameManager.GameOver()se um alvo colidir com osensor
//3. Adicione uma nova tag "Ruim" ao objeto Ruim, adicione uma condição que só acionará o game over senão for um objeto ruim


//Pare de desovar e marque no GameOver

//1. Criar um novobool público isGameActive;
//2.Como aprimeira linhaemStart(), definaisGameActive = true; e emGameOver(), definaisGameActive = false;
//3.Para evitar a desova, na co-rotina SpawnTarget(), altere while (true) towhile(isGameActive)
//4.Para evitar pontuação, em Target.cs, na função OnMouseDown(), adicione a condiçãoif (gameManager.isGameActive) {


//    Adicione um botão Reiniciar

//1.Clique com o botão direito do mouse noCanvaseCriar > interface do usuário > BotãoNota: Você também pode usarButton - TextMeshPropara obter mais controle sobre o texto do botão.
//2. Renomeie o botão "Botão Iniciar"
//3. Reative temporariamente o texto do Game Over para reposicionar o Botão Reiniciar bem com o texto e, em seguida, desative-o novamente
//4. Selecione o objeto filho Texto e, em seguida, edite seu Texto para dizer "Reiniciar", sua Fonte, Estilo e Tamanho

//Faça o botão de reiniciar funcionar

//1. No GameManager.cs, adicioneusando UnityEngine.SceneManagement;
//2.Criar uma nova função pública void RestartGame()que recarrega a cena atual
//3. No inspetor do botão, clique em + para adicionar um novoevento On Click, arraste-o no objeto Game Managere selecione afunção GameManager.RestartGame


//Mostrar botão de reinicialização no game over

//1. Na parte superior do GameManager.cs adicionarusando UnityEngine.UI;
//2.Declare um novoButton restartButton público; e atribua obotão Reiniciara ele no inspetor
//3. Desmarquea caixa de seleção "Ativo" dobotão Reiniciarno inspetor
//4. Na função GameOver, ative obotão Reiniciar


//---------------------------------------- Escolher Dificuldades do Jogo ---------------------------------------- 


//Criar texto do título e botões de menu

//1. Duplique seu texto do Game Overpara criar seu Texto de Título, editando seu nome, texto e todos os seus atributos
//2. Duplique seu botão Reiniciare edite seus atributos para criar um botão "Botão Fácil"
//3. Edite e duplique o novobotão Fácil para criar um "Botão Médio" e um "Botão Rígido"


//Adicionar um script DifficultyButton

//1. Para todos os 3 novos botões, no componente Botão, na seção Ao clicar (), clique no botão de subtração(-) para remover a funcionalidade RestartGame
//2. Crie um novo script DifficultyButton.cse anexe-o atodos os 3 botões
//3. Adicionarusando UnityEngine.UIàs suas importações
//4. Criar um novo botão de botão privado; e inicialize-a em Start() 


//Call SetDifficulty no botão clique

//1. Crie uma nova função SetDifficulty voide, dentro dela, Debug.Log(gameObject.name + " foi clicado");
//2.Adicione oouvinte de botãopara chamar afunção SetDifficulty


//Faça seus botões iniciarem o jogo

//1. No GameManager.cs, crie uma nova função StartGame()void pública e mova tudo deStart()para ela
//2. Em DifficultyButton.cs, crie um novogameManager privado do GameManager; e inicializá-lo em Start() 
//3.Na função SetDifficulty(), chamegameManager.StartGame();


//Desative a tela de título no StartGame

//1. Clique com o botão direito do mouse no Canvas e crie > objeto vazio, renomeie-o "Title Screen" e arraste os3 botõeseo títulopara ele
//2. No GameManager.cs, crie um novotitleScreen GameObject público; e atribuí-lo no inspetor
//3. Em StartGame(), desative o objeto da tela de título


//Use um parâmetro para alterar a dificuldade

//1. Em DifficultyButton.cs, crie uma nova variável de dificuldade int pública e, em seguida, no Inspetor, atribua a dificuldade Easy como 1, Medium como 2 eHardas 3
//2. Adicionar um parâmetro de dificuldade intà função StartGame()
//3.Em StartGame(), definaspawnRate /= dificuldade;
//4.Corrija o erro em DifficultyButton.cs passando o parâmetro de dificuldade paraStartGame(difficulty)