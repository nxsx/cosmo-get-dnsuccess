using HTCGetDnReceiveSuccess.Controllers;
using HTCGetDnReceiveSuccess.Models;
using System;
using System.Collections.Generic;

namespace HTCGetDnReceiveSuccess.Services
{
    public class TransferDnToMoldShot
    {
        public static void DataTransferRF()
        {
            List<DnReceiveSuccess> Lists = DnReceiveSuccessController.GetDnReceiveSuccessesRF();

            foreach (DnReceiveSuccess list in Lists)
            {
                bool result = MoldLifeShotController.postMoldLiftShot(list);

                if (result)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
        }

        public static void DataTransferWAC()
        {
            List<DnReceiveSuccess> Lists = DnReceiveSuccessController.GetDnReceiveSuccessesWAC();

            foreach (DnReceiveSuccess list in Lists)
            {
                bool result = MoldLifeShotController.postMoldLiftShot(list);

                if (result)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
        }

        public static void DataTransferSAC()
        {
            List<DnReceiveSuccess> Lists = DnReceiveSuccessController.GetDnReceiveSuccessesSAC();

            foreach (DnReceiveSuccess list in Lists)
            {
                bool result = MoldLifeShotController.postMoldLiftShot(list);

                if (result)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
        }
    }
}
