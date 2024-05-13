using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject hedef;
    private int carpmaSayisi;
    public string ajanTuru;
    private float darbeGucu;
    public GameObject gameKontrol;
    

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(hedef.transform.position);
        

        switch(ajanTuru)
        {
            case "mavi":
                carpmaSayisi = 1;
                darbeGucu = .1f;
                break;
            case "yesil":
                carpmaSayisi = 1;
                darbeGucu = .05f;
                break;
            case "gri":
                carpmaSayisi = 1;
                darbeGucu = .02f;
                break;
        }
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
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

        if (other.gameObject.CompareTag("AnaHedef"))
        {
            gameKontrol.GetComponent<GameKontrol>().canDusur(darbeGucu);
            
                Destroy(gameObject);
            
        }

    }
}
