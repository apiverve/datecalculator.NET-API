using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class start
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("day")]
    public string day { get; set; }

    [JsonProperty("month")]
    public string month { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("words")]
    public string words { get; set; }

}

public class end
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("day")]
    public string day { get; set; }

    [JsonProperty("month")]
    public string month { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("words")]
    public string words { get; set; }

}

public class data
{
    [JsonProperty("minutes")]
    public int minutes { get; set; }

    [JsonProperty("hours")]
    public int hours { get; set; }

    [JsonProperty("days")]
    public int days { get; set; }

    [JsonProperty("weeks")]
    public int weeks { get; set; }

    [JsonProperty("months")]
    public int months { get; set; }

    [JsonProperty("years")]
    public int years { get; set; }

    [JsonProperty("start")]
    public start start { get; set; }

    [JsonProperty("end")]
    public end end { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
