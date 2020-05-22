using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartMachine : MonoBehaviour
{
    public Transform _fart;
    public float _floatSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispatchFart()
    {
        int amount = Random.Range(2, 7);
        for(int i=0; i< amount; i++)
        {
            float angle = Random.value * Mathf.PI * 2;
            float size = Random.value * 1.2f + .4f;
            float radius = Random.value + 1f;
            float lifeTime = Random.Range(10f, 14f);
            Vector3 offset = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            Transform newFart = Instantiate(_fart, transform.position + offset, Quaternion.identity);
            newFart.GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * _floatSpeed);
            newFart.localScale = Vector3.one * size;
            //temp code for a sec
            Destroy(newFart.gameObject, lifeTime);
        }
    }
}
