using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlorManager : MonoBehaviour
{
    private int kalan;

    [SerializeField]
    public Text KalanText;
    [SerializeField]
    private GameObject winPanel;
    [SerializeField]
    private GameObject losePanel;
   
    [SerializeField]
    private GameObject player;





    private void Start()
    {
        winPanel.SetActive (false);
        losePanel.SetActive (false);
        kalan = 10;
        Time.timeScale = 1; //oyun ilk başta tam çalışır durumda iken, replay butonundan sonra süre işlemez. o yüzden burada bu işlemi yapmalıyız..
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Enemy") //eğer çarpışan nesnenin tagı düşmansa düşmanı yok ediyoruz
        {
            Destroy(collision.gameObject);
            kalan--;
            KalanText.text = kalan.ToString("KALAN:" + "00");
            if (kalan == 1)  //Tek kalan biz isek oyunu kazandık :)
            {
                winPanel.SetActive(true);
                Destroy (player);
                Time.timeScale = 0;
              
            }
        }
        else if(collision.tag == "Player") // eğer çarpan nesne player yeni biz isek bizi yok ediyoruz.
        {
            //Destroy(collision.gameObject); // eğer bu nesneyi yok edersem, Enemy kodumuzdaki takip kodu devreden çıkacağı için binlerce hata alıyoruz :(
            
            Time.timeScale = 0;
            losePanel.SetActive(true);  //oyunu kaybettik :(

        }
       
        
    }
    public void replayButton()
    {
        SceneManager.LoadScene("GameScene");  // tekrar oyna butonu ile sahneyi tekrardan yüklüyoruz ve oyuna baştan başlamış oluyoruz.
    }
}
