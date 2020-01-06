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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBasicDDoSAlarmThresholdResponse : AbstractModel
    {
        
        /// <summary>
        /// 当存在告警阈值配置时，返回告警阈值大于0，当不存在告警配置时，返回告警阈值为0；
        /// </summary>
        [JsonProperty("AlarmThreshold")]
        public ulong? AlarmThreshold{ get; set; }

        /// <summary>
        /// 告警阈值类型，1-入流量，2-清洗流量；当AlarmThreshold大于0时有效；
        /// </summary>
        [JsonProperty("AlarmType")]
        public ulong? AlarmType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmThreshold", this.AlarmThreshold);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

