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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryRangeMetricRequest : AbstractModel
    {
        
        /// <summary>
        /// 指标主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 查询语句，使用PromQL语法
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 查询起始时间，秒级Unix时间戳
        /// </summary>
        [JsonProperty("Start")]
        public ulong? Start{ get; set; }

        /// <summary>
        /// 查询结束时间，秒级Unix时间戳
        /// </summary>
        [JsonProperty("End")]
        public ulong? End{ get; set; }

        /// <summary>
        /// 查询时间间隔，单位秒
        /// </summary>
        [JsonProperty("Step")]
        public ulong? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

