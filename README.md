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


<br> 
<br> 

--------------------------------------------------  Mecânica de Jogabilidade --------------------------------------------------


<br> 
<br> 

Crie o projeto e alterne para a visualização 2D

    1. Abra o Unity Hub e crie um projeto "Prototype 5" vazio no diretório do Unity. 
    2. Extraia a pasta compactada(Prototype 5 Starter Files) e, em seguida, importe o .unitypackage para o seu projeto. 
    3. Abra a cena do Protótipo 5 e exclua a cena de exemplos em salvar
    4. Clique no ícone 2D na visualização Cena para colocar a visualização Cena em 2D.


Crie alvos bons e ruins

    1. NaBiblioteca, arraste 3 objetos "bons" e 1 objeto "ruim" para a Cena, renomeie-os como "Bom 1", "Bom 2", "Bom 3" e "Ruim 1"
    2. Adicione os componentes Rigidbody e Box Collider, em seguida, certifique-se de que os Colliders rodeiam os objetos corretamente
    3. Crie uma nova pasta Scripts, um novo script "Target.cs" dentro dela, anexe-o aos objetos Target
    4. Arraste todos os 4 destinos para apasta Prefabspara criar "pré-fabricados originais" e, em seguida, exclua-osda cena


Jogue objetos aleatoriamente no ar

    1. EmTarget.cs, declare um novo alvo privado de RigidbodyRb; e inicializá-lo emStart()
    2. EmStart(), adicione uma força ascendentemultiplicada por umavelocidade aleatória
    3. Adicionar umtorque com valores xyz aleatórios
    4. Defina aposiçãocom umvalor X aleatório


Substitua o código confuso por novos métodos

    1. Declare e inicialize novas variáveis flutuantes privadas para minSpeed, maxSpeed, maxTorque, xRange eySpawnPos;
    2. Crie uma nova função para Vector3 RandomForce() e chame-a em Start()
    3. Crie uma nova função para float RandomTorque() e chame-a em Start()
    4. Crie uma nova função para RandomSpawnPos(), faça com que ele retorne um novo Vector3e chame-o em Start() 


Criar lista de objetos no Game Manager

    1. Crie um novo objeto vazio do "Game Manager", anexe um novo script .cs GameManagere abra-o 
    2. Declarar um novo destino público List<GameObject>; e, em seguida, no inspetor do Game Manager,
       altere o Tamanho da listapara 4 e atribua suaspré-fabricadas


Crie uma co-rotina para gerar objetos

    1. Declarar e inicializar uma nova variável spawnRate flutuante privada
    2. Criar um novo método IEnumerator SpawnTarget ()
    3. Dentro do novo método, while (true),aguarde1 segundo, gere um índice aleatório e gere umdestino aleatório 
    4. Em Start(), use o método StartCoroutinepara começar a gerar objetos


Destrua o alvo com clique e sensor do Mouse

    1. Em Target.cs, adicione um novo método parao vazio privado OnMouseDown() { } e, dentro desse método, destrua o gameObject
    2. Adicione um novo método para o vazio privado OnTriggerEnter(Collider other) e, dentro dessa função, destrua o gameObject

<br> 
<br> 

--------------------------------------------------  Mantendo a Pontuação --------------------------------------------------  

<br> 
<br> 

Adicionar texto Pontuação posicioná-lo na tela

    1. Na hierarquia, crie > interface do usuário > texto TextMeshPro e, se solicitado, clique no botão para Importar TMP Essentials 
    2. Renomeie o novo objeto "Texto de pontuação" ediminuao zoom para ver atelano modo de exibição Cena
    3. Altere oponto de ancoragempara que ele seja ancorado a partir docanto superior esquerdo
    4. No inspetor, altere seu Pos X ePos Ypara que ele fique no canto superior esquerdo


Edite as propriedades do Score Text

    1. Altere seu texto para "Pontuação:"
    2. Escolha umativo de fonte, estilo, tamanho e cor do vérticepara ter uma boa aparência com seu plano de fundo


