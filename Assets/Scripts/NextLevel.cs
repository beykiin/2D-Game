using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //[SerializeField] int SceneIndex;  // B�yle bir yol daha var elle sahnelere bir sonraki sahneye gitmesi i�in giri� yapmam�z gerek 
    private Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_scene.buildIndex+1); //burda da yukardaki yap�ld��� zaman sadece parantez i�ine SceneIndex yaz�lmas� gerekiyor 
        }
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
