using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TeenPatti.DataContracts;

namespace TeenPatti.Services
{
    [ServiceContract]
    public interface IPlayer
    {
        [OperationContract]
        [WebInvoke(Method = "PUT", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json,RequestFormat = WebMessageFormat.Json, UriTemplate = "")]
        PlayerResult Create(Player player);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/{playerId}")]
        PlayerResult Get(string playerId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/{playerId}")]
        PlayerResult Update(Player player, string playerId);

        [OperationContract]
        [WebInvoke(Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/{playerId}")]
        Result Delete(string playerId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/validate?session={token}")]
        BooleanResult ValidateSession(string token);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/invalidate?session={token}")]
        Status InValidateSession(string token);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "{playerId}/secretquestion")]
        StringResult GetSecretQuestion(string playerId);
    }

    
}
