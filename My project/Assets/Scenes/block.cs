using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ƒuƒƒbƒN‚É“–‚½‚Á‚½Û‚Ìˆ—
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // ‰½‚©‚ ‚½‚Á‚½ê‡
        Destroy(this.gameObject);
    }
}
