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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务状态过滤条件，可选值：
        /// - WAITING（等待中）
        /// - PROCESSING（处理中）
        /// - FINISH（已完成）。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务结束时子任务是否有失败。如果不传则忽略。
        /// <li>false: 过滤子任务没有失败的任务；</li>
        /// <li>true: 过滤子任务有失败的任务。</li>
        /// </summary>
        [JsonProperty("SubTaskHasFailed")]
        public bool? SubTaskHasFailed{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：10，最大值：100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 翻页标识，分批拉取时使用：当单次请求无法拉取所有数据，接口将会返回 ScrollToken，下一次请求携带该 Token，将会从下一条记录开始获取。
        /// </summary>
        [JsonProperty("ScrollToken")]
        public string ScrollToken{ get; set; }

        /// <summary>
        /// 查询任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubTaskHasFailed", this.SubTaskHasFailed);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

