/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SavingPlanCoverageDetail : AbstractModel
    {
        
        /// <summary>
        /// 资源 ID：账单中出账对象 ID，不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 地域ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 产品编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 费用起始日期，格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 费用结束日期，格式yyyy-MM-dd，目前与StartDate相等
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 节省计划覆盖金额（即节省计划支付金额）
        /// </summary>
        [JsonProperty("SpCoveredAmount")]
        public float? SpCoveredAmount{ get; set; }

        /// <summary>
        /// 节省计划未覆盖金额（即优惠后总价）
        /// </summary>
        [JsonProperty("SpUncoveredAmount")]
        public float? SpUncoveredAmount{ get; set; }

        /// <summary>
        /// 总支出（即节省计划未覆盖金额 + 节省计划覆盖金额）
        /// </summary>
        [JsonProperty("TotalRealAmount")]
        public float? TotalRealAmount{ get; set; }

        /// <summary>
        /// 按量计费预期金额（即折前价 * 折扣）
        /// </summary>
        [JsonProperty("ExpectedAmount")]
        public float? ExpectedAmount{ get; set; }

        /// <summary>
        /// 覆盖率结果，取值[0, 100]
        /// </summary>
        [JsonProperty("SpCoverage")]
        public float? SpCoverage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "SpCoveredAmount", this.SpCoveredAmount);
            this.SetParamSimple(map, prefix + "SpUncoveredAmount", this.SpUncoveredAmount);
            this.SetParamSimple(map, prefix + "TotalRealAmount", this.TotalRealAmount);
            this.SetParamSimple(map, prefix + "ExpectedAmount", this.ExpectedAmount);
            this.SetParamSimple(map, prefix + "SpCoverage", this.SpCoverage);
        }
    }
}

