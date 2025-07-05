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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogisticsReceipt : AbstractModel
    {
        
        /// <summary>
        /// 物流预计上门时间
        /// </summary>
        [JsonProperty("LogisticsArrivalTime")]
        public string LogisticsArrivalTime{ get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("LogisticsCompany")]
        public string LogisticsCompany{ get; set; }

        /// <summary>
        /// 物流联系人
        /// </summary>
        [JsonProperty("LogisticsStuff")]
        public string LogisticsStuff{ get; set; }

        /// <summary>
        /// 物流电话
        /// </summary>
        [JsonProperty("LogisticsStuffContact")]
        public string LogisticsStuffContact{ get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [JsonProperty("ReceiverContact")]
        public string ReceiverContact{ get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("ReceiverName")]
        public string ReceiverName{ get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonProperty("ShippingAddress")]
        public string ShippingAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogisticsArrivalTime", this.LogisticsArrivalTime);
            this.SetParamSimple(map, prefix + "LogisticsCompany", this.LogisticsCompany);
            this.SetParamSimple(map, prefix + "LogisticsStuff", this.LogisticsStuff);
            this.SetParamSimple(map, prefix + "LogisticsStuffContact", this.LogisticsStuffContact);
            this.SetParamSimple(map, prefix + "ReceiverContact", this.ReceiverContact);
            this.SetParamSimple(map, prefix + "ReceiverName", this.ReceiverName);
            this.SetParamSimple(map, prefix + "ShippingAddress", this.ShippingAddress);
        }
    }
}

