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

    public class DescribeAllocationSummaryByBusinessRequest : AbstractModel
    {
        
        /// <summary>
        /// 数量，最大值为1000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，Offset=0表示第一页，如果Limit=100，则Offset=100表示第二页，Offset=200表示第三页，依次类推
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 账单月份，格式为2024-02，不传默认当前月
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 统计周期，枚举值如下
        /// month - 月
        /// day - 日
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// 分账单元唯一标识，用作筛选
        /// </summary>
        [JsonProperty("TreeNodeUniqKeys")]
        public string[] TreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// 排序类型，枚举值如下：
        /// asc - 升序
        /// desc - 降序
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// 排序字段，枚举值如下：
        /// GatherCashPayAmount - 归集费用(现金)
        /// GatherVoucherPayAmount- 归集费用(优惠券)
        /// GatherIncentivePayAmount - 归集费用(赠送金)
        /// GatherTransferPayAmount - 归集费用(分成金)
        /// AllocateCashPayAmount - 分摊费用(现金)
        /// AllocateVoucherPayAmount - 分摊费用(优惠券)
        /// AllocateIncentivePayAmount - 分摊费用(赠送金)
        /// AllocateTransferPayAmount - 分摊费用(分成金)
        /// TotalCashPayAmount - 合计费用(现金)
        /// TotalVoucherPayAmount - 合计费用(优惠券)
        /// TotalIncentivePayAmount - 合计费用(赠送金)
        /// TotalTransferPayAmount - 合计费用(分成金)
        /// GatherRealCost - 归集费用(折后总额)
        /// AllocateRealCost - 分摊费用(折后总额)
        /// RealTotalCost - 合计费用(折后总额)
        /// BusinessCode - 产品代码
        /// Ratio - 占比(折后总额)
        /// Trend - 环比(折后总额)
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 日期，用作筛选，PeriodType=day时可传
        /// </summary>
        [JsonProperty("BillDates")]
        public string[] BillDates{ get; set; }

        /// <summary>
        /// 产品编码，用作筛选
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string[] BusinessCodes{ get; set; }

        /// <summary>
        /// 模糊搜索条件
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

