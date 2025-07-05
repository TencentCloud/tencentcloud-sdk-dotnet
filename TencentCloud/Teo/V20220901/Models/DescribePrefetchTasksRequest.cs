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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrefetchTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。该参数必填。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 查询起始时间，时间与 job-id 必填一个。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，时间与 job-id 必填一个。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分页查询偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页查询限制数目，默认值：20，上限：1000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values 的上限为 20。详细的过滤条件如下：<li>job-id：按照任务 ID 进行过滤。job-id 形如：1379afjk91u32h，暂不支持多值，不支持模糊查询；</li><li>target：按照目标资源信息进行过滤。target 形如：http://www.qq.com/1.txt，暂不支持多值，不支持模糊查询；</li><li>domains：按照域名行过滤。domains 形如：www.qq.com，不支持模糊查询；</li><li>statuses：按照任务状态进行过滤，不支持模糊查询。可选项：<br>   processing：处理中<br>   success：成功<br>   failed：失败<br>   timeout：超时<br>   invalid：无效。即源站响应非 2xx 状态码，请检查源站服务。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

