using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ���@�ǂ�������������
            if (this.transform.position.x > -4)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime /*�P�t���[���̎��Ԃ�������*/;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // �E�@�ǂ�������������
            if (this.transform.position.x < 4)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }

    }
}
