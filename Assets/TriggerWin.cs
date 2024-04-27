using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TriggerWin : MonoBehaviour
{
    public GameObject Win;
    public TextMeshProUGUI text;
    public static float time_start,time_end,timeRun;
    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
            time_start = Time.time;
    }
    public void Update()
    {
        time_end = Time.time;
        timeRun = time_end - time_start;
        if ((int)(timeRun % 60) > 9)
            text.text = $"{(int)timeRun / 60}:{(int)(timeRun % 60)}:{(int)(1000*(timeRun -((int)(timeRun))))}";
        else
            text.text = $"{(int)timeRun / 60}:0{(int)(timeRun % 60)}:{(int)(1000 * (timeRun - ((int)(timeRun))))}";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) { 
        Win.SetActive(true);
        
        Time.timeScale = 0;
            }
    }

}
