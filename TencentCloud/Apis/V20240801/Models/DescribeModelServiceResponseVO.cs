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

    public class DescribeModelServiceResponseVO : AbstractModel
    {
        
        /// <summary>
        /// <p>腾讯云AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>腾讯云Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>模型ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>模型名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>访问路径</p>
        /// </summary>
        [JsonProperty("PubPath")]
        public string PubPath{ get; set; }

        /// <summary>
        /// <p>路径匹配方式：absolute，prefix，regex</p>
        /// </summary>
        [JsonProperty("PathMatchType")]
        public string PathMatchType{ get; set; }

        /// <summary>
        /// <p>目标模型列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetModels")]
        public TargetModelDTO[] TargetModels{ get; set; }

        /// <summary>
        /// <p>模板模型的名称列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelNames")]
        public string[] ModelNames{ get; set; }

        /// <summary>
        /// <p>是否开启限流</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// <p>限流配置</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>是否开启token控制</p>
        /// </summary>
        [JsonProperty("TokenLimitStatus")]
        public bool? TokenLimitStatus{ get; set; }

        /// <summary>
        /// <p>token控制</p>
        /// </summary>
        [JsonProperty("TokenLimitConfig")]
        public TokenLimitConfigDTO TokenLimitConfig{ get; set; }

        /// <summary>
        /// <p>是否开启tms配置</p>
        /// </summary>
        [JsonProperty("TmsStatus")]
        public bool? TmsStatus{ get; set; }

        /// <summary>
        /// <p>tms配置</p>
        /// </summary>
        [JsonProperty("TmsConfig")]
        public TmsConfigDTO TmsConfig{ get; set; }

        /// <summary>
        /// <p>是否开启IP白名单</p>
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// <p>IP白名单列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// <p>是否开启IP黑名单</p>
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// <p>IP黑名单列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// <p>插件配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// <p>超时配置，单位秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>状态：normal，disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>关联应用数</p>
        /// </summary>
        [JsonProperty("RelateAgentAppNum")]
        public long? RelateAgentAppNum{ get; set; }

        /// <summary>
        /// <p>请求路径</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>是否开启提示词安全检测</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptModerateStatus")]
        public bool? PromptModerateStatus{ get; set; }

        /// <summary>
        /// <p>提示词安全检测配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptModerateConfig")]
        public PromptModerateConfigDTO PromptModerateConfig{ get; set; }

        /// <summary>
        /// <p>是否开启敏感数据检测</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveDataCheckStatus")]
        public bool? SensitiveDataCheckStatus{ get; set; }

        /// <summary>
        /// <p>敏感数据检测配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveDataCheckConfig")]
        public SensitiveDataCheckConfigDTO SensitiveDataCheckConfig{ get; set; }

        /// <summary>
        /// <p>负载方式</p><p>枚举值：</p><ul><li>random： 随机</li><li>consistentHash： 会话保持</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSelect")]
        public string TargetSelect{ get; set; }

        /// <summary>
        /// <p>会话判断方式</p><p>枚举值：</p><ul><li>fromClientIP： 从客户端IP判断</li><li>fromHeader： 从请求header判断</li><li>autoDetect： 自动探测</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FindHostKeyMethod")]
        public string FindHostKeyMethod{ get; set; }

        /// <summary>
        /// <p>会话判断header名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostKeyHeaderName")]
        public string HostKeyHeaderName{ get; set; }

        /// <summary>
        /// <p>是否开启备份模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FallbackStatus")]
        public bool? FallbackStatus{ get; set; }

        /// <summary>
        /// <p>备份模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FallbackModels")]
        public TargetModelDTO[] FallbackModels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PubPath", this.PubPath);
            this.SetParamSimple(map, prefix + "PathMatchType", this.PathMatchType);
            this.SetParamArrayObj(map, prefix + "TargetModels.", this.TargetModels);
            this.SetParamArraySimple(map, prefix + "ModelNames.", this.ModelNames);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "TokenLimitStatus", this.TokenLimitStatus);
            this.SetParamObj(map, prefix + "TokenLimitConfig.", this.TokenLimitConfig);
            this.SetParamSimple(map, prefix + "TmsStatus", this.TmsStatus);
            this.SetParamObj(map, prefix + "TmsConfig.", this.TmsConfig);
            this.SetParamSimple(map, prefix + "IpWhiteStatus", this.IpWhiteStatus);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "IpBlackStatus", this.IpBlackStatus);
            this.SetParamArraySimple(map, prefix + "IpBlackList.", this.IpBlackList);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RelateAgentAppNum", this.RelateAgentAppNum);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "PromptModerateStatus", this.PromptModerateStatus);
            this.SetParamObj(map, prefix + "PromptModerateConfig.", this.PromptModerateConfig);
            this.SetParamSimple(map, prefix + "SensitiveDataCheckStatus", this.SensitiveDataCheckStatus);
            this.SetParamObj(map, prefix + "SensitiveDataCheckConfig.", this.SensitiveDataCheckConfig);
            this.SetParamSimple(map, prefix + "TargetSelect", this.TargetSelect);
            this.SetParamSimple(map, prefix + "FindHostKeyMethod", this.FindHostKeyMethod);
            this.SetParamSimple(map, prefix + "HostKeyHeaderName", this.HostKeyHeaderName);
            this.SetParamSimple(map, prefix + "FallbackStatus", this.FallbackStatus);
            this.SetParamArrayObj(map, prefix + "FallbackModels.", this.FallbackModels);
        }
    }
}

