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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceConfigLicense : AbstractModel
    {
        
        /// <summary>
        /// 功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Function")]
        public DescribeResourceConfigLicenseFunction[] Function{ get; set; }

        /// <summary>
        /// 资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resource")]
        public DescribeResourceConfigLicenseResource[] Resource{ get; set; }

        /// <summary>
        /// utc时间 单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// utc时间 单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Countdown")]
        public ulong? Countdown{ get; set; }

        /// <summary>
        /// 规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Function.", this.Function);
            this.SetParamArrayObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Countdown", this.Countdown);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
        }
    }
}

