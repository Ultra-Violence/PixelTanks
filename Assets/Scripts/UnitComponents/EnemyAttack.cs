using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyAttack : MonoBehaviour
{
    private float rangeAttack = 5;
    private bool attack;
    [SerializeField] private GameObject enemyBullet;

    private void Start() {
        StartCoroutine(attackCoroutine());
    }

    void Update()
    {
        Collider2D[] colliderList = Physics2D.OverlapCircleAll(transform.position, rangeAttack);
            foreach(Collider2D target in colliderList){
                if(Array.Exists(colliderList, enemys => enemys.tag == "Player") == true){
                    attack = true;
                } 
                else{
                    attack = false;
                }   
            } 
    }

    IEnumerator attackCoroutine(){
        yield return new WaitForSeconds(3f);
            if(attack == true){
                Instantiate(enemyBullet, transform.position, Quaternion.identity);
                GetComponent<AudioSource>().Play();
            }
        StartCoroutine(attackCoroutine());
    }
}
