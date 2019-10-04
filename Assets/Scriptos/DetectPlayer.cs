using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        transform.parent.GetComponent<PuzzleScript>().CollisionDetected(transform.tag);
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
