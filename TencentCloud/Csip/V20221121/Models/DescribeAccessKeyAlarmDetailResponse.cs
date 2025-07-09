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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessKeyAlarmDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 告警信息
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public AccessKeyAlarm AlarmInfo{ get; set; }

        /// <summary>
        /// 所属账号CAM策略数量
        /// </summary>
        [JsonProperty("CamCount")]
        public long? CamCount{ get; set; }

        /// <summary>
        /// AK风险数量
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 告警策略描述
        /// </summary>
        [JsonProperty("AlarmDesc")]
        public string AlarmDesc{ get; set; }

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
            this.SetParamObj(map, prefix + "AlarmInfo.", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "CamCount", this.CamCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AlarmDesc", this.AlarmDesc);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

