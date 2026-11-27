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

namespace TencentCloud.Svp.V20240125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SavingPlanCoverageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>资源 ID：账单中出账对象 ID，不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>地域ID</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// <p>产品编码</p>
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// <p>子产品编码</p>
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// <p>费用起始日期，格式yyyy-MM-dd</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>费用结束日期，格式yyyy-MM-dd，目前与StartDate相等</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>节省计划覆盖金额（即节省计划支付金额）</p>
        /// </summary>
        [JsonProperty("SpCoveredAmount")]
        public float? SpCoveredAmount{ get; set; }

        /// <summary>
        /// <p>节省计划未覆盖金额（即优惠后总价）</p>
        /// </summary>
        [JsonProperty("SpUncoveredAmount")]
        public float? SpUncoveredAmount{ get; set; }

        /// <summary>
        /// <p>总支出（即节省计划未覆盖金额 + 节省计划覆盖金额）</p>
        /// </summary>
        [JsonProperty("TotalRealAmount")]
        public float? TotalRealAmount{ get; set; }

        /// <summary>
        /// <p>按量计费预期金额（即折前价 * 折扣）</p>
        /// </summary>
        [JsonProperty("ExpectedAmount")]
        public float? ExpectedAmount{ get; set; }

        /// <summary>
        /// <p>覆盖率结果，取值为百分比值，取值范围[0,100]</p>
        /// </summary>
        [JsonProperty("SpCoverage")]
        public float? SpCoverage{ get; set; }

        /// <summary>
        /// <p>支付者昵称</p>
        /// </summary>
        [JsonProperty("PayerUinName")]
        public string PayerUinName{ get; set; }

        /// <summary>
        /// <p>使用者昵称</p>
        /// </summary>
        [JsonProperty("OwnerUinName")]
        public string OwnerUinName{ get; set; }

        /// <summary>
        /// <p>支付者uin</p>
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// <p>计费项名称</p>
        /// </summary>
        [JsonProperty("SubBillingItemName")]
        public string SubBillingItemName{ get; set; }

        /// <summary>
        /// <p>计费细项名称</p>
        /// </summary>
        [JsonProperty("BillingItemName")]
        public string BillingItemName{ get; set; }

        /// <summary>
        /// <p>子产品名称</p>
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }


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
            this.SetParamSimple(map, prefix + "PayerUinName", this.PayerUinName);
            this.SetParamSimple(map, prefix + "OwnerUinName", this.OwnerUinName);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "SubBillingItemName", this.SubBillingItemName);
            this.SetParamSimple(map, prefix + "BillingItemName", this.BillingItemName);
            this.SetParamSimple(map, prefix + "SubProductName", this.SubProductName);
        }
    }
}

