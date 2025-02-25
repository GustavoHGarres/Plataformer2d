using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoin : ItemCollactableBase
{
    
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
        
        ItemManager.Instance.AddCoinsSum(); // Adiciona o valor na interface do script ItemManager
    }
}
