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

    public class CreateModelServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 模型服务名称
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
        /// 模型ID列表
        /// </summary>
        [JsonProperty("TargetModels")]
        public TargetModelDTO[] TargetModels{ get; set; }

        /// <summary>
        /// 路径匹配类型: prefix 前缀匹配(不送默认); absolute 绝对匹配; regex正则匹配;
        /// </summary>
        [JsonProperty("PathMatchType")]
        public string PathMatchType{ get; set; }

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
        /// 是否开启内容安全
        /// </summary>
        [JsonProperty("TmsStatus")]
        public bool? TmsStatus{ get; set; }

        /// <summary>
        /// 内容安全配置
        /// </summary>
        [JsonProperty("TmsConfig")]
        public TmsConfigDTO TmsConfig{ get; set; }

        /// <summary>
        /// 是否开启IP白名单
        /// </summary>
        [JsonProperty("IpWhiteStatus")]
        public bool? IpWhiteStatus{ get; set; }

        /// <summary>
        /// IP白名单
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// IP黑名单
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// 插件配置
        /// </summary>
        [JsonProperty("PluginConfigs")]
        public PluginConfigDTO[] PluginConfigs{ get; set; }

        /// <summary>
        /// 超时配置，秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 是否开启提示词安全检测
        /// </summary>
        [JsonProperty("PromptModerateStatus")]
        public bool? PromptModerateStatus{ get; set; }

        /// <summary>
        /// 提示词安全检测配置
        /// </summary>
        [JsonProperty("PromptModerateConfig")]
        public PromptModerateConfigDTO PromptModerateConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PubPath", this.PubPath);
            this.SetParamArrayObj(map, prefix + "TargetModels.", this.TargetModels);
            this.SetParamSimple(map, prefix + "PathMatchType", this.PathMatchType);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamSimple(map, prefix + "TokenLimitStatus", this.TokenLimitStatus);
            this.SetParamObj(map, prefix + "TokenLimitConfig.", this.TokenLimitConfig);
            this.SetParamSimple(map, prefix + "TmsStatus", this.TmsStatus);
            this.SetParamObj(map, prefix + "TmsConfig.", this.TmsConfig);
            this.SetParamSimple(map, prefix + "IpWhiteStatus", this.IpWhiteStatus);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamArraySimple(map, prefix + "IpBlackList.", this.IpBlackList);
            this.SetParamArrayObj(map, prefix + "PluginConfigs.", this.PluginConfigs);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "PromptModerateStatus", this.PromptModerateStatus);
            this.SetParamObj(map, prefix + "PromptModerateConfig.", this.PromptModerateConfig);
        }
    }
}

