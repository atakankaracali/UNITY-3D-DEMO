using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyScript : MonoBehaviour
{
    Transform Player;
    float RotateSpeed = 10.0f, MoveSpeed = 5.0f;  //hızlarımızı belirledik
    
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform; //Playeri takip ediyoruz
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), RotateSpeed * Time.deltaTime); // rotasyonumuzu player yapıyoruz

        transform.position += transform.forward * MoveSpeed * Time.deltaTime; //düşman hızları ayarlandı
    }

}
