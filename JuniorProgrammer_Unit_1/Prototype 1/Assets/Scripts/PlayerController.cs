using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variable
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    
    private float changeCamera;
    private bool activeMainCamera = true;
    public GameObject mainCamera;

    bool buttonC = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        changeCamera = Input.GetAxis("Fire1");
        buttonC = Input.GetButtonDown("Jump");


        if (changeCamera == 1)
        {
            ChangeCamera();
        }

        if (buttonC)
        {
            ChangeCamera();
        }

        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Turn vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime * verticalInput);
        
    }

    void ChangeCamera()
    {
        if (activeMainCamera)
        {
            mainCamera.SetActive(false);
            activeMainCamera = false;
        }
        else
        {
            mainCamera.SetActive(true);
            activeMainCamera = true;
        }
    }
}
