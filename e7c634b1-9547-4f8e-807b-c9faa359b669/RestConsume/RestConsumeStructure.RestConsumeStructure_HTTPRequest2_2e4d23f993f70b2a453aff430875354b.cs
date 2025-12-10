using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public class RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("BaseURL")]
public string ssBaseURL;
[JsonProperty("URLPath")]
public string ssURLPath;
[JsonProperty("URLQueryParameters")]
public RestConsumeStructure_URLQueryParameter_67c9532b700300cd02996c0d658856f8[] ssURLQueryParameters;
[JsonProperty("HTTPMethod")]
public string ssHTTPMethod;
[JsonProperty("Headers")]
public RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e[] ssHeaders;
[JsonProperty("RequestText")]
public string ssRequestText;
[JsonProperty("RequestBinary")]
public byte[] ssRequestBinary;

        
    public RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b() { }

    public RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b(ST_2e4d23f993f70b2a453aff430875354bStructure structure) {
        this.ssBaseURL = 
structure.ssBaseURL == "" ? null : (string)structure.ssBaseURL;
this.ssURLPath = 
structure.ssURLPath == "" ? null : (string)structure.ssURLPath;
this.ssURLQueryParameters = 
structure.ssURLQueryParameters.Length == 0 ? null : structure.ssURLQueryParameters.ToArray(RestConsumeStructure_URLQueryParameter_67c9532b700300cd02996c0d658856f8.FromStructure);
this.ssHTTPMethod = 
structure.ssHTTPMethod == "" ? null : (string)structure.ssHTTPMethod;
this.ssHeaders = 
structure.ssHeaders.Length == 0 ? null : structure.ssHeaders.ToArray(RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e.FromStructure);
this.ssRequestText = 
structure.ssRequestText == "" ? null : (string)structure.ssRequestText;
this.ssRequestBinary = 
structure.ssRequestBinary.Length == 0 ? null : structure.ssRequestBinary;

    }


    public static ST_2e4d23f993f70b2a453aff430875354bStructure ToStructure(RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b structure) {
        var result = new ST_2e4d23f993f70b2a453aff430875354bStructure ();

        if (structure is null) {
           return result;
        }

        result.ssBaseURL = 
structure.ssBaseURL == null ? "" : (string)structure.ssBaseURL;
result.ssURLPath = 
structure.ssURLPath == null ? "" : (string)structure.ssURLPath;
result.ssURLQueryParameters = 
RL_f12ccf0a92533f516726b4232e2b352e.ToList(structure.ssURLQueryParameters, RestConsumeStructure_URLQueryParameter_67c9532b700300cd02996c0d658856f8.ToStructure);
result.ssHTTPMethod = 
structure.ssHTTPMethod == null ? "" : (string)structure.ssHTTPMethod;
result.ssHeaders = 
RL_435011a192ffc5b6f97bc0a73c8501c1.ToList(structure.ssHeaders, RestConsumeStructure_HTTPHeader_b6163e36a4b633b09c820fee73ba221e.ToStructure);
result.ssRequestText = 
structure.ssRequestText == null ? "" : (string)structure.ssRequestText;
result.ssRequestBinary = 
structure.ssRequestBinary == null ? new byte[] {} : structure.ssRequestBinary;


        return result;
    }

    public static RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b FromStructure(ST_2e4d23f993f70b2a453aff430875354bStructure structure) {
        return new RestConsumeStructure_HTTPRequest2_2e4d23f993f70b2a453aff430875354b(structure)
;
    } 
}
