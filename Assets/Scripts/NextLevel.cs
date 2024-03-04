using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //[SerializeField] int SceneIndex;  // Böyle bir yol daha var elle sahnelere bir sonraki sahneye gitmesi için giriþ yapmamýz gerek 
    private Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_scene.buildIndex+1); //burda da yukardaki yapýldýðý zaman sadece parantez içine SceneIndex yazýlmasý gerekiyor 
        }
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
