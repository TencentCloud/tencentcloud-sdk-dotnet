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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaultToleranceDTO : AbstractModel
    {
        
        /// <summary>
        /// <p>是否启用API Key容错配置</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>异常判定状态码，固定3位数字或字母</p>
        /// </summary>
        [JsonProperty("ErrorCodes")]
        public string[] ErrorCodes{ get; set; }

        /// <summary>
        /// <p>连续异常次数</p><p>单位：次</p>
        /// </summary>
        [JsonProperty("ErrorCount")]
        public long? ErrorCount{ get; set; }

        /// <summary>
        /// <p>隔离时长</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("IsolationTime")]
        public long? IsolationTime{ get; set; }

        /// <summary>
        /// <p>最多切换次数</p><p>置0为不开启自动切换</p>
        /// </summary>
        [JsonProperty("MaxSwitchCount")]
        public long? MaxSwitchCount{ get; set; }

        /// <summary>
        /// <p>切换总时间预算</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("SwitchTimeout")]
        public long? SwitchTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "ErrorCodes.", this.ErrorCodes);
            this.SetParamSimple(map, prefix + "ErrorCount", this.ErrorCount);
            this.SetParamSimple(map, prefix + "IsolationTime", this.IsolationTime);
            this.SetParamSimple(map, prefix + "MaxSwitchCount", this.MaxSwitchCount);
            this.SetParamSimple(map, prefix + "SwitchTimeout", this.SwitchTimeout);
        }
    }
}

