/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class ModifyApiRequest : AbstractModel
    {
        
        /// <summary>
        /// API 所在的服务唯一 ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API 的后端服务类型。支持HTTP、MOCK、TSF、CLB、SCF、WEBSOCKET、TARGET（内测）。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 请求的前端配置。
        /// </summary>
        [JsonProperty("RequestConfig")]
        public RequestConfig RequestConfig{ get; set; }

        /// <summary>
        /// API 接口唯一 ID。
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// 用户自定义的 API 名称。
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// 用户自定义的 API 接口描述。
        /// </summary>
        [JsonProperty("ApiDesc")]
        public string ApiDesc{ get; set; }

        /// <summary>
        /// API 类型，支持NORMAL和TSF，默认为NORMAL。
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// API 鉴权类型。支持SECRET、NONE、OAUTH、APP。默认为NONE。
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 是否需要签名认证，True 表示需要，False 表示不需要。待废弃。
        /// </summary>
        [JsonProperty("AuthRequired")]
        public bool? AuthRequired{ get; set; }

        /// <summary>
        /// API 的后端服务超时时间，单位是秒。
        /// </summary>
        [JsonProperty("ServiceTimeout")]
        public long? ServiceTimeout{ get; set; }

        /// <summary>
        /// API 的前端请求类型，如 HTTP 或 HTTPS 或者 HTTP 和 HTTPS。修改api时推荐必填
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 是否需要开启跨域，Ture 表示需要，False 表示不需要。
        /// </summary>
        [JsonProperty("EnableCORS")]
        public bool? EnableCORS{ get; set; }

        /// <summary>
        /// 常量参数。
        /// </summary>
        [JsonProperty("ConstantParameters")]
        public ConstantParameter[] ConstantParameters{ get; set; }

        /// <summary>
        /// 前端请求参数。
        /// </summary>
        [JsonProperty("RequestParameters")]
        public ReqParameter[] RequestParameters{ get; set; }

        /// <summary>
        /// 当AuthType 为 OAUTH时，该字段有效， NORMAL：业务api   OAUTH：授权API。
        /// </summary>
        [JsonProperty("ApiBusinessType")]
        public string ApiBusinessType{ get; set; }

        /// <summary>
        /// API 的后端 Mock 返回信息。如果 ServiceType 是 Mock，则此参数必传。
        /// </summary>
        [JsonProperty("ServiceMockReturnMessage")]
        public string ServiceMockReturnMessage{ get; set; }

        /// <summary>
        /// API绑定微服务列表。
        /// </summary>
        [JsonProperty("MicroServices")]
        public MicroServiceReq[] MicroServices{ get; set; }

        /// <summary>
        /// 微服务的负载均衡配置。
        /// </summary>
        [JsonProperty("ServiceTsfLoadBalanceConf")]
        public TsfLoadBalanceConfResp ServiceTsfLoadBalanceConf{ get; set; }

        /// <summary>
        /// 微服务的健康检查配置。
        /// </summary>
        [JsonProperty("ServiceTsfHealthCheckConf")]
        public HealthCheckConf ServiceTsfHealthCheckConf{ get; set; }

        /// <summary>
        /// target类型负载均衡配置。（内测阶段）
        /// </summary>
        [JsonProperty("TargetServicesLoadBalanceConf")]
        public long? TargetServicesLoadBalanceConf{ get; set; }

        /// <summary>
        /// target健康检查配置。（内测阶段）
        /// </summary>
        [JsonProperty("TargetServicesHealthCheckConf")]
        public HealthCheckConf TargetServicesHealthCheckConf{ get; set; }

        /// <summary>
        /// scf 函数名称。当后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceScfFunctionName")]
        public string ServiceScfFunctionName{ get; set; }

        /// <summary>
        /// scf websocket注册函数。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionName")]
        public string ServiceWebsocketRegisterFunctionName{ get; set; }

        /// <summary>
        /// scf websocket清理函数。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionName")]
        public string ServiceWebsocketCleanupFunctionName{ get; set; }

        /// <summary>
        /// scf websocket传输函数。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionName")]
        public string ServiceWebsocketTransportFunctionName{ get; set; }

        /// <summary>
        /// scf 函数命名空间。当后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceScfFunctionNamespace")]
        public string ServiceScfFunctionNamespace{ get; set; }

        /// <summary>
        /// scf函数版本。当后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceScfFunctionQualifier")]
        public string ServiceScfFunctionQualifier{ get; set; }

        /// <summary>
        /// scf websocket注册函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionNamespace")]
        public string ServiceWebsocketRegisterFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket传输函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketRegisterFunctionQualifier")]
        public string ServiceWebsocketRegisterFunctionQualifier{ get; set; }

        /// <summary>
        /// scf websocket传输函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionNamespace")]
        public string ServiceWebsocketTransportFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket传输函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketTransportFunctionQualifier")]
        public string ServiceWebsocketTransportFunctionQualifier{ get; set; }

        /// <summary>
        /// scf websocket清理函数命名空间。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionNamespace")]
        public string ServiceWebsocketCleanupFunctionNamespace{ get; set; }

        /// <summary>
        /// scf websocket清理函数版本。当前端类型是WEBSOCKET且后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceWebsocketCleanupFunctionQualifier")]
        public string ServiceWebsocketCleanupFunctionQualifier{ get; set; }

        /// <summary>
        /// 是否开启响应集成。当后端类型是SCF时生效。
        /// </summary>
        [JsonProperty("ServiceScfIsIntegratedResponse")]
        public bool? ServiceScfIsIntegratedResponse{ get; set; }

        /// <summary>
        /// 开始调试后计费。（云市场预留字段）
        /// </summary>
        [JsonProperty("IsDebugAfterCharge")]
        public bool? IsDebugAfterCharge{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public Tag TagSpecifications{ get; set; }

        /// <summary>
        /// 是否删除自定义响应配置错误码，如果不传或者传 False，不删除，当传 True 时，则删除此 API 所有自定义响应配置错误码。
        /// </summary>
        [JsonProperty("IsDeleteResponseErrorCodes")]
        public bool? IsDeleteResponseErrorCodes{ get; set; }

        /// <summary>
        /// 返回类型。
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 自定义响应配置成功响应示例。
        /// </summary>
        [JsonProperty("ResponseSuccessExample")]
        public string ResponseSuccessExample{ get; set; }

        /// <summary>
        /// 自定义响应配置失败响应示例。
        /// </summary>
        [JsonProperty("ResponseFailExample")]
        public string ResponseFailExample{ get; set; }

        /// <summary>
        /// API 的后端服务配置。
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public ServiceConfig ServiceConfig{ get; set; }

        /// <summary>
        /// 关联的授权API 唯一 ID，当AuthType为OAUTH且ApiBusinessType为NORMAL时生效。标示业务API绑定的oauth2.0授权API唯一ID。
        /// </summary>
        [JsonProperty("AuthRelationApiId")]
        public string AuthRelationApiId{ get; set; }

        /// <summary>
        /// API的后端服务参数。
        /// </summary>
        [JsonProperty("ServiceParameters")]
        public ServiceParameter[] ServiceParameters{ get; set; }

        /// <summary>
        /// oauth配置。当AuthType是OAUTH时生效。
        /// </summary>
        [JsonProperty("OauthConfig")]
        public OauthConfig OauthConfig{ get; set; }

        /// <summary>
        /// 用户自定义错误码配置。
        /// </summary>
        [JsonProperty("ResponseErrorCodes")]
        public ResponseErrorCodeReq[] ResponseErrorCodes{ get; set; }

        /// <summary>
        /// 是否开启Base64编码，只有后端为scf时才会生效。
        /// </summary>
        [JsonProperty("IsBase64Encoded")]
        public bool? IsBase64Encoded{ get; set; }

        /// <summary>
        /// 是否开启Base64编码的header触发，只有后端为scf时才会生效。
        /// </summary>
        [JsonProperty("IsBase64Trigger")]
        public bool? IsBase64Trigger{ get; set; }

        /// <summary>
        /// Header触发规则，总规则数不能超过10。
        /// </summary>
        [JsonProperty("Base64EncodedTriggerRules")]
        public Base64EncodedTriggerRule[] Base64EncodedTriggerRules{ get; set; }

        /// <summary>
        /// 事件总线ID。
        /// </summary>
        [JsonProperty("EventBusId")]
        public string EventBusId{ get; set; }

        /// <summary>
        /// scf函数类型。当后端类型是SCF时生效。支持事件触发(EVENT)，http直通云函数(HTTP)。
        /// </summary>
        [JsonProperty("ServiceScfFunctionType")]
        public string ServiceScfFunctionType{ get; set; }

        /// <summary>
        /// 是否开启SCF Event异步调用。
        /// </summary>
        [JsonProperty("ServiceScfEventIsAsyncCall")]
        public bool? ServiceScfEventIsAsyncCall{ get; set; }

        /// <summary>
        /// EIAM应用类型。
        /// </summary>
        [JsonProperty("EIAMAppType")]
        public string EIAMAppType{ get; set; }

        /// <summary>
        /// EIAM应用认证类型，支持仅认证（AuthenticationOnly）、认证和鉴权（Authorization）。
        /// </summary>
        [JsonProperty("EIAMAuthType")]
        public string EIAMAuthType{ get; set; }

        /// <summary>
        /// EIAM应用Token 有效时间，单位为秒，默认为7200秒。
        /// </summary>
        [JsonProperty("EIAMAppId")]
        public string EIAMAppId{ get; set; }

        /// <summary>
        /// EIAM应用ID。
        /// </summary>
        [JsonProperty("TokenTimeout")]
        public long? TokenTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "RequestConfig.", this.RequestConfig);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "ApiDesc", this.ApiDesc);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthRequired", this.AuthRequired);
            this.SetParamSimple(map, prefix + "ServiceTimeout", this.ServiceTimeout);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "EnableCORS", this.EnableCORS);
            this.SetParamArrayObj(map, prefix + "ConstantParameters.", this.ConstantParameters);
            this.SetParamArrayObj(map, prefix + "RequestParameters.", this.RequestParameters);
            this.SetParamSimple(map, prefix + "ApiBusinessType", this.ApiBusinessType);
            this.SetParamSimple(map, prefix + "ServiceMockReturnMessage", this.ServiceMockReturnMessage);
            this.SetParamArrayObj(map, prefix + "MicroServices.", this.MicroServices);
            this.SetParamObj(map, prefix + "ServiceTsfLoadBalanceConf.", this.ServiceTsfLoadBalanceConf);
            this.SetParamObj(map, prefix + "ServiceTsfHealthCheckConf.", this.ServiceTsfHealthCheckConf);
            this.SetParamSimple(map, prefix + "TargetServicesLoadBalanceConf", this.TargetServicesLoadBalanceConf);
            this.SetParamObj(map, prefix + "TargetServicesHealthCheckConf.", this.TargetServicesHealthCheckConf);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionName", this.ServiceScfFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionName", this.ServiceWebsocketRegisterFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionName", this.ServiceWebsocketCleanupFunctionName);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionName", this.ServiceWebsocketTransportFunctionName);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionNamespace", this.ServiceScfFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionQualifier", this.ServiceScfFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionNamespace", this.ServiceWebsocketRegisterFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketRegisterFunctionQualifier", this.ServiceWebsocketRegisterFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionNamespace", this.ServiceWebsocketTransportFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketTransportFunctionQualifier", this.ServiceWebsocketTransportFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionNamespace", this.ServiceWebsocketCleanupFunctionNamespace);
            this.SetParamSimple(map, prefix + "ServiceWebsocketCleanupFunctionQualifier", this.ServiceWebsocketCleanupFunctionQualifier);
            this.SetParamSimple(map, prefix + "ServiceScfIsIntegratedResponse", this.ServiceScfIsIntegratedResponse);
            this.SetParamSimple(map, prefix + "IsDebugAfterCharge", this.IsDebugAfterCharge);
            this.SetParamObj(map, prefix + "TagSpecifications.", this.TagSpecifications);
            this.SetParamSimple(map, prefix + "IsDeleteResponseErrorCodes", this.IsDeleteResponseErrorCodes);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseSuccessExample", this.ResponseSuccessExample);
            this.SetParamSimple(map, prefix + "ResponseFailExample", this.ResponseFailExample);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamSimple(map, prefix + "AuthRelationApiId", this.AuthRelationApiId);
            this.SetParamArrayObj(map, prefix + "ServiceParameters.", this.ServiceParameters);
            this.SetParamObj(map, prefix + "OauthConfig.", this.OauthConfig);
            this.SetParamArrayObj(map, prefix + "ResponseErrorCodes.", this.ResponseErrorCodes);
            this.SetParamSimple(map, prefix + "IsBase64Encoded", this.IsBase64Encoded);
            this.SetParamSimple(map, prefix + "IsBase64Trigger", this.IsBase64Trigger);
            this.SetParamArrayObj(map, prefix + "Base64EncodedTriggerRules.", this.Base64EncodedTriggerRules);
            this.SetParamSimple(map, prefix + "EventBusId", this.EventBusId);
            this.SetParamSimple(map, prefix + "ServiceScfFunctionType", this.ServiceScfFunctionType);
            this.SetParamSimple(map, prefix + "ServiceScfEventIsAsyncCall", this.ServiceScfEventIsAsyncCall);
            this.SetParamSimple(map, prefix + "EIAMAppType", this.EIAMAppType);
            this.SetParamSimple(map, prefix + "EIAMAuthType", this.EIAMAuthType);
            this.SetParamSimple(map, prefix + "EIAMAppId", this.EIAMAppId);
            this.SetParamSimple(map, prefix + "TokenTimeout", this.TokenTimeout);
        }
    }
}

