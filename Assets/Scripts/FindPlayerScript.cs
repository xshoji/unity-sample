using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayerScript : MonoBehaviour
{
    public GameObject zombie;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //プレイヤーが範囲内にきたら狙う
    void OnTriggerStay(Collider t)
    {
        if (t.gameObject == player)
        {
            zombie.transform.LookAt(player.transform.position);
        }
    }
}
