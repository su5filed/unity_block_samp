using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody mytRigid; //Rigidbody　物理エンジンを制御する。

    public GameManager m_gameManager;

    // Start is called before the first frame update
    void Start()
    {

        mytRigid = this.GetComponent<Rigidbody>();
        // 右斜め上にｘspeedで出す。　
        mytRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// 終了判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            // ゲームマネージャのゲームオーバー呼び出し
            m_gameManager.GameOver();
        }
    }

}
