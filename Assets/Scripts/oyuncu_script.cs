using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyuncu_script : MonoBehaviour
{
    Rigidbody yercekimi;
    AudioSource audiosource;
    Animator animator;
    
    public float hiz = 3.0f;
    public int sayac = 0;
    
    

    public Text kutuSayisiGoster;
    void Start()
    {
        yercekimi = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

        if (PlayerPrefs.HasKey("Sayac"))
        {
            sayac = PlayerPrefs.GetInt("Sayac");
            Debug.Log(sayac.ToString());
            Debug.Log("var");
            kutuSayisiGoster.text = "Toplanan Kutu = " + PlayerPrefs.GetInt("Sayac");
        }
        else
        {
            PlayerPrefs.SetInt("Sayac", 0);
            
        }

        
    }

    void Update()
    {
         if (Input.GetKey("w")){
            animator.SetBool("isWalking",true);    
        }else if (Input.GetKey("s")){
            animator.SetBool("isWalking",true);
        }else if (Input.GetKey("a")){
            animator.SetBool("isWalking",true);
        }else if (Input.GetKey("d")){
            animator.SetBool("isWalking",true);
        }
        else {
            animator.SetBool("isWalking",false);
        }
        float yatay_hareket = Input.GetAxis("Horizontal");
        float dikey_hareket = Input.GetAxis("Vertical");

        Vector3 vc = new Vector3(yatay_hareket,0,dikey_hareket);

        yercekimi.AddForce(vc*hiz);

        
        
    }
    void OnCollisionEnter(Collision carpılan)
     
    {
        if (carpılan.gameObject.name == "Kutucuk(Clone)")
        {
            Destroy(carpılan.gameObject);
            sayac++;
            kutuSayisiGoster.text = "Toplanan Kutu = " + sayac;
            PlayerPrefs.SetInt("Sayac", sayac);
            //Debug.Log(sayac + " kutu toplandı");

            //sayac 2ye geldiğinde yeni sahneye otomatik geçiş yapılacaktır
            //ve yazılan if bloğuyla sayaç levele göre kademeli olarak artacaktır
            if (sayac >= (SceneManager.GetActiveScene().buildIndex)*2)
            {
                GameObject gameObject = new GameObject("MenuControl");
                gameObject.AddComponent<MenuControl>().nxtLvl();
                

            }

        }
        else if(carpılan.gameObject.name == "yasakliKutucuk(Clone)"){
            Destroy(carpılan.gameObject);
            sayac--;
            kutuSayisiGoster.text = "Toplanan Kutu = " + sayac;
            // Debug.Log(sayac + " yasakli kutu toplandı");
            audiosource.Play();
            PlayerPrefs.SetInt("Sayac", sayac);

            //puan 0'ın altına düşerse eğer oyun yeniden başlar.
            if(sayac < 0){
                MenuControl obj = new MenuControl();
                obj.yenidenBaslat();

            }


            
        }
    }
}
