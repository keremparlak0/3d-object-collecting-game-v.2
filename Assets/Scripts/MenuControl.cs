using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public static bool oyunDurduMu = false;
    public GameObject pauseMenuUI;
    public GameObject oyuncu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(oyunDurduMu){
                devamEt();
            }else{
                durdur();
            }
        }
        //Eğer oyuncu platformdan düşerse oyun yenilenecek.
        if(oyuncu.transform.position.y<-15){
            yenidenBaslat();
        }

    }

    //Devam Et tuşuna basıldığında çağırılacak fonksiyon
    public void devamEt(){
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        oyunDurduMu = false;
    }

    void durdur(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        oyunDurduMu = true;
    }
    
    //Yeniden Başlat tuşuna basıldığında çağırılacak fonksiyon
    public void yenidenBaslat(){
        Debug.Log("Restart");
        StartCoroutine(Restart());
        PlayerPrefs.DeleteKey("Sayac");
        //Restart Yaptığımızda top havada kalıyor ve escape tusuna basmamız gerekiyordu
        //Bu sorun yaşanmasın diye devamEt() fonksiyonunu çağırdık
        devamEt();
    }

    public void anaMenu(){
        StartCoroutine(GoMainMenu());
    }


    //Sahneler Arası Asenkron Geçiş
    public void nxtLvl(){
        StartCoroutine(GoNextLevel());
    }

    public IEnumerator GoNextLevel(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return new WaitForSeconds(0.1f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public IEnumerator GoMainMenu(){

        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        oyunDurduMu = false;
        
        yield return new WaitForSeconds(0.1f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        
    }
    public IEnumerator Restart(){
        PlayerPrefs.DeleteKey("Sayac");
        yield return new WaitForSeconds(0.1f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        
    }

}