Inicialize o texto e a variável da pontuação

    1. Na parte superior doGameManager.cs, adicione "usando TMPro; "
    2. Declare um novoscoreText TextMeshProUGUI público e, em seguida, atribua essa variável no inspetor
    3. Crie uma nova variável de pontuação int privadae inicialize-a emStart()asscore = 0;
    4. Também emStart(), definascoreText.text = "Score: " + score;


Criar um novo método UpdateScore

    1. Criar um novo método UpdateScore vazio privadoque exija umparâmetro int scoreToAdd
    2. Recortar e colarscoreText.text = "Score: " + score; no novo método e, em seguida, chameUpdateScore(0)emStart()
    3. Em UpdateScore(), incremente a pontuação adicionandoscore += scoreToAdd;
    4. Chame UpdateScore(5) na função spawnTarget()


Adicione pontuação quando os alvos forem destruídos referenciando os scripts

    1. No GameManager.cs, torne o método UpdateScore público
    2. Em Target.cs, crie uma referência ao gameManager privado do GameManager //private GameManager gameManager;
    3. Inicialize o GameManager em Start()usando o método Find() //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    4. Quando um destino é destruído, chame UpdateScore(5); e, em seguida, excluaa chamada de método de SpawnTarget()


Atribua um valor de ponto a cada destino

    1. Em Target.cs, crie uma novavariável int pointValue pública
    2. Em cada um dosinspetores pré-fabricados do Target, defina o Valor do Pontopara o que eles valem, incluindo o valor negativo do alvo incorreto
    3. Adicione a nova variável aUpdateScore(pointValue);


Adicione uma explosão de partículas

    1. Em Target.cs, adicione uma novavariável ParticleSystem explosionParticle pública
    2. Para cada um dos pré-fabricados de destino, atribua umapartícula pré-fabricadada Biblioteca docurso > Partículasàvariável Partícula de explosão
    3. Na função OnMouseDown(),instancieuma nova explosão pré-fabricada

<br>
<br> 

--------------------------------------------------  Tela de Game Over --------------------------------------------------  

<br> 
<br> 

Criar um objeto de texto Game Over

    1. Clique com o botão direito do mouse noCanvas, crie uma novainterface do usuário >TextMeshPro - Objeto de textoe renomeie-o como "Game Over Text"
    2. No inspetor, edite seutexto, Pos X, Pos Y, Ativo de fonte, Tamanho, Estilo, Cor ealinhamento
    3. Defina a configuração "Wrapping" como "Disabled"


Faça com que o texto do GameOver apareça

    1. No GameManager.cs, crie um novoTextMeshProUGUI gameOverText público; e atribuir o objeto Game Overa ele no inspetor
    2. Desmarquea caixa de seleção Ativo paradesativaro texto Game Over por padrão
    3. Em Iniciar(), ative o texto Game Over


Criar função GameOver

    1. Crie uma nova função GameOver()public void emova o código que ativa o texto do jogo sobre ele
    2. Em Target.cs, chamegameManager.GameOver()se um alvo colidir com osensor
    3. Adicione uma nova tag "Ruim" ao objeto Ruim, adicione uma condição que só acionará o game over senão for um objeto ruim


