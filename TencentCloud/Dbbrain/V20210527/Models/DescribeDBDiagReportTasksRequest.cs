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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBDiagReportTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>第一个任务的开始时间，用于范围查询，时间格式如：2019-09-10 12:13:14。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>最后一个任务的开始时间，用于范围查询，时间格式如：2019-09-10 12:13:14。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>实例ID数组，用于筛选指定实例的任务列表。。可通过 <a href="https://cloud.tencent.com/document/api/1130/57798">DescribeDiagDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>任务的触发来源，支持的取值包括：&quot;DAILY_INSPECTION&quot; - 实例巡检；&quot;SCHEDULED&quot; - 计划任务；&quot;MANUAL&quot; - 手动触发。</p>
        /// </summary>
        [JsonProperty("Sources")]
        public string[] Sources{ get; set; }

        /// <summary>
        /// <p>报告的健康等级，支持的取值包括：&quot;HEALTH&quot; - 健康；&quot;SUB_HEALTH&quot; - 亚健康；&quot;RISK&quot; - 危险；&quot;HIGH_RISK&quot; - 高危。</p>
        /// </summary>
        [JsonProperty("HealthLevels")]
        public string HealthLevels{ get; set; }

        /// <summary>
        /// <p>任务的状态，支持的取值包括：&quot;created&quot; - 新建；&quot;chosen&quot; - 待执行； &quot;running&quot; - 执行中；&quot;failed&quot; - 失败；&quot;finished&quot; - 已完成。</p>
        /// </summary>
        [JsonProperty("TaskStatuses")]
        public string TaskStatuses{ get; set; }

        /// <summary>
        /// <p>偏移量，默认0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>返回数量，默认20，最大值为100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>服务产品类型，支持值：&quot;mysql&quot; - 云数据库 MySQL；&quot;cynosdb&quot; - 云数据库 TDSQL-C for MySQL，&quot;redis&quot; - 云数据库 Redis，默认为&quot;mysql&quot;。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>根据任务所属实例的标签信息进行过滤</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilterGroup[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "Sources.", this.Sources);
            this.SetParamSimple(map, prefix + "HealthLevels", this.HealthLevels);
            this.SetParamSimple(map, prefix + "TaskStatuses", this.TaskStatuses);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

