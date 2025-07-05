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

    public class WireReceivingInfo : AbstractModel
    {
        
        /// <summary>
        /// '光纤', '网线', '电源线'
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public ulong? Quantity{ get; set; }

        /// <summary>
        /// '箱', '卷', '套'
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 收货凭证号
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }

        /// <summary>
        /// 硬件备注
        /// </summary>
        [JsonProperty("HardwareMemo")]
        public string HardwareMemo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
            this.SetParamSimple(map, prefix + "HardwareMemo", this.HardwareMemo);
        }
    }
}

