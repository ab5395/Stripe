using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripePaymentExample
{
    public class FraudDetails
    {
    }

    public class Metadata
    {
    }

    public class Refunds
    {
        public string @object { get; set; }
        public List<object> data { get; set; }
        public bool has_more { get; set; }
        public int total_count { get; set; }
        public string url { get; set; }
    }

    public class Metadata2
    {
    }

    public class Source
    {
        public string id { get; set; }
        public string @object { get; set; }
        public object address_city { get; set; }
        public object address_country { get; set; }
        public object address_line1 { get; set; }
        public object address_line1_check { get; set; }
        public object address_line2 { get; set; }
        public object address_state { get; set; }
        public object address_zip { get; set; }
        public object address_zip_check { get; set; }
        public string brand { get; set; }
        public string country { get; set; }
        public object customer { get; set; }
        public string cvc_check { get; set; }
        public object dynamic_last4 { get; set; }
        public int exp_month { get; set; }
        public int exp_year { get; set; }
        public string fingerprint { get; set; }
        public string funding { get; set; }
        public string last4 { get; set; }
        public Metadata2 metadata { get; set; }
        public string name { get; set; }
        public object tokenization_method { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string @object { get; set; }
        public int amount { get; set; }
        public int amount_refunded { get; set; }
        public object application { get; set; }
        public object application_fee { get; set; }
        public string balance_transaction { get; set; }
        public bool captured { get; set; }
        public int created { get; set; }
        public string currency { get; set; }
        public object customer { get; set; }
        public string description { get; set; }
        public object destination { get; set; }
        public object dispute { get; set; }
        public object failure_code { get; set; }
        public object failure_message { get; set; }
        public FraudDetails fraud_details { get; set; }
        public object invoice { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public object on_behalf_of { get; set; }
        public object order { get; set; }
        public object outcome { get; set; }
        public bool paid { get; set; }
        public object receipt_email { get; set; }
        public object receipt_number { get; set; }
        public bool refunded { get; set; }
        public Refunds refunds { get; set; }
        public object review { get; set; }
        public object shipping { get; set; }
        public Source source { get; set; }
        public object source_transfer { get; set; }
        public object statement_descriptor { get; set; }
        public string status { get; set; }
        public object transfer_group { get; set; }
    }
}
