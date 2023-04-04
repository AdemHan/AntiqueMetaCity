using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EkranGecis : MonoBehaviour
{
    public void ArSayfasi()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void AnimasyonSayfasi()
    {
        SceneManager.LoadScene("AnimasyonSayfasi");
    }
   
    public void MenuSayfasi()
    {
        SceneManager.LoadScene("AcilisSayfasi");
    }
     public void Cikis()
    {
        Application.Quit();
        Debug.Log("Uygulamadan çıktınız..");
    }
}
