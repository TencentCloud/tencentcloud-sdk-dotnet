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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAvailableExpertServiceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 安全管家订单
        /// </summary>
        [JsonProperty("ExpertService")]
        public ExpertServiceOrderInfo[] ExpertService{ get; set; }

        /// <summary>
        /// 应急响应可用次数
        /// </summary>
        [JsonProperty("EmergencyResponse")]
        public ulong? EmergencyResponse{ get; set; }

        /// <summary>
        /// 旗舰护网可用次数
        /// </summary>
        [JsonProperty("ProtectNet")]
        public ulong? ProtectNet{ get; set; }

        /// <summary>
        /// 是否购买过安全管家
        /// </summary>
        [JsonProperty("ExpertServiceBuy")]
        public bool? ExpertServiceBuy{ get; set; }

        /// <summary>
        /// 是否购买过应急响应
        /// </summary>
        [JsonProperty("EmergencyResponseBuy")]
        public bool? EmergencyResponseBuy{ get; set; }

        /// <summary>
        /// 是否购买过旗舰护网
        /// </summary>
        [JsonProperty("ProtectNetBuy")]
        public bool? ProtectNetBuy{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ExpertService.", this.ExpertService);
            this.SetParamSimple(map, prefix + "EmergencyResponse", this.EmergencyResponse);
            this.SetParamSimple(map, prefix + "ProtectNet", this.ProtectNet);
            this.SetParamSimple(map, prefix + "ExpertServiceBuy", this.ExpertServiceBuy);
            this.SetParamSimple(map, prefix + "EmergencyResponseBuy", this.EmergencyResponseBuy);
            this.SetParamSimple(map, prefix + "ProtectNetBuy", this.ProtectNetBuy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

