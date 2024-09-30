using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] float _PlatformSpeed = 5;
  
    float elapsed = 0f;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(1, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
       transform.Translate(direction * Time.deltaTime * _PlatformSpeed);

        elapsed += Time.deltaTime;
        if (elapsed > 1) {
            elapsed = 0;
            direction *= -1;
        }
       
        
    }
}
