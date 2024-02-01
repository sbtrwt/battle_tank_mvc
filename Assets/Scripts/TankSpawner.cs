using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tank = new TankModel(30,20);
        TankController tankController = new TankController(tank, tankView);
    }
  
}
