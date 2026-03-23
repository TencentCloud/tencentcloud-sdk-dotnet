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
        /// 实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 标签ID数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelIDs")]
        public string[] LabelIDs{ get; set; }

        /// <summary>
        /// 目录ID数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryIDs")]
        public string[] CategoryIDs{ get; set; }

        /// <summary>
        /// 负载方式，robin random consistentHash
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// 目标服务器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// 后端协议：http https
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// 证书检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// 目标路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// 流量控制状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// 流量控制配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// IP白名单开启状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// IP白名单配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteConfig")]
        public IpConfig IpWhiteConfig{ get; set; }

        /// <summary>
        /// IP黑名单开启状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// IP黑名单配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackConfig")]
        public IpConfig IpBlackConfig{ get; set; }

        /// <summary>
        /// mcp server ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 预览地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 应用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("App")]
        public IDNameVO App{ get; set; }

        /// <summary>
        /// 目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalogs")]
        public IDNameVO[] Catalogs{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public IDNameVO[] Labels{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 用户appID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 自定义host
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomHttpHost")]
        public string CustomHttpHost{ get; set; }

        /// <summary>
        ///  Http 请求host类型 useRequestHost 保持源请求host targetHost 修正为源站host  customHost 自定义host
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpHostType")]
        public string HttpHostType{ get; set; }

        /// <summary>
        /// 请求的超时时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// mcp server模式
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// mcp version
        /// </summary>
        [JsonProperty("McpVersion")]
        public string McpVersion{ get; set; }

        /// <summary>
        /// 封装模式下绑定的服务ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WrapServices")]
        public string[] WrapServices{ get; set; }

        /// <summary>
        /// 工具数量
        /// </summary>
        [JsonProperty("ToolNum")]
        public long? ToolNum{ get; set; }

        /// <summary>
        /// 安全规则集响应
        /// </summary>
        [JsonProperty("McpSecurityRulesVO")]
        public McpSecurityRulesVO[] McpSecurityRulesVO{ get; set; }

        /// <summary>
        /// 真实工具级别配置，实时拉取了tool/list做渲染的，如果tool/list不通，就拉不到。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ToolConfigs")]
        public ToolConfigVO[] ToolConfigs{ get; set; }

        /// <summary>
        /// 访问URL
        /// </summary>
        [JsonProperty("UrlObj")]
        public McpUrlObj UrlObj{ get; set; }

        /// <summary>
        /// 后端mcp服务是否正常
        /// </summary>
        [JsonProperty("ToolMessage")]
        public string ToolMessage{ get; set; }

        /// <summary>
        /// 后端mcp服务的工具列表
        /// </summary>
        [JsonProperty("Tools")]
        public McpTool[] Tools{ get; set; }

        /// <summary>
        /// 封装的API分组ID
        /// </summary>
        [JsonProperty("WrapPaasID")]
        public string WrapPaasID{ get; set; }

        /// <summary>
        /// 关联的agentApp数量
        /// </summary>
        [JsonProperty("RelateAgentAppNum")]
        public long? RelateAgentAppNum{ get; set; }

        /// <summary>
        /// 插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }


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
        }
    }
}

