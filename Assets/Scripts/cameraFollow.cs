using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float _speed= 0.125f;
    public Vector3 offset;

    void LateUpdate(){
        //vektör toplamı
        transform.position = target.position + offset;

    }
}
