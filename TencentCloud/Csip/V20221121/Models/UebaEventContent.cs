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

    public class UebaEventContent : AbstractModel
    {
        
        /// <summary>
        /// 发生事件类型
        /// 1:语句检索
        /// 2:过滤检索
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// 语句检索内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 检索条件
        /// </summary>
        [JsonProperty("Filters")]
        public WhereFilter[] Filters{ get; set; }

        /// <summary>
        /// 统计条件
        /// </summary>
        [JsonProperty("StatisticalFilter")]
        public StatisticalFilter StatisticalFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "StatisticalFilter.", this.StatisticalFilter);
        }
    }
}

