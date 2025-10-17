using System.IO;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;  
    public float speed = 5.0f;
    public Vector3 offset = new Vector3 (0, 5, -7);




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
 
