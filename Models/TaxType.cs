using System.Text.Json.Serialization;

namespace small_business_management_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaxType
    {
        SalesTax,
        IncomeTax
    }
}