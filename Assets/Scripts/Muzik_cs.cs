using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzik_cs : MonoBehaviour
{
    private static Muzik_cs  muzikobjesi = null;
  
    void Awake()
    {
        if( muzikobjesi ==null )
        {
            muzikobjesi =this ;
            DontDestroyOnLoad( this ); // muzik sahne gecislerinde kapanmaması için
        }
        else if( this !=muzikobjesi ) // diger objeler kapansın
        {
            Destroy( gameObject );
        }
    }
}

