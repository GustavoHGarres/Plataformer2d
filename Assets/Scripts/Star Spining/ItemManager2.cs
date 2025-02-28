using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager2 : MonoBehaviour
{
    public static ItemManager2 Instance2;
    private SumCoinsSpin CollectCoins2;    // Somatoria de moedas
    //public int coins; // Passando para linha abaixo como ScripttableObject, tira o int e acrescenta o SOInt
    public SOIntSpin coins2;

    private void Awake()
    {
        if (Instance2 == null)
            Instance2 = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        CollectCoins2 = SumCoinsSpin.sumCoin2;
        CollectCoins2.coins2 = 0;
        Reset();
        
    }

    private void Reset()
    {
        //coins = 0; // Passando para a linha abaixo como ScriptableObject, onde tem coins, passa para coins.value
        coins2.valueSpin = 0;
    }
    
    // Soma as moedas na UI texto
    public void AddCoins(int amount = 1)
    {
        CollectCoins2.coins2 += amount;
        //CollectCoins2.coinsText.text = CollectCoins2.coins2.ToString();
        
    }

   // Adiciona o valor na interface do script ItemManager
    public void AddCoinsSum(int amount = 1)
    {
        coins2.valueSpin += amount;
               
    }
}
