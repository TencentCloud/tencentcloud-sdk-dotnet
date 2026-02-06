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

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// ClientToken是一个由客户端生成的唯一的、区分大小写、不超过64个ASCII字符的字符串。例如，ClientToken=123e4567-e89b-12d3-a456-42665544****。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 产品一层code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 产品二层code
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 地域code
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 可用区code
        /// </summary>
        [JsonProperty("ZoneCode")]
        public string ZoneCode{ get; set; }

        /// <summary>
        /// 付费类型，取值：  PrePay：预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 商品详情信息
        /// </summary>
        [JsonProperty("Parameter")]
        public string Parameter{ get; set; }

        /// <summary>
        /// 商品数量，默认取值1
        /// </summary>
        [JsonProperty("Quantity")]
        public long? Quantity{ get; set; }

        /// <summary>
        /// 项目id，默认取0
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 新购时长，取值上限：36，默认取值1
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 新购时长单位，取值：m：按月购买，y：按年购买，默认取值m
        /// </summary>
        [JsonProperty("PeriodUnit")]
        public string PeriodUnit{ get; set; }

        /// <summary>
        /// 自动续费标识，取值：NOTIFY_AND_MANUAL_RENEW：手动续费，NOTIFY_AND_AUTO_RENEW：自动续费，DISABLE_NOTIFY_AND_MANUAL_RENEW：到期不续，默认取值NOTIFY_AND_MANUAL_RENEW
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "ZoneCode", this.ZoneCode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Parameter", this.Parameter);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "PeriodUnit", this.PeriodUnit);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

