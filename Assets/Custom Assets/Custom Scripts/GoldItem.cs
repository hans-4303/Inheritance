using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldItem : MonoBehaviour, IItem
{
    public int goldAmount = 100;

    public void Use()
    {
        Debug.Log("��带 �����!");

        Player player = FindObjectOfType<Player>();
        player.gold += goldAmount;

        gameObject.SetActive(false);
    }
}
