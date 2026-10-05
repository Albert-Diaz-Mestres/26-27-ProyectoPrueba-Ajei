using UnityEngine;//Libreria general Unity
using UnityEngine.InputSystem; //Libreria para recoger inputs del jugardor 
public class Mover2D : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = new Vector3(0, 0);


        if (Keyboard.current.wKey.isPressed)
        {
            direction.y =1; 
        }

        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }


        transform.position = transform.position + direction * speed * Time.deltaTime;




        
        // transforn.position-> Acceder a ña posicion del objeto 
        
     
       // 1rst step: Read user input 
       // 2nd step: generate a direction
       // 3rd step: apply the movement
    }
}
