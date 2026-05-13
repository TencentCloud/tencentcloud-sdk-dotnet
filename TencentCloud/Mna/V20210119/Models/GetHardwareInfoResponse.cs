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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetHardwareInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// license授权有效期 
        /// 0：月度授权 
        /// 1：永久授权 
        /// -1：未知
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// 付费方 0：客户付费 1：厂商付费
        /// </summary>
        [JsonProperty("Payer")]
        public long? Payer{ get; set; }

        /// <summary>
        /// 硬件序列号
        /// </summary>
        [JsonProperty("SN")]
        public string SN{ get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
            this.SetParamSimple(map, prefix + "SN", this.SN);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

