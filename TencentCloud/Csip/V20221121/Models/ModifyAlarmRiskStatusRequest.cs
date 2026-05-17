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

    public class ModifyAlarmRiskStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警或者风险id
        /// </summary>
        [JsonProperty("AlarmRiskIdSet")]
        public CosAlarmRiskIdInfo[] AlarmRiskIdSet{ get; set; }

        /// <summary>
        /// 风险或告警状态  1 告警 2风险
        /// </summary>
        [JsonProperty("AlarmRiskType")]
        public long? AlarmRiskType{ get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AlarmRiskIdSet.", this.AlarmRiskIdSet);
            this.SetParamSimple(map, prefix + "AlarmRiskType", this.AlarmRiskType);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
        }
    }
}

