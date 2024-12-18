using UnityEngine;

public class catisgoingwoo : MonoBehaviour
{   
    //some variables for movement
    // goog dabadiidabadaidabadaindabadiidabadaidabadiidabadai
    public CharacterController controller;
    
    private float verticalSpeed = 0f;
    private float horizontalSpeed = 0f;
    
    private float mouseMovement = 0f;
    
    public int speed = 3;
    public int mouseSpeed = 9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // we do not care
    }

    // Update is called once per frame
    void Update()
    {
        //moving ig
        verticalSpeed = Input.GetAxis("Vertical");
        horizontalSpeed = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalSpeed, -1, verticalSpeed);

        //hiirellä kääntyminen
        mouseMovement += Input.GetAxis("Mouse X") * mouseSpeed;
        transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
        direction = transform.rotation * direction;
    
        controller.Move(direction * speed * Time.deltaTime);
    }
}