Pare de desovar e marque no GameOver

    1. Criar um novobool público isGameActive;
    2. Como aprimeira linhaemStart(), definaisGameActive = true; e emGameOver(), definaisGameActive = false;
    3. Para evitar a desova, na co-rotina SpawnTarget(), altere while (true) towhile(isGameActive)
    4. Para evitar pontuação, em Target.cs, na função OnMouseDown(), adicione a condiçãoif (gameManager.isGameActive) {


    Adicione um botão Reiniciar

    1. Clique com o botão direito do mouse noCanvaseCriar > interface do usuário > BotãoNota: Você também pode 
       usarButton - TextMeshPropara obter mais controle sobre o texto do botão.
    2. Renomeie o botão "Botão Iniciar"
    3. Reative temporariamente o texto do Game Over para reposicionar o Botão Reiniciar bem com o texto e, em seguida, desative-o novamente
    4. Selecione o objeto filho Texto e, em seguida, edite seu Texto para dizer "Reiniciar", sua Fonte, Estilo e Tamanho

Faça o botão de reiniciar funcionar

    1. No GameManager.cs, adicioneusando UnityEngine.SceneManagement;
    2. Criar uma nova função pública void RestartGame()que recarrega a cena atual
    3. No inspetor do botão, clique em + para adicionar um novoevento On Click, arraste-o no objeto Game Managere selecione afunção GameManager.RestartGame


Mostrar botão de reinicialização no game over

    1. Na parte superior do GameManager.cs adicionarusando UnityEngine.UI;
    2. Declare um novoButton restartButton público; e atribua obotão Reiniciara ele no inspetor
    3. Desmarquea caixa de seleção "Ativo" dobotão Reiniciarno inspetor
    4. Na função GameOver, ative obotão Reiniciar

<br> 
<br> 

--------------------------------------------------  Escolher Dificuldades do Jogo --------------------------------------------------  

<br> 
<br> 

Criar texto do título e botões de menu

    1. Duplique seu texto do Game Overpara criar seu Texto de Título, editando seu nome, texto e todos os seus atributos
    2. Duplique seu botão Reiniciare edite seus atributos para criar um botão "Botão Fácil"
    3. Edite e duplique o novobotão Fácil para criar um "Botão Médio" e um "Botão Rígido"


Adicionar um script DifficultyButton

    1. Para todos os 3 novos botões, no componente Botão, na seção Ao clicar (), clique no botão de subtração(-) para remover a funcionalidade RestartGame
    2. Crie um novo script DifficultyButton.cse anexe-o atodos os 3 botões
    3. Adicionarusando UnityEngine.UIàs suas importações
    4. Criar um novo botão de botão privado; e inicialize-a em Start() 


Call SetDifficulty no botão clique

    1. Crie uma nova função SetDifficulty voide, dentro dela, Debug.Log(gameObject.name + " foi clicado");
    2.Adicione oouvinte de botãopara chamar afunção SetDifficulty


Faça seus botões iniciarem o jogo

    1. No GameManager.cs, crie uma nova função StartGame()void pública e mova tudo deStart()para ela
    2. Em DifficultyButton.cs, crie um novogameManager privado do GameManager; e inicializá-lo em Start() 
    3. Na função SetDifficulty(), chamegameManager.StartGame();


Desative a tela de título no StartGame

    1. Clique com o botão direito do mouse no Canvas e crie > objeto vazio, renomeie-o "Title Screen" e arraste os3 botõeseo títulopara ele
    2. No GameManager.cs, crie um novotitleScreen GameObject público; e atribuí-lo no inspetor
    3. Em StartGame(), desative o objeto da tela de título


Use um parâmetro para alterar a dificuldade

    1. Em DifficultyButton.cs, crie uma nova variável de dificuldade int pública e, em seguida, no Inspetor,
       atribua a dificuldade Easy como 1, Medium como 2 eHardas 3
    2. Adicionar um parâmetro de dificuldade intà função StartGame()
    3. Em StartGame(), definaspawnRate /= dificuldade;
    4. Corrija o erro em DifficultyButton.cs passando o parâmetro de dificuldade paraStartGame(difficulty)



<br> 
<br> 

--------------------------------------------------  Salvando pontuação com PlayerPrefs -------------------------------------------------- 

<br> 
<br> 

0° PlayerPrefs

	PlayerPrefs é uma classe que armazena as preferências do jogador entre as sessões de jogo. 
	Ele pode armazenar valores de string, float e inteiro no registro da plataforma do usuário.

1° Criar um Canva de Text para Pontuacao Maxima

       Create > UI > TEXT MESH PRO

2° Duas variaves, 1 para armazena a contagem maxima e a outra para referenciar o canva text   


       private int scoreMax;

       public TextMeshProUGUI scoreMaxText;

3° metodo start: atribuir a variavel de contagem da pontuacao maxima o valor recebido na variavel score
        
	//criar um condicao para que mostre a pontuacao maxima se o score for maior que o valor na scoreMax

        scoreMax = PlayerPrefs.GetInt("score");
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("scoreMax"))
        {
               PlayerPrefs.SetInt("scoreMax", scoreMax);
        }

