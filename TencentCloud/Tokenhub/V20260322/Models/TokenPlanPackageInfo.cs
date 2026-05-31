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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TokenPlanPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 总额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("TotalQuota")]
        public string TotalQuota{ get; set; }

        /// <summary>
        /// 总已使用额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("TotalUsed")]
        public string TotalUsed{ get; set; }

        /// <summary>
        /// 总周期数。
        /// </summary>
        [JsonProperty("TotalCycles")]
        public long? TotalCycles{ get; set; }

        /// <summary>
        /// 周期单位。取值：month（月）
        /// </summary>
        [JsonProperty("CycleUnit")]
        public string CycleUnit{ get; set; }

        /// <summary>
        /// 套餐包生效时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 套餐包到期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 独占池已分配额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("ExclusiveAllocated")]
        public string ExclusiveAllocated{ get; set; }

        /// <summary>
        /// 独占池已用额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("ExclusiveUsed")]
        public string ExclusiveUsed{ get; set; }

        /// <summary>
        /// 共享池总额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("SharedPool")]
        public string SharedPool{ get; set; }

        /// <summary>
        /// 共享已用额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("SharedUsed")]
        public string SharedUsed{ get; set; }

        /// <summary>
        /// 当期额度。根据套餐类型区分单位：credits（企业版专业套餐），tokens（企业版auto套餐）
        /// </summary>
        [JsonProperty("CycleQuota")]
        public string CycleQuota{ get; set; }

        /// <summary>
        /// 当前周期。
        /// </summary>
        [JsonProperty("CurrentCycle")]
        public long? CurrentCycle{ get; set; }

        /// <summary>
        /// 剩余周期。
        /// </summary>
        [JsonProperty("RemainCycles")]
        public long? RemainCycles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "TotalUsed", this.TotalUsed);
            this.SetParamSimple(map, prefix + "TotalCycles", this.TotalCycles);
            this.SetParamSimple(map, prefix + "CycleUnit", this.CycleUnit);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ExclusiveAllocated", this.ExclusiveAllocated);
            this.SetParamSimple(map, prefix + "ExclusiveUsed", this.ExclusiveUsed);
            this.SetParamSimple(map, prefix + "SharedPool", this.SharedPool);
            this.SetParamSimple(map, prefix + "SharedUsed", this.SharedUsed);
            this.SetParamSimple(map, prefix + "CycleQuota", this.CycleQuota);
            this.SetParamSimple(map, prefix + "CurrentCycle", this.CurrentCycle);
            this.SetParamSimple(map, prefix + "RemainCycles", this.RemainCycles);
        }
    }
}

