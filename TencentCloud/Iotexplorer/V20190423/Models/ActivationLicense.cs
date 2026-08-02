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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivationLicense : AbstractModel
    {
        
        /// <summary>
        /// <p>激活码类型</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>支付模式</p>
        /// </summary>
        [JsonProperty("TotalLicenseNum")]
        public long? TotalLicenseNum{ get; set; }

        /// <summary>
        /// <p>计费标签项</p>
        /// </summary>
        [JsonProperty("UsedLicenseNum")]
        public long? UsedLicenseNum{ get; set; }

        /// <summary>
        /// <p>计费标识</p>
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "TotalLicenseNum", this.TotalLicenseNum);
            this.SetParamSimple(map, prefix + "UsedLicenseNum", this.UsedLicenseNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

