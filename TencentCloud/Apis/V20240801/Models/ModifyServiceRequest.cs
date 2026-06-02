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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>里约应用ID</p>
        /// </summary>
        [JsonProperty("PaasID")]
        [System.Obsolete]
        public string PaasID{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("LabelIDs")]
        public string[] LabelIDs{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// </summary>
        [JsonProperty("CategoryIDs")]
        public string[] CategoryIDs{ get; set; }

        /// <summary>
        /// <p>鉴权方式</p>
        /// </summary>
        [JsonProperty("AuthType")]
        [System.Obsolete]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>签名</p>
        /// </summary>
        [JsonProperty("SignType")]
        [System.Obsolete]
        public string SignType{ get; set; }

        /// <summary>
        /// <p>登录方式</p>
        /// </summary>
        [JsonProperty("LoginTypes")]
        [System.Obsolete]
        public string[] LoginTypes{ get; set; }

        /// <summary>
        /// <p>负载方式</p>
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// <p>公开路径</p>
        /// </summary>
        [JsonProperty("PubPath")]
        public string PubPath{ get; set; }

        /// <summary>
        /// <p>请求方法</p>
        /// </summary>
        [JsonProperty("RequestMethod")]
        public string RequestMethod{ get; set; }

        /// <summary>
        /// <p>是否https</p>
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// <p>证书检查</p>
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// <p>http协议类型</p>
        /// </summary>
        [JsonProperty("HttpProtocolVersion")]
        public string HttpProtocolVersion{ get; set; }

        /// <summary>
        /// <p>版本号</p>
        /// </summary>
        [JsonProperty("Versions")]
        public VersionDTO[] Versions{ get; set; }

        /// <summary>
        /// <p>目标路径</p>
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// <p>入参</p>
        /// </summary>
        [JsonProperty("RequestParamsValidatorStatus")]
        public bool? RequestParamsValidatorStatus{ get; set; }

        /// <summary>
        /// <p>入参</p>
        /// </summary>
        [JsonProperty("RequestParamsValidatorJsonInfoT")]
        public string RequestParamsValidatorJsonInfoT{ get; set; }

        /// <summary>
        /// <p>出参</p>
        /// </summary>
        [JsonProperty("ResponseParamsValidatorStatus")]
        public bool? ResponseParamsValidatorStatus{ get; set; }

        /// <summary>
        /// <p>出参</p>
        /// </summary>
        [JsonProperty("ResponseParamsValidatorJsonInfoT")]
        public string ResponseParamsValidatorJsonInfoT{ get; set; }

        /// <summary>
        /// <p>流量控制</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// <p>流量控制</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// <p>健康检查</p>
        /// </summary>
        [JsonProperty("HealthCheckStatus")]
        public bool? HealthCheckStatus{ get; set; }

        /// <summary>
        /// <p>健康检查</p>
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfigDTO HealthCheckConfig{ get; set; }

        /// <summary>
        /// <p>格式转换</p>
        /// </summary>
        [JsonProperty("SourceTypeStatus")]
        public bool? SourceTypeStatus{ get; set; }

        /// <summary>
        /// <p>格式转换</p>
        /// </summary>
        [JsonProperty("SourceTypeConfig")]
        public SourceTypeConfigDTO SourceTypeConfig{ get; set; }

        /// <summary>
        /// <p>IP白名单</p>
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// <p>IP白名单</p>
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// <p>IP黑名单</p>
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// <p>IP黑名单</p>
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// <p>插件</p>
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// <p>服务ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PaasID", this.PaasID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "LabelIDs.", this.LabelIDs);
            this.SetParamArraySimple(map, prefix + "CategoryIDs.", this.CategoryIDs);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamArraySimple(map, prefix + "LoginTypes.", this.LoginTypes);
            this.SetParamSimple(map, prefix + "TargetSelect", this.TargetSelect);
            this.SetParamSimple(map, prefix + "PubPath", this.PubPath);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "HttpProtocolType", this.HttpProtocolType);
            this.SetParamSimple(map, prefix + "CheckTargetCertsError", this.CheckTargetCertsError);
            this.SetParamSimple(map, prefix + "HttpProtocolVersion", this.HttpProtocolVersion);
            this.SetParamArrayObj(map, prefix + "Versions.", this.Versions);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamSimple(map, prefix + "RequestParamsValidatorStatus", this.RequestParamsValidatorStatus);
            this.SetParamSimple(map, prefix + "RequestParamsValidatorJsonInfoT", this.RequestParamsValidatorJsonInfoT);
            this.SetParamSimple(map, prefix + "ResponseParamsValidatorStatus", this.ResponseParamsValidatorStatus);
            this.SetParamSimple(map, prefix + "ResponseParamsValidatorJsonInfoT", this.ResponseParamsValidatorJsonInfoT);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamSimple(map, prefix + "HealthCheckStatus", this.HealthCheckStatus);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "SourceTypeStatus", this.SourceTypeStatus);
            this.SetParamObj(map, prefix + "SourceTypeConfig.", this.SourceTypeConfig);
            this.SetParamSimple(map, prefix + "IpWhiteStatus", this.IpWhiteStatus);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "IpBlackStatus", this.IpBlackStatus);
            this.SetParamArraySimple(map, prefix + "IpBlackList.", this.IpBlackList);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

