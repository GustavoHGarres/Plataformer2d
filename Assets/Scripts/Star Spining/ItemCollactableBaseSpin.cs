using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableBaseSpin : MonoBehaviour
{
    public string comparetag = "Player1";
        
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

    }
  
}