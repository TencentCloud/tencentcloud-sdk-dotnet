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

    public class DescribeTokenPlanPersonalPackageResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>产品类型。</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// <p>套餐状态。取值：active（生效中）、processing（处理中）、failed（创建失败）、isolated（隔离/欠费）、destroyed（已销毁）、used_up（额度用尽）、stopped（已停止）、unpurchased（未购买）。</p>
        /// </summary>
        [JsonProperty("PackageStatus")]
        public string PackageStatus{ get; set; }

        /// <summary>
        /// <p>计费资源ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>总额度。</p>
        /// </summary>
        [JsonProperty("TotalCredits")]
        public string TotalCredits{ get; set; }

        /// <summary>
        /// <p>已使用额度。</p>
        /// </summary>
        [JsonProperty("TotalUsed")]
        public string TotalUsed{ get; set; }

        /// <summary>
        /// <p>单周期额度。</p>
        /// </summary>
        [JsonProperty("CycleCredits")]
        public string CycleCredits{ get; set; }

        /// <summary>
        /// <p>总周期数。</p>
        /// </summary>
        [JsonProperty("TotalCycles")]
        public long? TotalCycles{ get; set; }

        /// <summary>
        /// <p>当前周期序号。</p>
        /// </summary>
        [JsonProperty("CurrentCycle")]
        public long? CurrentCycle{ get; set; }

        /// <summary>
        /// <p>剩余周期数。</p>
        /// </summary>
        [JsonProperty("RemainCycles")]
        public long? RemainCycles{ get; set; }

        /// <summary>
        /// <p>套餐生效时间，ISO 8601 格式。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>套餐过期时间，ISO 8601 格式。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>当前周期到期日，ISO 8601 格式。</p>
        /// </summary>
        [JsonProperty("PeriodEndDate")]
        public string PeriodEndDate{ get; set; }

        /// <summary>
        /// <p>自动续费标识。取值：0（未开启）、1（已开启）。</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>输出token数</p><p>单位：tokens</p>
        /// </summary>
        [JsonProperty("OutputToken")]
        public long? OutputToken{ get; set; }

        /// <summary>
        /// <p>输入token数</p><p>单位：token</p>
        /// </summary>
        [JsonProperty("InputToken")]
        public long? InputToken{ get; set; }

        /// <summary>
        /// <p>缓存命中token数</p><p>单位：token</p>
        /// </summary>
        [JsonProperty("CacheToken")]
        public long? CacheToken{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "PackageStatus", this.PackageStatus);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TotalCredits", this.TotalCredits);
            this.SetParamSimple(map, prefix + "TotalUsed", this.TotalUsed);
            this.SetParamSimple(map, prefix + "CycleCredits", this.CycleCredits);
            this.SetParamSimple(map, prefix + "TotalCycles", this.TotalCycles);
            this.SetParamSimple(map, prefix + "CurrentCycle", this.CurrentCycle);
            this.SetParamSimple(map, prefix + "RemainCycles", this.RemainCycles);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "PeriodEndDate", this.PeriodEndDate);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "OutputToken", this.OutputToken);
            this.SetParamSimple(map, prefix + "InputToken", this.InputToken);
            this.SetParamSimple(map, prefix + "CacheToken", this.CacheToken);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

