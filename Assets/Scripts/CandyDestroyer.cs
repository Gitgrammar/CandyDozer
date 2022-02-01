using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Candy")
        {
            //指定の数だけcandyのストックを増やす
            candyManager.AddCandy(reward);
            Destroy(other.gameObject);
        }
    }
   
}
