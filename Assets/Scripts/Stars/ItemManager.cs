using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    private SumCoins CollectCoins;    // Somatoria de moedas
    //public int coins; // Passando para linha abaixo como ScripttableObject, tira o int e acrescenta o SOInt
    public SOInt coins;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        CollectCoins = SumCoins.sumCoin;
        CollectCoins.coins = 0;
        Reset();
        
    }

    private void Reset()
    {
        //coins = 0; // Passando para a linha abaixo como ScriptableObject, onde tem coins, passa para coins.value
        coins.value = 0;
    }
    
    // Soma as moedas na UI texto
    public void AddCoins(int amount = 1)
    {
        CollectCoins.coins += amount;
        //CollectCoins.coinsText.text = CollectCoins.coins.ToString();
        
    }

   // Adiciona o valor na interface do script ItemManager
    public void AddCoinsSum(int amount = 1)
    {
        coins.value += amount;
               
    }
}
