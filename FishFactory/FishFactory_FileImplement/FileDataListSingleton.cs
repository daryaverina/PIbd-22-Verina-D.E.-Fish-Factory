using FishFactoryContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using FishFactoryFileImplement.Models;

namespace FishFactoryFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string ComponentFileName = "Component.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string CannedFileName = "Canned.xml";
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Canned> Canneds { get; set; }

        public static void Save()
        {
            instance.SaveOrders();
            instance.SaveCanneds();
            instance.SaveComponents();
        }

        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Orders = LoadOrders();
            Canneds = LoadCanneds();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveComponents();
            SaveOrders();
            SaveCanneds();
        }
        private List<Component> LoadComponents()
        {
            var list = new List<Component>();
            if (File.Exists(ComponentFileName))
            {
                var xDocument = XDocument.Load(ComponentFileName);
                var xElements = xDocument.Root.Elements("Component").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                var xDocument = XDocument.Load(OrderFileName);
                var xElements = xDocument.Root.Elements("Order").ToList();
                OrderStatus status;
                DateTime? dateImplement;
                foreach (var elem in xElements)
                {
                    Enum.TryParse(elem.Element("Status").Value, out status);
                    dateImplement = null;
                    if (elem.Element("DateImplement").Value != "")
                    {
                        dateImplement = DateTime.Parse(elem.Element("DateImplement").Value);
                    }
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        CannedId = Convert.ToInt32(elem.Element("CannedId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = status,
                        DateCreate = DateTime.Parse(elem.Element("DateCreate").Value),
                        DateImplement = dateImplement
                    });
                }
            }
            return list;
        }
        private List<Canned> LoadCanneds()
        {
            var list = new List<Canned>();
            if (File.Exists(CannedFileName))
            {
                var xDocument = XDocument.Load(CannedFileName);
                var xElements = xDocument.Root.Elements("Canned").ToList();
                foreach (var elem in xElements)
                {
                    var cannedComp = new Dictionary<int, int>();
                    foreach (var component in
                        elem.Element("CannedComponents").Elements("CannedComponent").ToList())
                    {
                        cannedComp.Add(Convert.ToInt32(component.Element("Key").Value),
                            Convert.ToInt32(component.Element("Value").Value));
                    }
                    list.Add(new Canned
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        CannedName = elem.Element("CannedName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value),
                        CannedComponents = cannedComp
                    });
                }
            }
            return list;
        }
        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");
                foreach (var component in Components)
                {
                    xElement.Add(new XElement("Component",
                        new XAttribute("Id", component.Id),
                        new XElement("ComponentName", component.ComponentName)));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(ComponentFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");
                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                        new XAttribute("Id", order.Id),
                        new XElement("CannedId", order.CannedId),
                        new XElement("Count", order.Count),
                        new XElement("Sum", order.Sum),
                        new XElement("Status", order.Status),
                        new XElement("DateCreate", order.DateCreate),
                        new XElement("DateImplement", order.DateImplement)));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveCanneds()
        {
            if (Canneds != null)
            {
                var xElement = new XElement("Canneds");
                foreach (var canned in Canneds)
                {
                    var compElement = new XElement("CannedComponents");
                    foreach (var component in canned.CannedComponents)
                    {
                        compElement.Add(new XElement("CannedComponent",
                            new XElement("Key", component.Key),
                            new XElement("Value", component.Value)));
                    }
                    xElement.Add(new XElement("Canned",
                        new XAttribute("Id", canned.Id),
                        new XElement("CannedName", canned.CannedName),
                        new XElement("Price", canned.Price),
                        compElement));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(CannedFileName);
            }
        }
    }
}