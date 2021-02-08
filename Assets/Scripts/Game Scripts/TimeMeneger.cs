using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeMeneger : MonoBehaviour
{
    [SerializeField] Text TimeText;
    public float time;
    [SerializeField]
    private GameObject losePanel;
    void Start()
    {
        losePanel.SetActive(false);
        time = 80; //süreyi 80 saniye ayarladım. baya fazla bir süre bence. dediğim gibi salladım sayıyı :) .
    }

    
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            TimeText.text = time.ToString("TIME:"+"00"); //süreyi ekranda UI yazdırma işlemi
        }
        else
        {
            losePanel.SetActive(true);  //süre bitince bence oyunu kaybetmeli 
            Time.timeScale = 0;
            
        }
    }
}
