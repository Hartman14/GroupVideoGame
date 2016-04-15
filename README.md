# GroupVideoGame
CSCI 313 Group Video Game Scripting Code Repository

{

 use p key to pause and unpause the game.
 
 the pause menu is a prefab, and currently would need to be added to each level. 
 
  -save is not currently implemented.
  
  -quit game does work, it brings the player back to the main menu, 
  
    -the main menu quit also works but only if the game is built outside of the editor.
    
  main menu
  
    -new game will start the firstroom scene
    
    -load game is partially working but as save is not yet implmented, I have it setup to pick scenes to load. mainly
      for testing purposes.
      
          1. load game is populated by what is in an array in the menuscript, 
          2. although when it changes the scen it uses the location of the dropdown item, and loads the scene number,
                a. however the scene number is tied to what scenes are setup in the build settings, 
                    and their order. (right side of scenes in build menu)
                    
    -options menu -no options are currently tied to variables just yet. as not entirely sure what will be needed.
            thoughts though.   
            
            1. Speed of controls
            
            2. invert y axis. I will need this as my computer is inverted. can be defaulted for use on windows.
            
            3. not sure what else
            
    -quit does work,    but only if the game is built outside of the editor.
    
    
    potential issues I see, The way the script is set up for the pause menu it does check for a 'p' key press in the update
        method, this may be a burden on the computer and slow it down. OR not 
        
    } dan
