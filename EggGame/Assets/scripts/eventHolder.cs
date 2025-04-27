using System;
using UnityEngine;

public class eventHolder : MonoBehaviour
{
    public static event Action<Vector3> OnSendPosition;
    public static event Action<int> OnEggPick;
    public static event Action OnPoopPick;


    public void SendPosition(Vector3 position)
    {
        if (OnSendPosition != null)
        {
            OnSendPosition.Invoke(position);
        }
    }
    public void EggPick(int points)
    {
        if (OnEggPick != null)
        {
            OnEggPick.Invoke(points);
        }
    }
    public void PoopPick()
    {
        if (OnPoopPick != null)
        {
            OnPoopPick.Invoke();
        }
    }
}
