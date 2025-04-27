using System;
using UnityEngine;

public class eventHolder : MonoBehaviour
{
    public static event Action<Vector3> OnSendPosition;
    public static event Action<string> OnLootPick;

    public void SendPosition(Vector3 position)
    {
        if (OnSendPosition != null)
        {
            OnSendPosition.Invoke(position);
        }
    }
    public void LootPick(string lootType)
    {
        if (OnSendPosition != null)
        {
            OnLootPick.Invoke(lootType);
        }
    }
}
