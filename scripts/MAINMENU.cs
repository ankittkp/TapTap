using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MAINMENU : MonoBehaviour
{
  public void PlayGame()
  {
      SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void QuitGame()
  {
      Debug.Log("QUIT");
      Application.Quit();

  }

}
