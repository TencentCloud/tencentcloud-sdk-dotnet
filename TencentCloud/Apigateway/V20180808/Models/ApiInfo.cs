/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiInfo : AbstractModel
    {
        
        /// <summary>
        /// API 所在的服务唯一 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API 所在的服务的名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// API 所在的服务的描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// API 接口唯一 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// API 接口的描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiDesc")]
        public string ApiDesc{ get; set; }

        /// <summary>
        /// 创建时间，按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最后修改时间，按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// API 接口的名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// API 类型。可取值为NORMAL（普通API）、TSF（微服务API）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// API 的前端请求类型，如 HTTP 或 HTTPS 或者 HTTP 和 HTTPS。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// API 鉴权类型。可取值为 SECRET（密钥对鉴权）、NONE（免鉴权）、OAUTH。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// OAUTH API的类型。可取值为NORMAL（业务API）、OAUTH（授权API）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// OAUTH 业务API 关联的授权API 唯一 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// OAUTH配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// 是否购买后调试（云市场预留参数）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// 请求的前端配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestConfig")]
        public RequestConfig RequestConfig{ get; set; }

        /// <summary>
        /// 返回类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 自定义响应配置成功响应示例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseSuccessExample")]
        public string ResponseSuccessExample{ get; set; }

        /// <summary>
        /// 自定义响应配置失败响应示例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseFailExample")]
        public string ResponseFailExample{ get; set; }

        /// <summary>
        /// 用户自定义错误码配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseErrorCodes")]
        public ErrorCodes[] ResponseErrorCodes{ get; set; }

        /// <summary>
        /// 前端请求参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParameters")]
        public ReqParameter[] RequestParameters{ get; set; }

        /// <summary>
        /// API 的后端服务超时时间，单位是秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTimeout")]
        public long? ServiceTimeout{ get; set; }

        /// <summary>
        /// API 的后端服务类型。可取值为 HTTP、MOCK、TSF、CLB、SCF、WEBSOCKET、TARGET（内测）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// API 的后端服务配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public ServiceConfig ServiceConfig{ get; set; }

        /// <summary>
        /// API的后端服务参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceParameters")]
        public DescribeApiResultServiceParametersInfo[] ServiceParameters{ get; set; }

        /// <summary>
        /// 常量参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConstantParameters")]
        public ConstantParameter[] ConstantParameters{ get; set; }

        /// <summary>
        /// API 的后端 Mock 返回信息。如果 ServiceType 是 Mock，则此参数必传。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceMockReturnMessage")]
        public string ServiceMockReturnMessage{ get; set; }

        /// <summary>
        /// scf 函数名称。当后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceScfFunctionName")]
        public string ServiceScfFunctionName{ get; set; }

        /// <summary>
        /// scf 函数命名空间。当后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceScfFunctionNamespace")]
        public string ServiceScfFunctionNamespace{ get; set; }

        /// <summary>
        /// scf函数版本。当后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceScfFunctionQualifier")]
        public string ServiceScfFunctionQualifier{ get; set; }

        /// <summary>
        /// 是否开启集成响应。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceScfIsIntegratedResponse")]
        public bool? ServiceScfIsIntegratedResponse{ get; set; }

        /// <summary>
        /// scf websocket注册函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionName")]
        public string ServiceWebsocketRegisterFunctionName{ get; set; }

        /// <summary>
        /// scf websocket注册函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionNamespace")]
        public string ServiceWebsocketRegisterFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket传输函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionQualifier")]
        public string ServiceWebsocketRegisterFunctionQualifier{ get; set; }

        /// <summary>
        /// scf websocket清理函数。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionName")]
        public string ServiceWebsocketCleanupFunctionName{ get; set; }

        /// <summary>
        /// scf websocket清理函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionNamespace")]
        public string ServiceWebsocketCleanupFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket清理函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionQualifier")]
        public string ServiceWebsocketCleanupFunctionQualifier{ get; set; }

        /// <summary>
        /// WEBSOCKET 回推地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalDomain")]
        public string InternalDomain{ get; set; }

        /// <summary>
        /// scf websocket传输函数。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionName")]
        public string ServiceWebsocketTransportFunctionName{ get; set; }

        /// <summary>
        /// scf websocket传输函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionNamespace")]
        public string ServiceWebsocketTransportFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket传输函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionQualifier")]
        public string ServiceWebsocketTransportFunctionQualifier{ get; set; }

        /// <summary>
        /// API绑定微服务服务列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroServices")]
        public MicroService[] MicroServices{ get; set; }

        /// <summary>
        /// 微服务信息详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MicroServicesInfo")]
        public long?[] MicroServicesInfo{ get; set; }

        /// <summary>
        /// 微服务的负载均衡配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTsfLoadBalanceConf")]
        public TsfLoadBalanceConfResp ServiceTsfLoadBalanceConf{ get; set; }

        /// <summary>
        /// 微服务的健康检查配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTsfHealthCheckConf")]
        public HealthCheckConf ServiceTsfHealthCheckConf{ get; set; }

        /// <summary>
        /// 是否开启跨域。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableCORS")]
        public bool? EnableCORS{ get; set; }

        /// <summary>
        /// API绑定的tag信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// API已发布的环境信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Environments")]
        public string[] Environments{ get; set; }

        /// <summary>
        /// 是否开启Base64编码，只有后端为scf时才会生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsBase64Encoded")]
        public bool? IsBase64Encoded{ get; set; }

        /// <summary>
        /// 是否开启Base64编码的header触发，只有后端为scf时才会生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsBase64Trigger")]
        public bool? IsBase64Trigger{ get; set; }

        /// <summary>
        /// Header触发规则，总规则数量不超过10。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Base64EncodedTriggerRules")]
        public Base64EncodedTriggerRule[] Base64EncodedTriggerRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiDesc", this.ApiDesc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ApiBusinessType", this.ApiBusinessType);
            this.SetParamSimple(map, prefix + "AuthRelationApiId", this.AuthRelationApiId);
            this.SetParamObj(map, prefix + "OauthConfig.", this.OauthConfig);
            this.SetParamSimple(map, prefix + "IsDebugAfterCharge", this.IsDebugAfterCharge);
            this.SetParamObj(map, prefix + "RequestConfig.", this.RequestConfig);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseSuccessExample", this.ResponseSuccessExample);
            this.SetParamSimple(map, prefix + "ResponseFailExample", this.ResponseFailExample);
            this.SetParamArrayObj(map, prefix + "ResponseErrorCodes.", this.ResponseErrorCodes);
            this.SetParamArrayObj(map, prefix + "RequestParameters.", this.RequestParameters);
            this.SetParamSimple(map, prefix + "ServiceTimeout", this.ServiceTimeout);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamArrayObj(map, prefix + "ServiceParameters.", this.ServiceParameters);
            this.SetParamArrayObj(map, prefix + "ConstantParameters.", this.ConstantParameters);
            this.SetParamSimple(map, prefix + "ServiceMockReturnMessage", this.ServiceMockReturnMessage);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionName", this.ServiceScfFunctionName);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionNamespace", this.ServiceScfFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionQualifier", this.ServiceScfFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceScfIsIntegratedResponse", this.ServiceScfIsIntegratedResponse);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionName", this.ServiceWebsocketRegisterFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionNamespace", this.ServiceWebsocketRegisterFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionQualifier", this.ServiceWebsocketRegisterFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionName", this.ServiceWebsocketCleanupFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionNamespace", this.ServiceWebsocketCleanupFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionQualifier", this.ServiceWebsocketCleanupFunctionQualifier);
            this.SetParamSimple(map, prefix + "InternalDomain", this.InternalDomain);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionName", this.ServiceWebsocketTransportFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionNamespace", this.ServiceWebsocketTransportFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionQualifier", this.ServiceWebsocketTransportFunctionQualifier);
            this.SetParamArrayObj(map, prefix + "MicroServices.", this.MicroServices);
            this.SetParamArraySimple(map, prefix + "MicroServicesInfo.", this.MicroServicesInfo);
            this.SetParamObj(map, prefix + "ServiceTsfLoadBalanceConf.", this.ServiceTsfLoadBalanceConf);
            this.SetParamObj(map, prefix + "ServiceTsfHealthCheckConf.", this.ServiceTsfHealthCheckConf);
            this.SetParamSimple(map, prefix + "EnableCORS", this.EnableCORS);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Environments.", this.Environments);
            this.SetParamSimple(map, prefix + "IsBase64Encoded", this.IsBase64Encoded);
            this.SetParamSimple(map, prefix + "IsBase64Trigger", this.IsBase64Trigger);
            this.SetParamArrayObj(map, prefix + "Base64EncodedTriggerRules.", this.Base64EncodedTriggerRules);
        }
    }
}

