using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieControllerScript : MonoBehaviour
{
    private Vector3 destination;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        move();
        // 初期位置
        transform.position = destination;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }

    //オブジェクトが触れている間
    void OnTriggerEnter(Collider t)
    {
        if (t.gameObject == player)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    private void move()
    {
        var randDestination = Random.insideUnitCircle * 6;
        var x = randDestination[0];
        var y = randDestination[1];
        destination = new Vector3(x, 0.0f, y);
    }
}