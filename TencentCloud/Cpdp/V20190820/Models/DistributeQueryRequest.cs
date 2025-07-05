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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DistributeQueryRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用门店OpenId
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 使用门店OpenKey
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 查询类型（1-全部，2-单笔）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 商户分账单号，type为2时，和DistributeNo二者传其一
        /// </summary>
        [JsonProperty("OutDistributeNo")]
        public string OutDistributeNo{ get; set; }

        /// <summary>
        /// 平台分账单号，type为2时，和OutDistributeNo二者传其一
        /// </summary>
        [JsonProperty("DistributeNo")]
        public string DistributeNo{ get; set; }

        /// <summary>
        /// 平台交易订单号
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OutDistributeNo", this.OutDistributeNo);
            this.SetParamSimple(map, prefix + "DistributeNo", this.DistributeNo);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

