using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var employee = new Employee
            {
                Id = 9999,
                Name = "aaaaa",
                HireDate = new DateTime(2023,01,01),
            };
            //シリアル化
            using(var writer = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }
            //逆シリアル化
            using(var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(emp);
            }
        }

        private static void Exercise1_2(string v) {
            var employee = new Employee[]
            {
                new Employee
                {
                    Id = 9999,
                    Name = "aaaaa",
                    HireDate = new DateTime(2023, 01, 01),
                },
                new Employee
                {
                    Id = 3333,
                    Name = "bbbbb",
                    HireDate = new DateTime(2022, 01, 01),
                }
            };
            //シリアル化
            using (var writer = XmlWriter.Create(v)) {
                var serializer = new DataContractSerializer(employee.GetType());
                serializer.WriteObject(writer, employee);
            }
        }

        private static void Exercise1_3(string v) {
            //逆シリアル化
            using (var reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emp = serializer.ReadObject(reader) as Employee[];
                foreach (var employee in emp) {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void Exercise1_4(string v) {
            var employee = new Employee[]
            {
                new Employee
                {
                    Id = 9999,
                    Name = "aaaaa",
                    HireDate = new DateTime(2023, 01, 01),
                },
                new Employee
                {
                    Id = 3333,
                    Name = "bbbbb",
                    HireDate = new DateTime(2022, 01, 01),
                }
            };
            using(var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(employee.GetType());
                serializer.WriteObject(stream, employee);
            }
            //逆シリアル化
            /*
            using(var stream = new FileStream(v, FileMode.Open, FileAccess.Read)) {
                var serializer = new DataContractJsonSerializer(typeof(Employee[]));
                var emp = serializer.ReadObject(stream) as Employee[];
                foreach (var employee2 in emp) {
                    Console.WriteLine(employee2);
                }
            }
            */
        }
    }
}
