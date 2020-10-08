using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollectorLibrary
{
    public class TagModel
    {
        /// <summary>
        /// Represents the name of this particular signal
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the comment of this particular signal
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Represents if this particular signal is boolean (digital), "false" means analog value
        /// </summary>
        public bool isBoolean { get; set; }
        /// <summary>
        /// Represents if this particular signal would be requested after aquisition start up
        /// </summary>
        public bool isActive { get; set; }
        /// <summary>
        /// Represents the Unit (e.g. V, Bar etc.) of this particular signal
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Represents the gain factor for scaling of this particular signal
        /// </summary>
        public float GainFactor { get; set; }
        /// <summary>
        /// Represents the offset of this particular signal
        /// </summary>
        public float Offset { get; set; }
        /// <summary>
        /// Represents data type (e.g. REAL, INT, WORD, BOOL etc.) of this particular signal
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// Represents hardware address of this particular signal
        /// </summary>
        public string Address { get; set; }
        
    }
}
