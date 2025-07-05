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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsagePlan : AbstractModel
    {
        
        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// 使用计划唯一ID。
        /// </summary>
        [JsonProperty("UsagePlanId")]
        public string UsagePlanId{ get; set; }

        /// <summary>
        /// 使用计划名称。
        /// </summary>
        [JsonProperty("UsagePlanName")]
        public string UsagePlanName{ get; set; }

        /// <summary>
        /// 使用计划描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanDesc")]
        public string UsagePlanDesc{ get; set; }

        /// <summary>
        /// 使用计划qps，-1表示没有限制。
        /// </summary>
        [JsonProperty("MaxRequestNumPreSec")]
        public long? MaxRequestNumPreSec{ get; set; }

        /// <summary>
        /// 使用计划时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 使用计划修改时间。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamSimple(map, prefix + "UsagePlanId", this.UsagePlanId);
            this.SetParamSimple(map, prefix + "UsagePlanName", this.UsagePlanName);
            this.SetParamSimple(map, prefix + "UsagePlanDesc", this.UsagePlanDesc);
            this.SetParamSimple(map, prefix + "MaxRequestNumPreSec", this.MaxRequestNumPreSec);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
        }
    }
}

