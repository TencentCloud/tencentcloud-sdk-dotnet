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

    public class DescribeMcpServerResponseVO : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>标签ID数组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelIDs")]
        public string[] LabelIDs{ get; set; }

        /// <summary>
        /// <p>目录ID数组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryIDs")]
        public string[] CategoryIDs{ get; set; }

        /// <summary>
        /// <p>负载方式，robin random consistentHash</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// <p>目标服务器</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// <p>后端协议：http https</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// <p>证书检查</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// <p>目标路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// <p>流量控制状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// <p>流量控制配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// <p>IP白名单开启状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// <p>IP白名单配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteConfig")]
        public IpConfig IpWhiteConfig{ get; set; }

        /// <summary>
        /// <p>IP黑名单开启状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// <p>IP黑名单配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackConfig")]
        public IpConfig IpBlackConfig{ get; set; }

        /// <summary>
        /// <p>mcp server ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>预览地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>应用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("App")]
        public IDNameVO App{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalogs")]
        public IDNameVO[] Catalogs{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public IDNameVO[] Labels{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>用户appID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>自定义host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomHttpHost")]
        public string CustomHttpHost{ get; set; }

        /// <summary>
        /// <p>Http 请求host类型 useRequestHost 保持源请求host targetHost 修正为源站host  customHost 自定义host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpHostType")]
        public string HttpHostType{ get; set; }

        /// <summary>
        /// <p>请求的超时时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>mcp server模式</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>mcp version</p>
        /// </summary>
        [JsonProperty("McpVersion")]
        public string McpVersion{ get; set; }

        /// <summary>
        /// <p>封装模式下绑定的服务ID列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WrapServices")]
        public string[] WrapServices{ get; set; }

        /// <summary>
        /// <p>工具数量</p>
        /// </summary>
        [JsonProperty("ToolNum")]
        public long? ToolNum{ get; set; }

        /// <summary>
        /// <p>安全规则集响应</p>
        /// </summary>
        [JsonProperty("McpSecurityRulesVO")]
        public McpSecurityRulesVO[] McpSecurityRulesVO{ get; set; }

        /// <summary>
        /// <p>真实工具级别配置，实时拉取了tool/list做渲染的，如果tool/list不通，就拉不到。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ToolConfigs")]
        public ToolConfigVO[] ToolConfigs{ get; set; }

        /// <summary>
        /// <p>访问URL</p>
        /// </summary>
        [JsonProperty("UrlObj")]
        public McpUrlObj UrlObj{ get; set; }

        /// <summary>
        /// <p>后端mcp服务是否正常</p>
        /// </summary>
        [JsonProperty("ToolMessage")]
        public string ToolMessage{ get; set; }

        /// <summary>
        /// <p>后端mcp服务的工具列表</p>
        /// </summary>
        [JsonProperty("Tools")]
        public McpTool[] Tools{ get; set; }

        /// <summary>
        /// <p>封装的API分组ID</p>
        /// </summary>
        [JsonProperty("WrapPaasID")]
        public string WrapPaasID{ get; set; }

        /// <summary>
        /// <p>关联的agentApp数量</p>
        /// </summary>
        [JsonProperty("RelateAgentAppNum")]
        public long? RelateAgentAppNum{ get; set; }

        /// <summary>
        /// <p>插件配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// <p>是否忽略健康检查</p>
        /// </summary>
        [JsonProperty("IgnoreHealthCheck")]
        public bool? IgnoreHealthCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "LabelIDs.", this.LabelIDs);
            this.SetParamArraySimple(map, prefix + "CategoryIDs.", this.CategoryIDs);
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
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "App.", this.App);
            this.SetParamArrayObj(map, prefix + "Catalogs.", this.Catalogs);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CustomHttpHost", this.CustomHttpHost);
            this.SetParamSimple(map, prefix + "HttpHostType", this.HttpHostType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "McpVersion", this.McpVersion);
            this.SetParamArraySimple(map, prefix + "WrapServices.", this.WrapServices);
            this.SetParamSimple(map, prefix + "ToolNum", this.ToolNum);
            this.SetParamArrayObj(map, prefix + "McpSecurityRulesVO.", this.McpSecurityRulesVO);
            this.SetParamArrayObj(map, prefix + "ToolConfigs.", this.ToolConfigs);
            this.SetParamObj(map, prefix + "UrlObj.", this.UrlObj);
            this.SetParamSimple(map, prefix + "ToolMessage", this.ToolMessage);
            this.SetParamArrayObj(map, prefix + "Tools.", this.Tools);
            this.SetParamSimple(map, prefix + "WrapPaasID", this.WrapPaasID);
            this.SetParamSimple(map, prefix + "RelateAgentAppNum", this.RelateAgentAppNum);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
            this.SetParamSimple(map, prefix + "IgnoreHealthCheck", this.IgnoreHealthCheck);
        }
    }
}

