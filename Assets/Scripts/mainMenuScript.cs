using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{   
    public static GameObject btnObj;
    public Button resumeUI = btnObj.GetComponent<Button>();
            

    public void Update() {
        if (PlayerPrefs.GetInt("Sayac") == 0)
        {
            resumeUI.interactable = false;
        }
    }
    
    public void newGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.DeleteKey("Sayac");
    }

    public void resume(){
        StartCoroutine(Resume_button());


    }

    public IEnumerator Resume_button(){
        
            AsyncOperation asyncLoad;
            if (PlayerPrefs.GetInt("Sayac") < 2)
            {   
                
                
                yield return new WaitForSeconds(0.1f);
                asyncLoad = SceneManager.LoadSceneAsync(1);
                while (!asyncLoad.isDone)
                {
                    yield return null;
                }  
                
            }
            else if (PlayerPrefs.GetInt("Sayac") >= 2 && PlayerPrefs.GetInt("Sayac") < 4)
            {
                yield return new WaitForSeconds(0.1f);
                asyncLoad = SceneManager.LoadSceneAsync(2);
                while (!asyncLoad.isDone)
                {
                    yield return null;
                }  
            }
            else if (PlayerPrefs.GetInt("Sayac") >= 4)
            {
                yield return new WaitForSeconds(0.1f);
                asyncLoad = SceneManager.LoadSceneAsync(3);
                while (!asyncLoad.isDone)
                {
                    yield return null;
                }  
            }
            
            
    }
}
