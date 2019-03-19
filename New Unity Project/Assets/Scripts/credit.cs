using System.Collections;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class credit : MonoBehaviour
{
    // Start is called before the first frame update
    [XmlAttribute("name")]
    public string name;

    [XmlAttribute("killed")]
    public float killed;

}
