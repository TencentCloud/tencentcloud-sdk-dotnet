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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowUsage : AbstractModel
    {
        
        /// <summary>
        /// 流量包类型：ZONE 私有域；TRAFFIC 解析流量包
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 流量包总额度
        /// </summary>
        [JsonProperty("TotalQuantity")]
        public long? TotalQuantity{ get; set; }

        /// <summary>
        /// 流量包可用额度
        /// </summary>
        [JsonProperty("AvailableQuantity")]
        public long? AvailableQuantity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "TotalQuantity", this.TotalQuantity);
            this.SetParamSimple(map, prefix + "AvailableQuantity", this.AvailableQuantity);
        }
    }
}

