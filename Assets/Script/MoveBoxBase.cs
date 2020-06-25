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

    public virtual void ChangeBox()
    {
        this.transform.localScale = new Vector3(10, 10, 10);
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);
        }

        if (hp <= 0)
        {
            ChangeBox();
        }
    }
}

