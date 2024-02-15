using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �u���b�N�̔z��
    public block[] mBlocks;
    public GameObject m_GameOverUI;     // �Q�[���I�[�o�[
    public GameObject m_GameClearUI;    // �Q�[���N���A
    private bool isGameClear = false;   // �Q�[���N���A

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
                // �Q�[���N���A
                Debug.Log($"�Q�[���N���A!");
                m_GameClearUI.SetActive(true);
                isGameClear = true;
            }
    }


    /// <summary>
    /// �S�ău���b�N�������Ă��� true
    /// </summary>
    /// <returns></returns>
    private bool DestroyAllBlocks()
    {
        foreach (block bl in mBlocks)
        {
            if (bl != null) return false;
        }

        // �S�������Ă���B
        return true;
    }

    public void GameOver()
    {
        Debug.Log($"�Q�[���I�[�o");
        m_GameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        Debug.Log($"�Q�[�����g���C");
        // �t�@�C��>Build Profiles>Add Build Profuile�@��SampleScene��ǉ����Ă���
        SceneManager.LoadScene("SampleScene");
        m_GameOverUI.SetActive(false);
        m_GameClearUI.SetActive(false);
    }

}
