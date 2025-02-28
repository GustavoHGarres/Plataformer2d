using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumCoinsSpin : MonoBehaviour
{
   public static SumCoinsSpin sumCoin2;
   public Text coinsText;
   public int coins2;     //Somas as moedas junto com o script SumCoins
    
     private void Awake() 
     {
        if (sumCoin2 == null)
        {
            sumCoin2 = this;
        }
        else if(sumCoin2 != this)
        {
            Destroy(gameObject);
        }
     }
   }
