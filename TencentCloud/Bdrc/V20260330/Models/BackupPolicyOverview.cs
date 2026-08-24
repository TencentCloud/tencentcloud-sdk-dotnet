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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupPolicyOverview : AbstractModel
    {
        
        /// <summary>
        /// 自动备份策略总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 已绑定资源的策略数
        /// </summary>
        [JsonProperty("BoundCount")]
        public long? BoundCount{ get; set; }

        /// <summary>
        /// 未绑定任何资源的策略数
        /// </summary>
        [JsonProperty("UnboundCount")]
        public long? UnboundCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "BoundCount", this.BoundCount);
            this.SetParamSimple(map, prefix + "UnboundCount", this.UnboundCount);
        }
    }
}

