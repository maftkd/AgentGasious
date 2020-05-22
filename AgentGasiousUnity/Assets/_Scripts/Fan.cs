using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public bool _fanning = false;
    public LayerMask _fartLayer;
    public float _maxFanStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!_fanning && Input.GetButtonDown("Fire1"))
        {
            _fanning = true;
        }
        else if(_fanning && Input.GetButtonUp("Fire1"))
        {
            _fanning = false;
        }

        if (_fanning)
        {
            Collider[] cols = Physics.OverlapSphere(transform.position + transform.forward * 5f, 5f, _fartLayer);
            foreach(Collider c in cols)
            {
                Vector3 dir = c.transform.position - transform.position;
                float strength = Mathf.Min(10f,1f/dir.sqrMagnitude);
                c.GetComponent<Rigidbody>().AddForce(dir * _maxFanStrength * strength);
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (_fanning)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position + transform.forward * 5f, 5f);
        }
    }
}
