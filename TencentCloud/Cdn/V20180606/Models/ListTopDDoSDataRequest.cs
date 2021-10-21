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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTopDDoSDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询Top数据的开始时间，格式为：2020-01-01 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询Top数据的结束时间，格式为：2020-01-01 23:59:59
        /// 支持 90 天内数据查询，时间跨度要小于等于7天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询Top的数量，不填默认值为10
        /// </summary>
        [JsonProperty("TopCount")]
        public ulong? TopCount{ get; set; }

        /// <summary>
        /// AttackIP表示查询攻击ip的top排行，AttackType表示攻击类型的top排行，为空默认为AttackType
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TopCount", this.TopCount);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
        }
    }
}

