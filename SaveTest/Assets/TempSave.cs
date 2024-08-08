using System;
using System.IO;
using MemoryPack;
using UnityEngine;

namespace Temporary
{
    public class TempSave : MonoBehaviour
    {
        private void Start()
        {
            var v = new Person { Age = 40, Name = "John" };

            var bin = MemoryPackSerializer.Serialize(v);
            var val = MemoryPackSerializer.Deserialize<Person>(bin);

            Debug.Log(val.Name + " " + val.Age);
        }
    }
    
    [MemoryPackable]
    public partial class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        static partial void StaticConstructor()
        {
            Debug.Log(" run static constructor");
        }
    }
}


