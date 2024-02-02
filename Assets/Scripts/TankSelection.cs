using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
   public void BlueTankSelected() {
        tankSpawner.CreateTank(TankType.BlueTank);
        Debug.Log("Blue tank selected");
        this.gameObject.SetActive(false);
    }
    public void GreenTankSelected() { 
        tankSpawner.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false); }
    public void RedTankSelected() { 
        tankSpawner.CreateTank(TankType.RedTank); 
        this.gameObject.SetActive(false); }
}