4° metodo UpdateScore passar a variavel refenciando o carva text(scoreMaxText)

        //atribuindo nela a string concatenado com a classe PlayPrefabs recebendo o valor q esta na variavel scoreMax   
        //chamar a class PlayerPrefs, setando o valor que esta no score

        scoreMaxText.text = "ScoreMax : " + PlayerPrefs.GetInt("scoreMax");
	PlayerPrefs.SetInt("score", score);


<br> <br> 

--------------------------------------------------Aplicando Conceito UI DIEGETIC -------------------------------------------------- 


Diegético

	As interfaces de usuário diegéticas existem no mundo do jogo em vez de estarem em cima dele e / ou completamente removidas da ficção do jogo.
	Interfaces de usuário diegéticas dentro do mundo do jogo podem ser vistas e ouvidas por outros jogadores. Alguns exemplos de 

        interface do usuário diegética incluem as telas em computadores, relógios de tique-taque, munição restante e contagens regressivas. 
	
Não-diegético

	Interfaces não-diegéticas são aquelas que são renderizadas fora do mundo do jogo e são visíveis apenas para o jogador. 
	Eles são suas interfaces de usuário de jogo típicas que se sobrepõem ao topo do jogo. Eles são completamente removidos da ficção do jogo. 
	Alguns usos comuns de interfaces de usuário não diegéticas podem representar a saúde e a mana por meio de uma barra colorida.
	
Espacial

	Os elementos espaciais da interface do usuário são apresentados fisicamente no espaço do jogo. 
	Esses tipos de interfaces de usuário podem ou não ser visíveis para os outros jogadores dentro do espaço do jogo. 
	Isso é algo que é particularmente apresentado em experiênciasde Realidade Virtual (VR). 
	As interfaces de usuário espaciais são eficazes quando você deseja guiar os jogadores através de um nível ou indicar pontos de interesse.

Meta

	Meta UIs podem existir no mundo do jogo, mas não são necessariamente visualizadas como seriam como Spatial UIs.
	Isso significa que eles podem não ser representados dentro do Espaço 3D. 
	Na maioria dos casos, as Meta UIs representam um efeito de várias ações, como ser baleado ou exigir mais oxigênio. 
	Quando o jogador está em uma área que não é adequada para eles, a visão através da máscara começa a ficar nebulosa. 
	Quando eles são baleados ou se envolvem em combate, sua máscara também recebe dano. 

<br>
<br> 

-------------------------------------------------- Alterando o texto Score por uma Imagem -------------------------------------------------- 


1° Alterar o texto Score por uma imagem

	create > ui imagem > apague o texto Score e posicione a imagem no lugar

2° Importe um imagem e defina a propriedade dela como > Texture Type > sprite (2D and UI)

	selecione o carva ui imagem > souce Image > arraste a textura da imagem importada
	
	
<br>
<br> 	
	
-------------------------------------------------- Screen Shake Animation ------------------------------------------------- 


1° Fazer com que a tela trema ao clicar na bomba "screen shake"

	Adicionar um componente animator na camera e em seguida > windows > animation > abrir

2° Windowns > Animation > Create new clip > dar o nome ao arquivo e salva (cameraAnimationIdle)

	Clicar no botao vermelho(enable/display keyframe recording modo) em seguida
        na posição da camera altera x = 1.  Depois volte o x para 0

3° Create new clip > dar o nome ao arquivo e salva (CameraAnimationScreeenShake)

	Clicar no botao vermelho(enable/display keyframe recording modo) em seguida
        na posição da camera altera x = -0.1 Depois clique em um frame para frente e volte para 0
        clique no frame seguinte e altera x = 0.1 Depois clique em um frame para frente e volte para 0
	
4° Windowns > Animation > Animator (fazer a transição da animação)

	click na cameraAnimationIdle > Make Transition > Arrasta a seta ate CameraAnimationScreeenShake
	click em Parameters > Trigger > nomei-e para shake 
	click na seta da transição entre cameraAnimationIdle e CameraAnimationScreeenShake > 
	click em "+" p/ adicionar o shake como condição> 0 em transition duration e desmaque a caixa Has Exit Time
	
