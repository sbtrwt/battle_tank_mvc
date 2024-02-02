using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankType tankType;

        public Material color;
    }

    public List<Tank> tankList;
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        //CreateTank();
    }

    public void CreateTank(TankType tankType)
    {
        TankModel tank = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
        switch (tankType)
        {
            case TankType.BlueTank:
                tank = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
                break;
            case TankType.GreenTank:
                tank = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
                break;
            case TankType.RedTank:
                tank = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
                break;
            default:
                tank = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
                break;
        }
        TankController tankController = new TankController(tank, tankView);
    }
  
}
