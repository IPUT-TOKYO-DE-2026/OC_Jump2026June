using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;

    // シングルトン化に必要なもの
    static GameManager instance;  // インスタンスを保持する
    public static GameManager Instance // インスタンスを参照するプロパティ
    {
        get
        {
            if (instance == null)
            {  // 始めて参照される際にシーンからGameManagerを探す
                instance = (GameManager)FindObjectOfType(typeof(GameManager));
                if (instance == null)
                {  // 存在しなければエラーとする
                    Debug.LogError(typeof(GameManager) + "がシーンに存在しません");
                }
            }
            return instance;
        }
    }

    public static bool isGameOver()
    {
        return Instance.gameOver;
    }

    public static void SetGameOver()
    {
        Instance.gameOver = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
