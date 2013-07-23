using System.Runtime.Serialization;

namespace TeenPatti.DataContracts
{
    [KnownType(typeof(SecretAnswerCredentials))]
    [KnownType(typeof(UsernamePasswordCredentials))]
    [KnownType(typeof(TokenCredentials))]
    [DataContract]
    public abstract class Credentials
    {
    }
}