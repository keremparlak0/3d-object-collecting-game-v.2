using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class kutucuk_script : MonoBehaviour
{
    public GameObject kutucuk;
    public GameObject yasakliKutucuk;
    
    void Start()
    {
        InvokeRepeating("kutucuk_olustur",2,5);
        InvokeRepeating("yasakli_kutucuk_olustur",2,5);
    }
    Vector3 pozisyon_sec()
    {
        float x = Random.Range(-100,100);
        float y = 0.5f;
        float z = Random.Range(-100,100);

        Vector3 yenikutu = new Vector3(x,y,z);
        return yenikutu;
    }
    void kutucuk_olustur()
    {
        Instantiate(kutucuk, pozisyon_sec(),Quaternion.identity);

    }

    //kutucuğa çarptığımızda konsola yazdırıyor
    void OnCollisionEnter(Collision carpan) {
        if(carpan.gameObject.name == "Oyuncu"){
            Debug.Log (carpan.gameObject.name + " carpti");
            
        }
        
    }

    // Yasaklı kutucuk kodları
    void yasakli_kutucuk_olustur()
    {
        Instantiate(yasakliKutucuk, pozisyon_sec(),Quaternion.identity);

    }
    
}
