using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitItem : MonoBehaviour, IItem
{
    public int restoreHealth = 50;

    public void Use ()
    {
        Debug.Log("ü���� ȸ���ߴ�!");

        Player player = FindObjectOfType<Player>();
        player.hp += restoreHealth;

        gameObject.SetActive(false);
    }
}
