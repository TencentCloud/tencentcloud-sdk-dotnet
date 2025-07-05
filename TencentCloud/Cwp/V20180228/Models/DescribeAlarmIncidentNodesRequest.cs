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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmIncidentNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 告警vid
        /// </summary>
        [JsonProperty("AlarmVid")]
        public string AlarmVid{ get; set; }

        /// <summary>
        /// 告警时间
        /// </summary>
        [JsonProperty("AlarmTime")]
        public long? AlarmTime{ get; set; }

        /// <summary>
        /// 告警来源表ID
        /// </summary>
        [JsonProperty("TableId")]
        public long? TableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "AlarmVid", this.AlarmVid);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
        }
    }
}

