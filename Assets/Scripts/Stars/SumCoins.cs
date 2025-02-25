using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SumCoins : MonoBehaviour
{
   public static SumCoins sumCoin;
   public Text coinsText;
   public int coins;     //Somas as moedas junto com o script SumCoins
    
     private void Awake() 
     {
        if (sumCoin == null)
        {
            sumCoin = this;
        }
        else if(sumCoin != this)
        {
            Destroy(gameObject);
        }
     }
   }


