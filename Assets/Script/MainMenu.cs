using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string loadgame;


    public int dfltLives;


    private void Start(){

        PlayerPrefs.SetInt("CurrentLives",dfltLives);
    }
   
   public void PlayGame(){

SceneManager.LoadScene(loadgame);

   }

 public void Quitgame(){
  
Application.Quit();

      }





}
