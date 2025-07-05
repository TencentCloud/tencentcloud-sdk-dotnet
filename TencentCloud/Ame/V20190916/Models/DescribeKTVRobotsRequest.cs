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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKTVRobotsRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器人Id列表。
        /// </summary>
        [JsonProperty("RobotIds")]
        public string[] RobotIds{ get; set; }

        /// <summary>
        /// 机器人状态，取值有：
        /// <li>Play：播放</li>
        /// <li>Pause：暂停</li>
        /// <li>Destroy：销毁</li>
        /// </summary>
        [JsonProperty("Statuses")]
        public string[] Statuses{ get; set; }

        /// <summary>
        /// 匹配创建时间在此时间段内的机器人。
        /// <li>包含所指定的头尾时间点。</li>
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值：0。将返回第 Offset 到第 Offset+Limit-1 条。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值：10。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RobotIds.", this.RobotIds);
            this.SetParamArraySimple(map, prefix + "Statuses.", this.Statuses);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

