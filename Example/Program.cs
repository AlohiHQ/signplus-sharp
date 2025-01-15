using Alohi.Signplus;
using Alohi.Signplus.Config;
using Environment = Alohi.Signplus.Http.Environment;

var config = new SignplusConfig
{
    Environment = Environment.Default,
    AccessToken = "YOUR_ACCESS_TOKEN",
};

var client = new SignplusClient(config);

var response = await client.Signplus.GetEnvelopeAsync("envelope_id");

Console.WriteLine(response);
