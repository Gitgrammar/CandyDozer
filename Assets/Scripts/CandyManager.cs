using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    const int DefaultCandyAmount = 30;
    const int RecoverySeconds = 10;

    public int candy = DefaultCandyAmount;
    //ストックまでの回復の残り秒数
    int counter;

    public void ConsumeCandy()
    {
        if (candy > 0)
        {
            candy--;
        }
    }
    public int GetCandyAmount()
    {
        return candy;
    }
    public void AddCandy(int amount)
    {
        candy += amount;
    }
    private void OnGUI()
    {
        GUI.color = Color.black;

        string label = "Candy :" + candy;
        //回復カウントしているときだけ秒数を表示
        if(counter>0) label=label+"("+counter+"s)";
        GUI.Label(new Rect(50, 50, 100, 30), label);
    }
     void Update()
    {
        //キャンディのストックがデフォルトより少なく回復カウントしてない時カウントスタート
        if(candy<DefaultCandyAmount && counter <= 0)
        {
            StartCoroutine(RecoverCandy());
        }
    }
    IEnumerator RecoverCandy() { 
        counter =RecoverySeconds;
        //1秒ずつカウントを進める
        while (counter>0){
        yield return new WaitForSeconds(1.0f);
        counter--;

}
candy++;
}
}
