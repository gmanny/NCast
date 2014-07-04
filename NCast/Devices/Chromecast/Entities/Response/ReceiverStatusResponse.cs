﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace NCast.Devices.Chromecast.Entities.Response
{
    
 //------------------------------------------------------------------------------
 // <auto-generated>
 //     This code was generated by a tool.
 //     Runtime Version:4.0.30319.19455
 //
 //     Changes to this file may cause incorrect behavior and will be lost if
 //     the code is regenerated.
 // </auto-generated>
 //------------------------------------------------------------------------------



    [DataContract()]
    public partial class ReceiverStatusResponse
    {

        [DataMember()]
        public int requestId;

        [DataMember()]
        public Status status;

        [DataMember()]
        public string type;
    }

    [DataContract(Name = "status")]
    public partial class Status
    {
        [DataMember()]
        public ApplicationStatus[] applications;

        [DataMember()]
        public bool isActiveInput;

        [DataMember()]
        public Volume volume;
    }

    [DataContract(Name = "applications")]
    public partial class ApplicationStatus
    {

        [DataMember()]
        public string appId;

        [DataMember()]
        public string displayName;

        [DataMember()]
        public string[] namespaces;

        [DataMember()]
        public string sessionId;

        [DataMember()]
        public string statusText;

        [DataMember()]
        public string transportId;
    }

    [DataContract(Name = "volume")]
    public partial class Volume
    {

        [DataMember()]
        public int level;

        [DataMember()]
        public bool muted;
    }

}