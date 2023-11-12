using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHp : MonoBehaviour
{
    public int towerHP;
    public int damage;
    Tower tower;

    void Start()
    {
        tower = this.GetComponent<Tower>();
        towerHP = 100;
        damage = 10;
    }

    void Update()
    {
        if (towerHP <= 0)
        {
            tower.team = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트의 태그가 "Bullet"인지 확인
        if (other.CompareTag("Bullet"))
        {
            // 포인트의 HP 감소
            towerHP -= damage;
        }
    }

}
