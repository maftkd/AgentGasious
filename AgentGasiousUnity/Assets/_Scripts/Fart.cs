using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fart : MonoBehaviour
{
    public Transform _pop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Destroy(transform.gameObject);
    }

    private void OnDestroy()
    {
        Transform pop = Instantiate(_pop, transform.position, Quaternion.identity);
        Destroy(pop.gameObject, 1f);
    }
}
