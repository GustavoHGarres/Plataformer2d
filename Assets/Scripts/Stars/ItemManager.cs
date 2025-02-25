using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    private SumCoins CollectCoins;    // Somatoria de moedas
    public int coins;
    
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
        coins = 0;
    }

    public void AddCoins(int amount = 1)
    {
        CollectCoins.coins += amount;
        CollectCoins.coinsText.text = CollectCoins.coins.ToString();
    }
}
