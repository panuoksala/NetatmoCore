// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NATimeTableItem
    {
        /// <summary>
        /// Initializes a new instance of the NATimeTableItem class.
        /// </summary>
        public NATimeTableItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NATimeTableItem class.
        /// </summary>
        public NATimeTableItem(int? id = default(int?), int? mOffset = default(int?))
        {
            Id = id;
            MOffset = mOffset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_offset")]
        public int? MOffset { get; set; }

    }
}
