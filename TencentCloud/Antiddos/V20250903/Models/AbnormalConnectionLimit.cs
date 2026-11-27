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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalConnectionLimit : AbstractModel
    {
        
        /// <summary>
        /// <p>异常连接数限制，限制同一时间单个源 IP 异常连接数量， 0为不启用, 范围: 0-4294967295。</p><p>取值范围：[0, 4294967295]</p>
        /// </summary>
        [JsonProperty("AbnormalConnectThreshold")]
        public ulong? AbnormalConnectThreshold{ get; set; }

        /// <summary>
        /// <p>异常连接判定条件。满足任意条件则计为一次异常统计。</p>
        /// </summary>
        [JsonProperty("AbnormalConnectCondition")]
        public AbnormalConnectCondition AbnormalConnectCondition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AbnormalConnectThreshold", this.AbnormalConnectThreshold);
            this.SetParamObj(map, prefix + "AbnormalConnectCondition.", this.AbnormalConnectCondition);
        }
    }
}

