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
        /// 腾讯云AppID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 腾讯云Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 访问路径
        /// </summary>
        [JsonProperty("PubPath")]
        public string PubPath{ get; set; }

        /// <summary>
        /// 路径匹配方式：absolute，prefix，regex
        /// </summary>
        [JsonProperty("PathMatchType")]
        public string PathMatchType{ get; set; }

        /// <summary>
        /// 目标模型列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetModels")]
        public TargetModelDTO[] TargetModels{ get; set; }

        /// <summary>
        /// 模板模型的名称列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelNames")]
        public string[] ModelNames{ get; set; }

        /// <summary>
        /// 是否开启限流
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// 限流配置
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 是否开启token控制
        /// </summary>
        [JsonProperty("TokenLimitStatus")]
        public bool? TokenLimitStatus{ get; set; }

        /// <summary>
        /// token控制
        /// </summary>
        [JsonProperty("TokenLimitConfig")]
        public TokenLimitConfigDTO TokenLimitConfig{ get; set; }

        /// <summary>
        /// 是否开启tms配置
        /// </summary>
        [JsonProperty("TmsStatus")]
        public bool? TmsStatus{ get; set; }

        /// <summary>
        /// tms配置
        /// </summary>
        [JsonProperty("TmsConfig")]
        public TmsConfigDTO TmsConfig{ get; set; }

        /// <summary>
        /// 是否开启IP白名单
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// IP白名单列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// 是否开启IP黑名单
        /// </summary>
        [JsonProperty("IpBlackStatus")]
        public bool? IpBlackStatus{ get; set; }

        /// <summary>
        /// IP黑名单列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// 插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// 超时配置，单位秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 状态：normal，disabled
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 关联应用数
        /// </summary>
        [JsonProperty("RelateAgentAppNum")]
        public long? RelateAgentAppNum{ get; set; }

        /// <summary>
        /// 请求路径
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 是否开启提示词安全检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptModerateStatus")]
        public bool? PromptModerateStatus{ get; set; }

        /// <summary>
        /// 提示词安全检测配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptModerateConfig")]
        public PromptModerateConfigDTO PromptModerateConfig{ get; set; }


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
        }
    }
}

