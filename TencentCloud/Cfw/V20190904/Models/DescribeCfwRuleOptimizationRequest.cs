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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwRuleOptimizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 长期零命中规则阈值天数。可选，必须为正整数，默认 180。
        /// </summary>
        [JsonProperty("IdleDays")]
        public long? IdleDays{ get; set; }

        /// <summary>
        /// 单 IP 离散过多聚合建议的最小数量。可选，最小为 2，默认 10。
        /// </summary>
        [JsonProperty("IpAggMin")]
        public long? IpAggMin{ get; set; }

        /// <summary>
        /// 可迁移 IOC 建议中返回的样例 IOC 数量上限。可选，必须为正整数，默认 50。
        /// </summary>
        [JsonProperty("IocSample")]
        public long? IocSample{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdleDays", this.IdleDays);
            this.SetParamSimple(map, prefix + "IpAggMin", this.IpAggMin);
            this.SetParamSimple(map, prefix + "IocSample", this.IocSample);
        }
    }
}

