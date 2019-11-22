﻿using Newtonsoft.Json;
using System.Xml;

namespace webservice_challenge
{
    public class XmlToJsonConverter
    {
        public string XmlToJson(string xmlString)
        {
            xmlString = @"<?xml version='1.0' standalone='no'?>
                    <root>
                      <person id='1'>
                      <name>Alan</name>
                      <url>http://www.google.com</url>
                      </person>
                      <person id='2'>
                      <name>Louis</name>
                      <url>http://www.yahoo.com</url>
                      </person>
                    </root>";

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xmlString);

            string json = JsonConvert.SerializeXmlNode(doc);

            return json;

        }
    }
}