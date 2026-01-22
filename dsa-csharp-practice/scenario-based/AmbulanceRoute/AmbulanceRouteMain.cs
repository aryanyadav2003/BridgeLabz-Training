using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AmbulanceRoute
{
    internal class AmbulanceRouteMain
    {
        static void Main()
        {
            CircularHospital hospital = new CircularHospital();
            hospital.AddUnit("Emergency");
            hospital.AddUnit("Radiology");
            hospital.AddUnit("Surgery");
            hospital.AddUnit("ICU");
            hospital.DisplayRoute();
            hospital.SetMaintenance("Emergency");
            hospital.SetMaintenance("Radiology");
            Console.WriteLine(" Ambulance Arrived");
            hospital.RouteAmbulance("Emergency");
            hospital.RemoveUnit("ICU");
            hospital.DisplayRoute();
        }
    }
}