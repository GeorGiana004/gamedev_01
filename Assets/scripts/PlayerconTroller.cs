using UnityEngine;

public class PlayerconTroller : MonoBehaviour
{   public float speed =  5.0f;
    public float horisontalInput;
    public float turnSpeed;
  
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        //muovere il bidone 
        transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.right*Time.deltaTime * turnSpeed);

        
        horisontalInput = Input.GetAxis("Horisontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horisontalInput);

       
    }
   
}
