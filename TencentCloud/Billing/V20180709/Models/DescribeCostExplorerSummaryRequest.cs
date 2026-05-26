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

    public class DescribeCostExplorerSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>周期开始时间，格式为yyyy-mm-dd hh:ii:ss</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>周期结束时间，格式为yyyy-mm-dd hh:ii:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>账单类型：1-费用账单、2-消耗账单</p>
        /// </summary>
        [JsonProperty("BillType")]
        public string BillType{ get; set; }

        /// <summary>
        /// <p>统计周期：日-day，月-month；</p>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>分类维度（数据汇总维度），查询分类维度（请使用分类维度code入参）入参枚举值：<br>default=仅总计<br>feeType=费用类型<br>billType=账单类型<br>business=产品<br>product=子产品<br>region=地域<br>zone=可用区<br>actionType=交易类型<br>payMode =计费模式<br>tags=标签<br>project =项目<br>payerUin=支付者账号<br>ownerUin=使用者账号</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// <p>费用类型：cost-折后总费用，totalCost-原价费用</p>
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// <p>数量，每页最大值为100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>起始页，当PageNo=1表示第一页， PageNo=2表示第二页，依次类推。</p>
        /// </summary>
        [JsonProperty("PageNo")]
        public ulong? PageNo{ get; set; }

        /// <summary>
        /// <p>分账标签键</p>
        /// </summary>
        [JsonProperty("TagKeyStr")]
        public string TagKeyStr{ get; set; }

        /// <summary>
        /// <p>是否需要筛选框， 1-表示需要， 0-表示不需要，若不传默认不需要。</p>
        /// </summary>
        [JsonProperty("NeedConditionValue")]
        public string NeedConditionValue{ get; set; }

        /// <summary>
        /// <p>筛选参数</p>
        /// </summary>
        [JsonProperty("Conditions")]
        public AnalyseConditions Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "TagKeyStr", this.TagKeyStr);
            this.SetParamSimple(map, prefix + "NeedConditionValue", this.NeedConditionValue);
            this.SetParamObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

