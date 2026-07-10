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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelRouterDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由实例关联的Budget ID。</p><p>未关联Budget时返回空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>模型路由实例关联的Budget名称。</p><p>未关联Budget时返回空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// <p>集群信息</p>
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo ClusterInfo{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>模型路由实例按Budget刷新周期划分的Credit使用情况。</p><p>当关联Budget配置多个刷新周期时，按1d、7d、30d顺序返回各周期用量；未关联Budget时返回空数组。</p>
        /// </summary>
        [JsonProperty("CreditUsageSet")]
        public CreditUsage[] CreditUsageSet{ get; set; }

        /// <summary>
        /// <p>模型路由实例域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>模型路由ID</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>模型路由名称</p><p>默认值：-</p>
        /// </summary>
        [JsonProperty("ModelRouterName")]
        public string ModelRouterName{ get; set; }

        /// <summary>
        /// <p>模型路由类型</p><p>枚举值：</p><ul><li>Shared： 共享型</li><li>Enterprise： 企业级</li></ul>
        /// </summary>
        [JsonProperty("ModelRouterType")]
        public string ModelRouterType{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// <p>模型路由实例网络类型</p><p>枚举值：</p><ul><li>Internet： 公网</li><li>Intranet： 内网</li></ul>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>模型路由限速信息</p>
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfigForModelRouter RateLimitConfig{ get; set; }

        /// <summary>
        /// <p>模型路由的路由配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RouterSetting")]
        public RouterSettingWithFallBack RouterSetting{ get; set; }

        /// <summary>
        /// <p>安全组ID列表</p>
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// <p>模型路由实例的安全状态</p><p>枚举值：</p><ul><li>Normal： 正常</li><li>Banned： 已封禁</li><li>Frozen： 已冻结</li></ul>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// <p>模型路由网络配置列表</p>
        /// </summary>
        [JsonProperty("ServiceEndPoints")]
        public ServiceEndPoints[] ServiceEndPoints{ get; set; }

        /// <summary>
        /// <p>模型路由实例状态</p><p>枚举值：</p><ul><li>Active： 运行中</li><li>Provisioning： 创建中</li><li>Configuring： 变配中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>模型路由实例所属子网的ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>模型路由实例的计费状态</p><p>枚举值：</p><ul><li>Normal： 正常</li><li>Isolated： 已隔离</li></ul>
        /// </summary>
        [JsonProperty("TradeStatus")]
        public string TradeStatus{ get; set; }

        /// <summary>
        /// <p>模型路由实例VIP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>模型路由实例所属VPC的ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "CreditUsageSet.", this.CreditUsageSet);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "ModelRouterName", this.ModelRouterName);
            this.SetParamSimple(map, prefix + "ModelRouterType", this.ModelRouterType);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamObj(map, prefix + "RouterSetting.", this.RouterSetting);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamArrayObj(map, prefix + "ServiceEndPoints.", this.ServiceEndPoints);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TradeStatus", this.TradeStatus);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

