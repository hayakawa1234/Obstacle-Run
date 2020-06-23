using UnityEngine;
using UnityEngine.Assertions;

public class MoveBoxBase : MonoBehaviour
{   //  最初のHP
    int maxHp = 100;
    private int hp = 100;
    void Start()
    {
        hp = maxHp;
    }

    void Damage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            hp = 0;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);
        }
    }

}

