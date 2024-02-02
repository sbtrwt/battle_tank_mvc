using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController tankController;
    public float movementSpeed;
    public float rotationSpeed;
    public TankType tankType;

    public Material color;
    public TankModel(float movement, float rotation, TankType _tankType, Material _color)
    {
        movementSpeed = movement;
        rotationSpeed = rotation;
        tankType = _tankType;
        color = _color;
    }
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;

    }
}
