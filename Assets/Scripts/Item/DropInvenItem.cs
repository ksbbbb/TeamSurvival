﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Drop Item", menuName = "Data/DropItem")]
public class DropInvenItem : ItemData
{

    public override void Use()
    {
        Debug.Log($"{name} 을(를) 떨어뜨립니다.");
        //Instantiate(prefab, new Vector2(0,0), Quaternion.identity);
        //InventoryManager.Instance.Remove(this);
    }
}
