using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour 
{

   public GameObject menuFirst, optionsFirst, instructionsFirst;

   public void PlayGame () 
   {
      SceneManager.LoadScene (1);
   }
   
   public void QuitGame ()
   {
      Debug.Log ("QUIT!");
      Application.Quit();
   }

   public void OptionsNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(optionsFirst);
   }

   public void InstructionsNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(instructionsFirst);
   }
   
   public void MenuNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(menuFirst);
   }
  
}