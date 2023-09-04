using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise01 {
    [DataContract(Name = "emplyee")]
    [XmlRoot("employee")]
    public class Employee {
        [XmlElement("id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        [XmlElement("name")]
        public string Name { get; set; }
        [DataMember(Name = "HireDate")]
        [XmlElement("hiredate")]
        public DateTime HireDate { get; set; }

        public override string ToString() {
            return string.Format("[Id={0},Name={1},HireDate={2}",Id,Name,HireDate);
        }
    }
}
