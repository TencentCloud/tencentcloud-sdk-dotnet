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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 过滤条件：任务状态，可选值：WAITING（等待中）、PROCESSING（处理中）、FINISH（已完成）。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 过滤条件：文件 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 过滤条件：任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// 过滤条件：任务结束时间。
        /// </summary>
        [JsonProperty("FinishTime")]
        public TimeRange FinishTime{ get; set; }

        /// <summary>
        /// 排序方式。Sort.Field 可选：
        /// <li> CreateTime 任务创建时间。</li>
        /// <li>FinishTime 任务结束时间。</li>
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamObj(map, prefix + "FinishTime.", this.FinishTime);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
        }
    }
}

