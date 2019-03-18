using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using System;


public class creditreader
{
    // Start is called before the first frame update

    public List<credit> credits = new List<credit>();

    public string path = "Assets/XMLFiles/Credits.xml";
    public string finalp = "Assets/XMLFiles/finalCredits.xml";
    private ArrayList names = new ArrayList();
    private ArrayList killed = new ArrayList();

     public void read()
    {
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;
        XmlReader reader = XmlReader.Create(finalp, settings);
        string element = "", value = "";

        reader.MoveToContent();
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    element = reader.Name;
                    break;
                case XmlNodeType.Text:
                    value = reader.Value;
                    break;

            }

            if (element == "name")
            {
                if (value != "")
                {
                    names.Add(value);
                    value = "";
                    element = "";
                }
            }

            if (element == "killed")
            {
                if (value != "")
                {
                    killed.Add(Convert.ToBoolean(value));
                    value = "";
                    element = "";
                }
            }


        }
        foreach (string name in names)
        {
            Debug.Log(name);
        }
        foreach (bool kill in killed)
        {
            Debug.Log(kill);
        }

    }

    public void write(string changename)
    {
        XmlDocument doc = new XmlDocument();
        XmlWriter tw = new XmlTextWriter(finalp, null);
        doc.Load(path);

        XPathNavigator navigator = doc.CreateNavigator();
        int counter = 0;
        foreach (var name in names)
        {
            navigator.MoveToChild("CreditsList", string.Empty);
            navigator.MoveToChild("credits", string.Empty);

            navigator.MoveToChild("credit", name.ToString());

            navigator.MoveToChild("killed", name.ToString());


            navigator.SetValue(killed[counter].ToString());
            navigator.MoveToParent();

            navigator.MoveToRoot();
            counter++;
        }


        Debug.Log(navigator.OuterXml);
        navigator.MoveToRoot();
        doc.Save(tw);

    }

    public void updateDoc()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(finalp);
    }

}
