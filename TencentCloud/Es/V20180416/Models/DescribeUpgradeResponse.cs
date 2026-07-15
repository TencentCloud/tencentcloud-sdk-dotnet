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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUpgradeResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>可以升级到的大版本</p>
        /// </summary>
        [JsonProperty("EsVersions")]
        public string[] EsVersions{ get; set; }

        /// <summary>
        /// <p>可以升级到的商业特性</p>
        /// </summary>
        [JsonProperty("EsLicenses")]
        public string[] EsLicenses{ get; set; }

        /// <summary>
        /// <p>可以升级到的子产品</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsSubProducts")]
        public string[] EsSubProducts{ get; set; }

        /// <summary>
        /// <p>可以升级到的商业特性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsRealLicenses")]
        public string[] EsRealLicenses{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "EsVersions.", this.EsVersions);
            this.SetParamArraySimple(map, prefix + "EsLicenses.", this.EsLicenses);
            this.SetParamArraySimple(map, prefix + "EsSubProducts.", this.EsSubProducts);
            this.SetParamArraySimple(map, prefix + "EsRealLicenses.", this.EsRealLicenses);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

