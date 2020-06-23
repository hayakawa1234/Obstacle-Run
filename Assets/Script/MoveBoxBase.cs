using UnityEngine;
using UnityEngine.Assertions;

public class MoveBoxBase : MonoBehaviour
{   //最初のHP
    int maxHp = 10;
    //変動するHP
    protected int hp = 10;
    void Start()
    {
        hp = maxHp;
    }

    //ダメージを受けた時の処理
    public void Damage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            hp = 0;
        }
    }
}

