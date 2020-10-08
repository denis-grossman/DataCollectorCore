﻿using DataCollectorCore.DataCollectorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollectorLibrary
{
    /// <summary>
    /// Class description of the particular connection
    /// </summary>
    public class NodeModel:IGeneralNode
    {
        /// <summary>
        /// Unique Id of this particular connection
        /// </summary>
        public int NodeId { get; set; }
        /// <summary>
        /// Unique Name of this particular connection
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// Represents the status of this particular connection 
        /// if it would be active when aquisition is started
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Represents protocol would be used for this particular connection
        /// </summary>
        public string CommunicationInterface { get; set; }
        /// <summary>
        /// Represents PLC type to be used for this particular connection
        /// </summary>
        public int PlcType { get; set; }
        /// <summary>
        /// Represents list of signals of this particular connection
        /// </summary>
        public List<TagModel> Tags { get; set; } = new List<TagModel>();
    }
}
