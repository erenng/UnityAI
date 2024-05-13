using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olusacakObje : MonoBehaviour
{
    private int carpmaSayisi = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ajan"))
        {
            if (carpmaSayisi != 0)
            {
                carpmaSayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
