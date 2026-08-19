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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>模型 ID。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>TPM 限制（Tokens Per Minute）。模型无配额配置时不返回此字段。</p>
        /// </summary>
        [JsonProperty("TPMLimit")]
        public long? TPMLimit{ get; set; }

        /// <summary>
        /// <p>RPM 限制（Request Per Minute）。模型无配额配置时不返回此字段。</p>
        /// </summary>
        [JsonProperty("RPMLimit")]
        public long? RPMLimit{ get; set; }

        /// <summary>
        /// <p>TPM 保障包 input 配额</p>
        /// </summary>
        [JsonProperty("TPMInputQuotaLimit")]
        public long? TPMInputQuotaLimit{ get; set; }

        /// <summary>
        /// <p>TPM 保障包 output 配额</p>
        /// </summary>
        [JsonProperty("TPMOutputQuotaLimit")]
        public long? TPMOutputQuotaLimit{ get; set; }

        /// <summary>
        /// <p>TPM 预留 input 配额</p>
        /// </summary>
        [JsonProperty("TPMInputReserveLimit")]
        public long? TPMInputReserveLimit{ get; set; }

        /// <summary>
        /// <p>TPM 预留 output 配额</p>
        /// </summary>
        [JsonProperty("TPMOutputReserveLimit")]
        public long? TPMOutputReserveLimit{ get; set; }

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
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "TPMLimit", this.TPMLimit);
            this.SetParamSimple(map, prefix + "RPMLimit", this.RPMLimit);
            this.SetParamSimple(map, prefix + "TPMInputQuotaLimit", this.TPMInputQuotaLimit);
            this.SetParamSimple(map, prefix + "TPMOutputQuotaLimit", this.TPMOutputQuotaLimit);
            this.SetParamSimple(map, prefix + "TPMInputReserveLimit", this.TPMInputReserveLimit);
            this.SetParamSimple(map, prefix + "TPMOutputReserveLimit", this.TPMOutputReserveLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

