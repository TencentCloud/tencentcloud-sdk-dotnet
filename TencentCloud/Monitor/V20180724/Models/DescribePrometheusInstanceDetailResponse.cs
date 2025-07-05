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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例业务状态。取值范围：
        /// 
        /// 1：正在创建
        /// 2：运行中
        /// 3：异常
        /// 4：重建中
        /// 5：销毁中
        /// 6：已停服
        /// 8：欠费停服中
        /// 9：欠费已停服
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// 计费状态
        /// 
        /// 1：正常
        /// 2：过期
        /// 3：销毁
        /// 4：分配中
        /// 5：分配失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public long? ChargeStatus{ get; set; }

        /// <summary>
        /// 是否开启 Grafana
        /// 0：不开启
        /// 1：开启
        /// </summary>
        [JsonProperty("EnableGrafana")]
        public long? EnableGrafana{ get; set; }

        /// <summary>
        /// Grafana 面板 URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrafanaURL")]
        public string GrafanaURL{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：
        /// 
        /// 2：包年包月
        /// 3：按量
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }

        /// <summary>
        /// 规格名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 存储周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataRetentionTime")]
        public long? DataRetentionTime{ get; set; }

        /// <summary>
        /// 购买的实例过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 自动续费标记
        /// 
        /// 0：不自动续费
        /// 1：开启自动续费
        /// 2：禁止自动续费
        /// -1：无效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "EnableGrafana", this.EnableGrafana);
            this.SetParamSimple(map, prefix + "GrafanaURL", this.GrafanaURL);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "DataRetentionTime", this.DataRetentionTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

