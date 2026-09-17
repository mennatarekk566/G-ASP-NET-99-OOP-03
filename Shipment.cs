using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_99_OOP_03
{
    #region question3 partical 
    //public class Shipment
    //{
    //    public string TrackingCode { get; set; }
    //    public string Description { get; set; }
    //    public decimal Weight { get; set; }
    //    public decimal DeliveryFee { get; set; }
    //    public DeliveryAddress Destination { get; set; }

    //    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //            throw new ArgumentException("Tracking code cannot be empty.");
    //        if (weight <= 0)
    //            throw new ArgumentException("Weight must be greater than 0.");
    //        if (deliveryFee < 0)
    //            throw new ArgumentException("Delivery fee cannot be negative.");

    //        TrackingCode = trackingCode;
    //        Description = description;
    //        Weight = weight;
    //        DeliveryFee = deliveryFee;
    //        Destination = destination;
    //    }
    //    public virtual decimal EstimatedCost
    //    {
    //        get { return DeliveryFee; }
    //    }

    //    public void UpdateDeliveryFee(decimal newFee)
    //    {
    //        if (newFee < 0)
    //            throw new ArgumentException("Delivery fee cannot be negative.");
    //        DeliveryFee = newFee;
    //    }

    //    public void UpdateWeight(decimal newWeight)
    //    {
    //        Weight = newWeight;
    //    }

    //    public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
    //    {
    //        Weight = newWeight + extraPackingWeight;
    //    }

    //    public virtual void PrintShipment()
    //    {
    //        Console.WriteLine("Tracking Code : " + TrackingCode);
    //        Console.WriteLine("Description   : " + Description);
    //        Console.WriteLine("Weight        : " + Weight + " KG");
    //        Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
    //        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    //      }

    #endregion
    }
}