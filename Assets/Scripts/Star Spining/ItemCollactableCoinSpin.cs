using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoinSpin : ItemCollactableBaseSpin
{
    
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager2.Instance2.AddCoins();
        
        ItemManager2.Instance2.AddCoinsSum(); // Adiciona o valor na interface do script ItemManager
    }
}

