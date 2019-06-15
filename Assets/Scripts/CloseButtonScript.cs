using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonScript : MonoBehaviour
{
    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Application.Quit();
    }
}
