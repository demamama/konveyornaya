using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnCollisionStay(Collision collisioninfo)
    {
        if(collisioninfo.gameObject.TryGetComponent(out Tape tape))
        {                                                   
            transform.position += Vector3.forward * _speed * Time.deltaTime;  
        }
    }

       


}
