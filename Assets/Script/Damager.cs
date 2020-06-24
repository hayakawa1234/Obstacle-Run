using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public int damage;

    //ダメージの初期設定は10
    private void Start()
    {
        damage = 10;
    }
}
