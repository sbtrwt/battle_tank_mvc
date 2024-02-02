﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);;
        rb = tankView.GetRigidbody();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        tankView.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float movementSpeed) 
    {
        if (rb == null) rb = tankView.GetRigidbody();

        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        if (rb == null) rb = tankView.GetRigidbody();

        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
