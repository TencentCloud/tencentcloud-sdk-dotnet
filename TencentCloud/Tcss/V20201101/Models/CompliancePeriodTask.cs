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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompliancePeriodTask : AbstractModel
    {
        
        /// <summary>
        /// 周期任务的ID
        /// </summary>
        [JsonProperty("PeriodTaskId")]
        public ulong? PeriodTaskId{ get; set; }

        /// <summary>
        /// 资产类型。
        /// ASSET_CONTAINER, 容器
        /// ASSET_IMAGE, 镜像
        /// ASSET_HOST, 主机
        /// ASSET_K8S, K8S资产
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 最近一次触发的时间
        /// </summary>
        [JsonProperty("LastTriggerTime")]
        public string LastTriggerTime{ get; set; }

        /// <summary>
        /// 总的检查项数目
        /// </summary>
        [JsonProperty("TotalPolicyItemCount")]
        public ulong? TotalPolicyItemCount{ get; set; }

        /// <summary>
        /// 周期设置
        /// </summary>
        [JsonProperty("PeriodRule")]
        public CompliancePeriodTaskRule PeriodRule{ get; set; }

        /// <summary>
        /// 合规标准列表
        /// </summary>
        [JsonProperty("BenchmarkStandardSet")]
        public ComplianceBenchmarkStandard[] BenchmarkStandardSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeriodTaskId", this.PeriodTaskId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "LastTriggerTime", this.LastTriggerTime);
            this.SetParamSimple(map, prefix + "TotalPolicyItemCount", this.TotalPolicyItemCount);
            this.SetParamObj(map, prefix + "PeriodRule.", this.PeriodRule);
            this.SetParamArrayObj(map, prefix + "BenchmarkStandardSet.", this.BenchmarkStandardSet);
        }
    }
}

