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

    public class CreateMcpServerRequest : AbstractModel
    {
        
        /// <summary>
        /// 模式：proxy代理模式； wrap封装模式；
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 版本号：2024-11-05 2025-03-26
        /// </summary>
        [JsonProperty("McpVersion")]
        public string McpVersion{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 封装服务列表
        /// </summary>
        [JsonProperty("WrapServices")]
        public string[] WrapServices{ get; set; }

        /// <summary>
        /// 负载方式，robin random consistentHash
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// 目标服务器
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// 后端协议：http https
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// 证书检查
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// 目标路径
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// 流量控制开启状态
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// 流量控制配置
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// IP白名单开启状态
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// IP白名单配置
        /// </summary>
        [JsonProperty("IpWhiteConfig")]
        public IpConfig IpWhiteConfig{ get; set; }

        /// <summary>
        /// IP黑名单开启状态
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// IP黑名单配置
        /// </summary>
        [JsonProperty("IpBlackConfig")]
        public IpConfig IpBlackConfig{ get; set; }

        /// <summary>
        /// 自定义host
        /// </summary>
        [JsonProperty("CustomHttpHost")]
        public string CustomHttpHost{ get; set; }

        /// <summary>
        /// Http 请求host类型：useRequestHost 保持源请求；host targetHost 修正为源站host；  customHost 自定义host
        /// </summary>
        [JsonProperty("HttpHostType")]
        public string HttpHostType{ get; set; }

        /// <summary>
        /// 请求的超时时间
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 安全规则集
        /// </summary>
        [JsonProperty("McpSecurityRules")]
        public McpSecurityRule[] McpSecurityRules{ get; set; }

        /// <summary>
        /// 工具集配置（openapi时或许用的是）
        /// </summary>
        [JsonProperty("ToolConfigs")]
        public ToolConfigDTO[] ToolConfigs{ get; set; }

        /// <summary>
        /// 封装的API分组ID
        /// </summary>
        [JsonProperty("WrapPaasID")]
        public string WrapPaasID{ get; set; }

        /// <summary>
        /// 插件配置
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "McpVersion", this.McpVersion);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "WrapServices.", this.WrapServices);
            this.SetParamSimple(map, prefix + "TargetSelect", this.TargetSelect);
            this.SetParamArrayObj(map, prefix + "TargetHosts.", this.TargetHosts);
            this.SetParamSimple(map, prefix + "HttpProtocolType", this.HttpProtocolType);
            this.SetParamSimple(map, prefix + "CheckTargetCertsError", this.CheckTargetCertsError);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamSimple(map, prefix + "IpWhiteStatus", this.IpWhiteStatus);
            this.SetParamObj(map, prefix + "IpWhiteConfig.", this.IpWhiteConfig);
            this.SetParamSimple(map, prefix + "IpBlackStatus", this.IpBlackStatus);
            this.SetParamObj(map, prefix + "IpBlackConfig.", this.IpBlackConfig);
            this.SetParamSimple(map, prefix + "CustomHttpHost", this.CustomHttpHost);
            this.SetParamSimple(map, prefix + "HttpHostType", this.HttpHostType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArrayObj(map, prefix + "McpSecurityRules.", this.McpSecurityRules);
            this.SetParamArrayObj(map, prefix + "ToolConfigs.", this.ToolConfigs);
            this.SetParamSimple(map, prefix + "WrapPaasID", this.WrapPaasID);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
        }
    }
}

