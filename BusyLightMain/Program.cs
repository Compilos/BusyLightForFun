using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busylight;

namespace BusyLightMain
{
    class Program
    {
        static void Main(string[] args)
        {

            var status= GetStatus();

            //while (true)
            //{
            //    var busy = new SDK();
            //    //busy.Blink(222,222,222,2,2);
            //    var pulse = new PulseSequence();

            //    busy.Pulse(GetPulseSequense());
            //    busy.Pulse(40, 244, 90);
            //    busy.Terminate();
            //}
        }

        public static PulseSequence GetPulseSequense()
        {
            var sequence = new PulseSequence();
            sequence.Color = BusylightColor.Red;
            sequence.Step1 = 1;
            sequence.Step2 = 64;
            sequence.Step3 = 11;
            sequence.Step4 = 55;
            sequence.Step5 = 255;
            sequence.Step6 = 228;
            sequence.Step7 = 64;
            return sequence;
        }

        public static string GetStatus()
        {
            var xmlService = new XmlService();
            string url = "https://avalbdev.visualstudio.com/lbweb/_apis/build/builds?api-version=4.1";
            var xmlServiceResponse =  xmlService.GetXml(url);
            return xmlServiceResponse;
        }
    }
}