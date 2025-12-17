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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmShieldCount : AbstractModel
    {
        
        /// <summary>
        /// 符合检索条件的告警屏蔽总数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 告警屏蔽未生效数量
        /// </summary>
        [JsonProperty("InvalidCount")]
        public ulong? InvalidCount{ get; set; }

        /// <summary>
        /// 告警屏蔽生效中数量
        /// </summary>
        [JsonProperty("ValidCount")]
        public ulong? ValidCount{ get; set; }

        /// <summary>
        /// 告警屏蔽已过期数量
        /// </summary>
        [JsonProperty("ExpireCount")]
        public ulong? ExpireCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "InvalidCount", this.InvalidCount);
            this.SetParamSimple(map, prefix + "ValidCount", this.ValidCount);
            this.SetParamSimple(map, prefix + "ExpireCount", this.ExpireCount);
        }
    }
}

