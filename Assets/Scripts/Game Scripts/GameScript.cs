using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] EnemyPrefab;
    
    void Start()
    {
        for (int i =0; i < 9; i++) // 9 adet düşman ürettik.
        {
            EnemyOn(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyOn(int i)
    {
        GameObject Enemy = Instantiate(EnemyPrefab[Random.Range(0, EnemyPrefab.Length)]) as GameObject; //düşman prefeb kodu.
    }
}
