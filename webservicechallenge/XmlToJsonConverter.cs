// <copyright file="XmlToJsonConverter.cs" company="Made by ME">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebServiceChallenge
{
    using System.Xml;
    using Newtonsoft.Json;

    public static class XmlToJsonConverter
    {
        /// <summary>XMLs to json.</summary>
        /// <param name="xmlString">The XML string.</param>
        /// <returns>the JSON result.</returns>
        public static string XmlToJson(string xmlString)
        {
            string json;
            try
            {
                var doc = new XmlDocument();

                doc.LoadXml(xmlString);

                foreach (XmlElement el in doc.SelectNodes(".//*"))
                {
                    el.Attributes.RemoveAll();
                }

                json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            }
            catch (System.Exception)
            {
                json = "Bad Xml format";
            }

            return json;
        }

    }
}