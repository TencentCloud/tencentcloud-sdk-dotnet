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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>返回数量，默认为10，最大值为100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>过滤条件，如下支持的过滤类型，传参Name应为以下其中一个,其中task-id支持最大50个过滤个数，其他过滤参数支持的总数不超过5个。<br>task-id - String - （任务ID准确过滤）task-id取值形如：e386471f-139a-4e59-877f-50ece8135b99。<br>task-state - String - （任务状态过滤）取值范围 0(初始化)， 1(运行中)， 2(成功)， -1(失败)。<br>task-sql-keyword - String - （SQL语句关键字模糊过滤）取值形如：DROP TABLE。<br>task-operator- string （子uin过滤）<br>task-kind - string （任务类型过滤）</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序字段，支持如下字段类型，create-time（创建时间，默认）、update-time（更新时间）</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>排序方式，desc表示正序，asc表示反序， 默认为asc。</p>
        /// </summary>
        [JsonProperty("Sorting")]
        public string Sorting{ get; set; }

        /// <summary>
        /// <p>起始时间点，格式为yyyy-mm-dd HH:MM:SS。默认为45天前的当前时刻</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间点，格式为yyyy-mm-dd HH:MM:SS时间跨度在(0,30天]，支持最近45天数据查询。默认为当前时刻</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>数据引擎名称，用于筛选</p>
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// <p>spark引擎资源组名称</p>
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "Sorting", this.Sorting);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
        }
    }
}

