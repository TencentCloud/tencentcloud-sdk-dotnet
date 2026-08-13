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

    public class DescribeCostDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数量，最大值为100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>周期开始时间，查询粒度为天级别，需传入时分秒参数，格式为yyyy-mm-dd hh:ii:ss，Month和BeginTime&amp;EndTime必传一个，如果有该字段则Month字段无效。BeginTime和EndTime必须一起传，且为同一月份，暂不支持跨月拉取。可拉取的数据是开通消耗账单后，且距今 18 个月内的数据。</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>周期结束时间，查询粒度为天级别，需传入时分秒参数，格式为yyyy-mm-dd hh:ii:ss，Month和BeginTime&amp;EndTime必传一个，如果有该字段则Month字段无效。BeginTime和EndTime必须一起传，且为同一月份，暂不支持跨月拉取。可拉取的数据是开通消耗账单后，且距今 18 个月内的数据。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>是否需要访问列表的总记录数，用于前端分页<br>1-表示需要， 0-表示不需要</p>
        /// </summary>
        [JsonProperty("NeedRecordNum")]
        public ulong? NeedRecordNum{ get; set; }

        /// <summary>
        /// <p>月份，格式为yyyy-mm，Month和BeginTime&amp;EndTime必传一个，如果有传BeginTime&amp;EndTime则Month字段无效。不能早于开通消耗账单的月份，最多可拉取18个月内的数据。</p>
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// <p>查询指定产品信息</p>
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// <p>付费模式 prePay/postPay</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>查询指定资源信息</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>产品名称代码</p>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// <p>项目ID:资源所属项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>地域ID</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NeedRecordNum", this.NeedRecordNum);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

