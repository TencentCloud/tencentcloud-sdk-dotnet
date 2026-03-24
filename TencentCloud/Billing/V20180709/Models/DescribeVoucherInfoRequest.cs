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

    public class DescribeVoucherInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>一页多少条数据，默认是20条，最大不超过1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>第多少页，默认是1</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>券状态：待使用：unUsed，已使用：&nbsp;used，已发货：delivered，已作废：&nbsp;cancel，已过期：overdue</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>代金券id</p>
        /// </summary>
        [JsonProperty("VoucherId")]
        public string VoucherId{ get; set; }

        /// <summary>
        /// <p>代金券订单id</p>
        /// </summary>
        [JsonProperty("CodeId")]
        public string CodeId{ get; set; }

        /// <summary>
        /// <p>商品码</p>
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// <p>活动id</p>
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// <p>代金券名称</p>
        /// </summary>
        [JsonProperty("VoucherName")]
        public string VoucherName{ get; set; }

        /// <summary>
        /// <p>发放开始时间,例：2021-01-01</p>
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom{ get; set; }

        /// <summary>
        /// <p>发放结束时间，例：2021-01-01</p>
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo{ get; set; }

        /// <summary>
        /// <p>指定排序字段：BeginTime开始时间、EndTime到期时间、CreateTime创建时间</p>
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// <p>指定升序降序：desc、asc</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// <p>付费模式，postPay后付费/prePay预付费/riPay预留实例/&quot;&quot;或者&quot;*&quot;表示全部模式，如果payMode为&quot;&quot;或&quot;*&quot;，那么productCode与subProductCode必须传空</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>付费场景PayMode=postPay时：spotpay-竞价实例,&quot;settle account&quot;-普通后付费PayMode=prePay时：purchase-包年包月新购，renew-包年包月续费（自动续费），modify-包年包月配置变更(变配）PayMode=riPay时：oneOffFee-预留实例预付，hourlyFee-预留实例每小时扣费，*-支持全部付费场景</p>
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// <p>操作人，默认就是用户uin</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>代金券主类型 has_price 为有价现金券 no_price 为无价代金券</p>
        /// </summary>
        [JsonProperty("VoucherMainType")]
        public string VoucherMainType{ get; set; }

        /// <summary>
        /// <p>代金券副类型 discount 为折扣券 deduct 为抵扣券</p>
        /// </summary>
        [JsonProperty("VoucherSubType")]
        public string VoucherSubType{ get; set; }

        /// <summary>
        /// <p>券有效时间开始时间</p>
        /// </summary>
        [JsonProperty("StartTimeFrom")]
        public string StartTimeFrom{ get; set; }

        /// <summary>
        /// <p>券有效时间结束时间</p>
        /// </summary>
        [JsonProperty("StartTimeTo")]
        public string StartTimeTo{ get; set; }

        /// <summary>
        /// <p>券失效时间开始时间</p>
        /// </summary>
        [JsonProperty("EndTimeFrom")]
        public string EndTimeFrom{ get; set; }

        /// <summary>
        /// <p>券失效时间结束时间</p>
        /// </summary>
        [JsonProperty("EndTimeTo")]
        public string EndTimeTo{ get; set; }

        /// <summary>
        /// <p>发券时间开始时间</p>
        /// </summary>
        [JsonProperty("CreateTimeFrom")]
        public string CreateTimeFrom{ get; set; }

        /// <summary>
        /// <p>发券时间结束时间</p>
        /// </summary>
        [JsonProperty("CreateTimeTo")]
        public string CreateTimeTo{ get; set; }

        /// <summary>
        /// <p>语言参数</p><p>默认值：zh</p><p>期望返回产品名称中文或其他语言，目前仅支持中文、英文；填&quot;zh&quot;或不填时返回中文，其他情况返回英文</p>
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VoucherId", this.VoucherId);
            this.SetParamSimple(map, prefix + "CodeId", this.CodeId);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "VoucherName", this.VoucherName);
            this.SetParamSimple(map, prefix + "TimeFrom", this.TimeFrom);
            this.SetParamSimple(map, prefix + "TimeTo", this.TimeTo);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "VoucherMainType", this.VoucherMainType);
            this.SetParamSimple(map, prefix + "VoucherSubType", this.VoucherSubType);
            this.SetParamSimple(map, prefix + "StartTimeFrom", this.StartTimeFrom);
            this.SetParamSimple(map, prefix + "StartTimeTo", this.StartTimeTo);
            this.SetParamSimple(map, prefix + "EndTimeFrom", this.EndTimeFrom);
            this.SetParamSimple(map, prefix + "EndTimeTo", this.EndTimeTo);
            this.SetParamSimple(map, prefix + "CreateTimeFrom", this.CreateTimeFrom);
            this.SetParamSimple(map, prefix + "CreateTimeTo", this.CreateTimeTo);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
        }
    }
}

