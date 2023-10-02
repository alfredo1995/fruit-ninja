This project includes all of these UI elements:

     UI includes any text, buttons, or display that the user can read or interact with

     We have the title screen, with menu buttons where the player can choose the difficulty.
     During the game, the player's Score will be tracked and displayed.
     At the end you will have a Game Over screen capable of restarting the game.
    
     Menu UI with difficulty options (easy, medium and hard);

     Easy setting causes objects to be launched slowly;
     Hard configuration causes objects to be launched quickly;
     When the button's EventListener is called, it will execute the SetDifficult method;
     The SetDifficult method will take the difficulty value and communicate it to the GameManager script,
     responsible for managing the scene.

     In the GameManager script, the StartGame method will take this difficulty value and
     used to change the spawRate(Target Launch)
     using Diegetic Ui concept applying "SCREEN SHAKE" animation

This project includes all these fundamentals:

        I used Random.Range
 
        Access the Position that will be Randomized so that the objects appear anywhere.

        AddForce() where the application of force will be random so that objects fly to random heights.

        The Spin or Torque applied will be randomized so that some objects rotate.

        Objects will be destroyed through mouse input
       
        OnMouseEnter() to know when the mouse enters an area

        OnMouseDown() to tell when the mouse has been pressed down

        OnMouseUp() to tell when the mouse has been released

        OnDestroy() Detect if the user clicked on the object so we can destroy it

        Canvas representing the screen display

        display the score;
       
        game over text;

        Particle system;

        restart button, writing a method called RestatGame() that will reload the scene,
       
        through an EventListener that will be triggered when clicking the button;
