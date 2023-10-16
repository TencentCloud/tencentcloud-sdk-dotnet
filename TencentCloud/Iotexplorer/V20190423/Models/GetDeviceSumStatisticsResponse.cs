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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDeviceSumStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 激活设备总数
        /// </summary>
        [JsonProperty("ActivationCount")]
        public long? ActivationCount{ get; set; }

        /// <summary>
        /// 在线设备总数
        /// </summary>
        [JsonProperty("OnlineCount")]
        public long? OnlineCount{ get; set; }

        /// <summary>
        /// 前一天激活设备数
        /// </summary>
        [JsonProperty("ActivationBeforeDay")]
        public long? ActivationBeforeDay{ get; set; }

        /// <summary>
        /// 前一天活跃设备数
        /// </summary>
        [JsonProperty("ActiveBeforeDay")]
        public long? ActiveBeforeDay{ get; set; }

        /// <summary>
        /// 前一周激活设备数
        /// </summary>
        [JsonProperty("ActivationWeekDayCount")]
        public long? ActivationWeekDayCount{ get; set; }

        /// <summary>
        /// 前一周活跃设备数
        /// </summary>
        [JsonProperty("ActiveWeekDayCount")]
        public long? ActiveWeekDayCount{ get; set; }

        /// <summary>
        /// 上一周激活设备数
        /// </summary>
        [JsonProperty("ActivationBeforeWeekDayCount")]
        public long? ActivationBeforeWeekDayCount{ get; set; }

        /// <summary>
        /// 上一周活跃设备数
        /// </summary>
        [JsonProperty("ActiveBeforeWeekDayCount")]
        public long? ActiveBeforeWeekDayCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ActivationCount", this.ActivationCount);
            this.SetParamSimple(map, prefix + "OnlineCount", this.OnlineCount);
            this.SetParamSimple(map, prefix + "ActivationBeforeDay", this.ActivationBeforeDay);
            this.SetParamSimple(map, prefix + "ActiveBeforeDay", this.ActiveBeforeDay);
            this.SetParamSimple(map, prefix + "ActivationWeekDayCount", this.ActivationWeekDayCount);
            this.SetParamSimple(map, prefix + "ActiveWeekDayCount", this.ActiveWeekDayCount);
            this.SetParamSimple(map, prefix + "ActivationBeforeWeekDayCount", this.ActivationBeforeWeekDayCount);
            this.SetParamSimple(map, prefix + "ActiveBeforeWeekDayCount", this.ActiveBeforeWeekDayCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

