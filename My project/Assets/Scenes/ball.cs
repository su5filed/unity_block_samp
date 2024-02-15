using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody mytRigid; //Rigidbody�@�����G���W���𐧌䂷��B

    public GameManager m_gameManager;

    // Start is called before the first frame update
    void Start()
    {

        mytRigid = this.GetComponent<Rigidbody>();
        // �E�΂ߏ�ɂ�speed�ŏo���B�@
        mytRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// �I������
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            // �Q�[���}�l�[�W���̃Q�[���I�[�o�[�Ăяo��
            m_gameManager.GameOver();
        }
    }

}
