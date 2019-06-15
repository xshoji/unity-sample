using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //オブジェクトが触れている間
    void OnTriggerEnter(Collider t)
    {
        if (t.gameObject == player)
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
}
