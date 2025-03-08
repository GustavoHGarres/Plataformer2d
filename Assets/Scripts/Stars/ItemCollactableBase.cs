using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItemCollactableBase : MonoBehaviour
{
    public string comparetag = "Player";
    public ParticleSystem particleSystem;

    public void Awake()
    {
        if (particleSystem != null) particleSystem.transform.SetParent(null);
    }
        
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag(comparetag))
       {
         Collect();
       }
    }

    protected virtual void Collect()
    {
        gameObject.SetActive(false);
        OnCollect();
    }  

    protected virtual void OnCollect()
    {
        if(particleSystem != null) particleSystem.Play();
    }
  
}

