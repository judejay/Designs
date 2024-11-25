using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Memento
{
    public class SpeedometerMomento
    {
        public SpeedometerMomento(Speedometer speedometer)
        {
            //Serializing the object
            Stream stream = File.Open("SpeedometerData.ser", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, speedometer);
            stream.Close();
        }
            public virtual Speedometer RestoreState()
        {
            //Deserialize the object
            Speedometer speedo;
            Stream stream = File.Open("SpeedometerData.ser", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            speedo = (Speedometer)formatter.Deserialize(stream);
            stream.Close();
            return speedo;

        }
    }