5°  click na CameraAnimationScreeenShake > Make Transition > Arrasta a seta ate cameraAnimationIdle

	click na seta da transição entre cameraAnimationIdle e CameraAnimationScreeenShake >
	zera o tempo transition duration e coloque 1 em Exit Time

6° create new script "cameraAnimation" anexa na camera


    public class CameraAnitation : MonoBehaviour
    {
    public Animator camAnimator;

    public void Start()
    {
        camAnimator = gameObject.GetComponent<Animator>();
    }
    public void ScreenShake()
    {
        camAnimator.SetTrigger("Shake");
    }
    }

7° acessar o script Tagert responsavel por destruir a bomba e faça a referencia

	public CameraAnitation camAnimator;

	void Start()
	{
	    camAnimator = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraAnitation>();
	}

	private void OnMouseDown()
	{
	    if (gameManager.isGameActive)
	    {
		if (gameObject.CompareTag("Bad"))
		{
		    camAnimator.ScreenShake();
		}

		Destroy(gameObject);
	    }
	}


<br>
<br>

-------------------------------------------------- Adicionar Audio Sound Effects ------------------------------------------------- 

1) Selecione a Main Camera para adicionar som ambiente

	
	   Adicionar o componente > Audio Source 
	   Selecione um audio e arraste para a referencia desse componente > audio clip
	
2) Selecione o obejto com script target (frutas ou player) para som de efeito

	   adicione o componente > Audio Source
	
	   Private AudioSource playerAudio;
	   public AudioClip clickSound;
	   public AudioClip bombSound;

3) No metodo Start

	   PlayerAudio.GetComponent<AudioSource>();

	
4) No metodo onde está destruindo os objetos 

	
	   private void OnMouseDown()
	   {
		if (gameManager.isGameActive)
		{
		  if (gameObject.CompareTag("Bad"))
		   {
			camAnimation.ScreenShake();
			playerAudio.PlayOneShot(bombSound, 1.0f);

		   }

		     Destroy(gameObject);
		     Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
		     gameManager.UpdateScore(pointValue);
		     playerAudio.PlayOneShot(clickSound, 1.0f);



<br>
<br>

-------------------------------------------------- Adicionar Feedback sobre Ganho/Perda de itens ------------------------------------------------- 


1) 

       Criar um gameobjeto vazio contendo um componente Text Mesh Pro, organizado dentro da hierarquia do Carvas 
	

2) 

       Criar uma variável referenciando o gameobjeto FloatingText contendo o componente Text Mesh Pro. 
    
3) 

       Usado SerializeField para manipular a posição do Text Mesh Pro no editor, mas mantendo a class inacessível.  

4) 

       acessar a classe responsavel por instanciar o valor da massa do objeto. 

5) 

       referenciar  a variável floatingText(gameObject) e ativando sua visibilidade na cena 


6) 

       referenciando a variável floatingText(gameObject), acessando seu componente Text e atribuindo o valor da massa do objeto recebido 
       como parâmetro (Convertendo o valor inteiro recebido p/ string) 

7)

      Referenciando o Text (TMP) do gameobjeto vazio(FloatingText) no campo do inspetor da UI, correspondente ao 
      script WeightCounter.cs no seu campo Floating Text.

8) Valor da massa do objeto coletado sendo exibido na tela e o Posicionamento do texto podendo ser alterado no Inspetor. 

	
            [SerializeField]
            private TextMeshProUGUI floatingText;
	
	
	    public void AdicionarMassaExemplo(float mass)
	    {
		floatingText.gameObject.SetActive(true);
		sliderTextMP.value += mass;
		floatingText.text = mass.ToString();

		StartCoroutine(FloatingTextPopup());
	    }

	    IEnumerator FloatingTextPopup()
	    {
		yield return new WaitForSeconds(0.5f);
		floatingText.gameObject.SetActive(false);
		floatingText.text = accumulatedWeight.ToString();

	    }

	    public void TrashClean()
	    {
		weight = 0;
		sliderTextMP.value = 0;

		floatingText.gameObject.SetActive(true);
		StartCoroutine(FloatingTextPopup());
	    }

