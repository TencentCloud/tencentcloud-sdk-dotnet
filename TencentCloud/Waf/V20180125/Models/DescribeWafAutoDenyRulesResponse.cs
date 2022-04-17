/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWafAutoDenyRulesResponse : AbstractModel
    {
        
        /// <summary>
        /// 攻击次数阈值
        /// </summary>
        [JsonProperty("AttackThreshold")]
        public long? AttackThreshold{ get; set; }

        /// <summary>
        /// 攻击时间阈值
        /// </summary>
        [JsonProperty("TimeThreshold")]
        public long? TimeThreshold{ get; set; }

        /// <summary>
        /// 自动封禁时间
        /// </summary>
        [JsonProperty("DenyTimeThreshold")]
        public long? DenyTimeThreshold{ get; set; }

        /// <summary>
        /// 自动封禁状态
        /// </summary>
        [JsonProperty("DefenseStatus")]
        public long? DefenseStatus{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackThreshold", this.AttackThreshold);
            this.SetParamSimple(map, prefix + "TimeThreshold", this.TimeThreshold);
            this.SetParamSimple(map, prefix + "DenyTimeThreshold", this.DenyTimeThreshold);
            this.SetParamSimple(map, prefix + "DefenseStatus", this.DefenseStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

