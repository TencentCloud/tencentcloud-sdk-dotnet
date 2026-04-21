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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllocationSummaryByBusinessRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数量，最大值为1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移量，Offset=0表示第一页，如果Limit=100，则Offset=100表示第二页，Offset=200表示第三页，以此类推</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>账单月份，格式为2024-02，不传默认当前月</p>
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// <p>统计周期，枚举值如下<br>month - 月<br>day - 日</p>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>分账单元唯一标识，用作筛选</p>
        /// </summary>
        [JsonProperty("TreeNodeUniqKeys")]
        public string[] TreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// <p>排序类型，枚举值如下：<br>asc - 升序<br>desc - 降序</p>
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// <p>排序字段，枚举值如下：<br>GatherCashPayAmount - 归集费用(现金)<br>GatherVoucherPayAmount- 归集费用(优惠券)<br>GatherIncentivePayAmount - 归集费用(赠送金)<br>GatherTransferPayAmount - 归集费用(分成金)<br>AllocateCashPayAmount - 分摊费用(现金)<br>AllocateVoucherPayAmount - 分摊费用(优惠券)<br>AllocateIncentivePayAmount - 分摊费用(赠送金)<br>AllocateTransferPayAmount - 分摊费用(分成金)<br>TotalCashPayAmount - 合计费用(现金)<br>TotalVoucherPayAmount - 合计费用(优惠券)<br>TotalIncentivePayAmount - 合计费用(赠送金)<br>TotalTransferPayAmount - 合计费用(分成金)<br>GatherRealCost - 归集费用(折后总额)<br>AllocateRealCost - 分摊费用(折后总额)<br>RealTotalCost - 合计费用(折后总额)<br>BusinessCode - 产品代码<br>Ratio - 占比(折后总额)<br>Trend - 环比(折后总额)</p>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// <p>日期，用作筛选，PeriodType=day时可传</p>
        /// </summary>
        [JsonProperty("BillDates")]
        public string[] BillDates{ get; set; }

        /// <summary>
        /// <p>产品编码，用作筛选</p>
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string[] BusinessCodes{ get; set; }

        /// <summary>
        /// <p>模糊搜索条件</p>
        /// </summary>
        [JsonProperty("SearchKey")]
        [System.Obsolete]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamArraySimple(map, prefix + "TreeNodeUniqKeys.", this.TreeNodeUniqKeys);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamArraySimple(map, prefix + "BillDates.", this.BillDates);
            this.SetParamArraySimple(map, prefix + "BusinessCodes.", this.BusinessCodes);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

