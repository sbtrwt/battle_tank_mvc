using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movementSpeed;
    private float rotationSpeed;
    public Rigidbody rb;
    public MeshRenderer[] childs;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movementSpeed != 0)
        {
            tankController.Move(movementSpeed, tankController.GetTankModel().movementSpeed);
        }
        if (rotationSpeed != 0)
        {
            tankController.Rotate(rotationSpeed, tankController.GetTankModel().rotationSpeed);
        }
    }
    private void Movement()
    {
        movementSpeed = Input.GetAxis("Vertical");
        rotationSpeed = Input.GetAxis("Horizontal");
    }
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;

    }
    public Rigidbody GetRigidbody() { return rb; }

    public void ChangeColor(Material color)
    {
        for(int indx =0; childs.Length > indx; indx++)
        {
            childs[indx].material = color;
        }
    }
}
