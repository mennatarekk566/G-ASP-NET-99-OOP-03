using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_99_OOP_03
{
    #region question3 partical
    //public class DeliveryCenter
    //{
    //    public string CenterName { get; set; }
    //    public Driver Driver { get; set; }

    //    private Shipment[] shipments = new Shipment[20];
    //    private int count = 0;

    //    public DeliveryCenter(string centerName)
    //    {
    //        CenterName = centerName;
    //    }

    //    public void AddShipment(Shipment shipment)
    //    {
    //        if (count < shipments.Length)
    //        {
    //            shipments[count] = shipment;
    //            count++;
    //            Console.WriteLine("Shipment Added Successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Delivery center is full.");
    //        }
    //    }

    //    public bool RemoveShipment(string trackingCode)
    //    {
    //        for (int i = 0; i < count; i++)
    //        {
    //            if (shipments[i].TrackingCode == trackingCode)
    //            {
    //                for (int j = i; j < count - 1; j++)
    //                {
    //                    shipments[j] = shipments[j + 1];
    //                }
    //                count--;
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    public Shipment this[int index]
    //    {
    //        get { return shipments[index]; }
    //    }

    //    public Shipment this[string trackingCode]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < count; i++)
    //            {
    //                if (shipments[i].TrackingCode == trackingCode)
    //                    return shipments[i];
    //            }
    //            return null;
    //        }
    //    }

    //    public void PrintAllShipments()
    //    {
    //        Console.WriteLine("==========================================");
    //        Console.WriteLine("Delivery Center : " + CenterName);
    //        if (Driver != null)
    //            Console.WriteLine("Driver : " + Driver.FullName);
    //        Console.WriteLine("==========================================");

    //        for (int i = 0; i < count; i++)
    //        {
    //            shipments[i].PrintShipment();
    //            Console.WriteLine();
    //        }
    //    }
    //}
    #endregion
}
