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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// 访问日志配置结构。
        /// </summary>
        [JsonProperty("AccessLogConfig")]
        public AccessLogConfig AccessLogConfig{ get; set; }

        /// <summary>
        /// IP 地址版本，取值 IPv4 或 IPv6。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIpVersion")]
        public string AddressIpVersion{ get; set; }

        /// <summary>
        /// 负载均衡的地址类型。取值：
        /// 
        /// - **Internet**：负载均衡具有公网IP地址，DNS域名被解析到公网IP，因此可以在公网环境访问。
        /// 
        /// - **Intranet**：负载均衡只有私网IP地址，DNS域名被解析到私网IP，因此只能被负载均衡所在VPC的内网环境访问。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// 资源创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 删除保护设置信息。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public DeletionProtectionConfig DeletionProtection{ get; set; }

        /// <summary>
        /// DNS域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 负载均衡实例计费配置。
        /// </summary>
        [JsonProperty("LoadBalancerBillingConfig")]
        public LoadBalancerBillingConfig LoadBalancerBillingConfig{ get; set; }

        /// <summary>
        /// 负载均衡实例 ID，格式为 alb- 后接 8 位字母数字。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡实例名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡操作锁配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerOperationLocks")]
        public LoadBalancerOperationLocksItem[] LoadBalancerOperationLocks{ get; set; }

        /// <summary>
        /// 应用型负载均衡实例状态。取值：
        /// 
        /// - **Provisioning**：创建中。
        /// - **Active**: 运行中。
        /// - **Configuring**: 变配中。
        /// - **Deleting**：删除中。
        /// - **ProvisionFailed**：创建失败。
        /// - **ConfigureFailed**：变配失败。
        /// - **DeletionFailed**：删除失败。
        /// - **Abnormal**：异常状态，具体异常原因参见LoadBalancerOperationLocks字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerStatus")]
        public string LoadBalancerStatus{ get; set; }

        /// <summary>
        /// 修改保护设置信息。
        /// </summary>
        [JsonProperty("ModificationProtection")]
        public ModificationProtectionInfo ModificationProtection{ get; set; }

        /// <summary>
        /// 标签列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 私有网络 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AccessLogConfig.", this.AccessLogConfig);
            this.SetParamSimple(map, prefix + "AddressIpVersion", this.AddressIpVersion);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "DeletionProtection.", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "LoadBalancerBillingConfig.", this.LoadBalancerBillingConfig);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamArrayObj(map, prefix + "LoadBalancerOperationLocks.", this.LoadBalancerOperationLocks);
            this.SetParamSimple(map, prefix + "LoadBalancerStatus", this.LoadBalancerStatus);
            this.SetParamObj(map, prefix + "ModificationProtection.", this.ModificationProtection);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

