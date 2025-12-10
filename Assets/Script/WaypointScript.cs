using System.Collections;
using UnityEngine;

public class WaypointScript : MonoBehaviour
{

    public GameObject prefeb;
    public Transform Parent;
    void Start()
    {
        StartCoroutine(Createwaypoint());
    }

    void Update()
    {
        
    }

    public IEnumerator Createwaypoint()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(prefeb, transform.position, gameObject.transform.rotation, Parent);
        StartCoroutine(Createwaypoint());
    }
}
