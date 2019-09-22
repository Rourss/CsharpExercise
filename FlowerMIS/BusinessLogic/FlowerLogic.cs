using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerMIS.DataAccess;
using System.Data;

namespace FlowerMIS.Logic
{
  public  class FlowerLogic
    {
        private Flower fw;
        public FlowerLogic()
        {
            fw = new Flower();
        }
        //封装
        public bool DelFlower(string flowerID)
        {
            return fw.DelFlower(flowerID);
        }
        public bool InsertFlowerNotPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus)
        {
            return fw.InsertFlowerNotPhoto(flowerID, flowerName, flowerType, price, flowerStatus);
        }
        public bool InsertFlower(string flowerID, string flowerName, string flowerType, double price, int flowerStatus, string flowerPhoto)
        {
            return fw.InsertFlower(flowerID, flowerName, flowerType, price, flowerStatus, flowerPhoto);
        }
        public bool UpdateFlower(string flowerID, string flowerName, string flowerType, double price, int flowerStatus,string flowerPhoto)
        {
            return fw.UpdateFlower(flowerID, flowerName, flowerType, price, flowerStatus,flowerPhoto);
        }
        public bool UpdateFlowerDelPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus)
        {
            return fw.UpdateFlowerDelPhoto(flowerID, flowerName, flowerType, price, flowerStatus);
        }
        public bool UpdateFlowerAndPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus, byte[] flowerPhoto)
        {
            return fw.UpdateFlowerAndPhoto(flowerID, flowerName, flowerType, price, flowerStatus, flowerPhoto);
        }
        public DataSet GetFlowerByFlowerNameAndFlowerType(string flowerName, string flowerType)
        {
            return fw.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType);
        }
    }
}
