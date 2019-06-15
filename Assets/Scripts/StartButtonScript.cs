using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
