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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 一组指标和数据
        /// </summary>
        [JsonProperty("Metrics")]
        public MetricDatum[] Metrics{ get; set; }

        /// <summary>
        /// 上报时自行指定的 IP
        /// </summary>
        [JsonProperty("AnnounceIp")]
        public string AnnounceIp{ get; set; }

        /// <summary>
        /// 上报时自行指定的时间戳
        /// </summary>
        [JsonProperty("AnnounceTimestamp")]
        public ulong? AnnounceTimestamp{ get; set; }

        /// <summary>
        /// 上报时自行指定的 IP 或 产品实例ID
        /// </summary>
        [JsonProperty("AnnounceInstance")]
        public string AnnounceInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "AnnounceIp", this.AnnounceIp);
            this.SetParamSimple(map, prefix + "AnnounceTimestamp", this.AnnounceTimestamp);
            this.SetParamSimple(map, prefix + "AnnounceInstance", this.AnnounceInstance);
        }
    }
}

