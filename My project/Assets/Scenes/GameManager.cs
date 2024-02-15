using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ブロックの配列
    public block[] mBlocks;
    public GameObject m_GameOverUI;     // ゲームオーバー
    public GameObject m_GameClearUI;    // ゲームクリア
    private bool isGameClear = false;   // ゲームクリア

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isGameClear != true)
            if (DestroyAllBlocks())
            {
                // ゲームクリア
                Debug.Log($"ゲームクリア!");
                m_GameClearUI.SetActive(true);
                isGameClear = true;
            }
    }


    /// <summary>
    /// 全てブロックが消えている true
    /// </summary>
    /// <returns></returns>
    private bool DestroyAllBlocks()
    {
        foreach (block bl in mBlocks)
        {
            if (bl != null) return false;
        }

        // 全部消えている。
        return true;
    }

    public void GameOver()
    {
        Debug.Log($"ゲームオーバ");
        m_GameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        Debug.Log($"ゲームリトライ");
        // ファイル>Build Profiles>Add Build Profuile　にSampleSceneを追加しておく
        SceneManager.LoadScene("SampleScene");
        m_GameOverUI.SetActive(false);
        m_GameClearUI.SetActive(false);
    }

}
