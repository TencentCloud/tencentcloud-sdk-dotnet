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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>作业ID；JobId详见<a href="https://cloud.tencent.com/document/product/599/15909">作业列表</a></p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>作业的Task名称，详见<a href="https://cloud.tencent.com/document/product/599/15904">作业详情</a>。</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>作业任务实例的序号，详见<a href="https://cloud.tencent.com/document/product/599/15905">任务详情</a></p>
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public long? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// <p>支持查询的指标；当前支持查询的任务指标；</p><ul><li>CpuUsage：cpu利用率，单位：%</li><li>MemUsage：内存利用率，单位：%</li><li>LanOuttraffic：内网出带宽，单位：Bytes/s</li><li>LanIntraffic：内网入带宽，单位：Bytes/s</li><li>MaxDiskUsage：所有磁盘中的使用率最高的磁盘使用率，单位：%</li><li>TargetDiskUsage：指定磁盘的使用率，单位：%；配合Dimensions参数使用</li></ul>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>查询任务实例的起始时间；如果未传入查询起始时间或传入的时间小于任务实例的创建时间（任务实例创建时间详见<a href="https://cloud.tencent.com/document/product/599/15905">任务详情</a>），会自动将查询时间调整到任务实例的创建时间。传入时间格式只支持零时区格式。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询任务实例的终止时间；如果未传入查询终止时间或传入的时间大于任务实例的终止时间（任务实例终止时间详见<a href="https://cloud.tencent.com/document/product/599/15905">任务详情</a>），并且任务实例已经结束，会自动将查询终止时间调整到任务实例的终止时间；如果任务实例未结束，会自动将查询终止时间调整到当前时间。传入时间格式只支持零时区格式。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>查询指标的扩展参数；当前只支持TargetDiskUsage;</p><ul><li>TargetDiskUsage<br>  -支持的查询维度diskname, 维度值为磁盘挂载名，例如vdb；如果不传此参数，默认查询vdb磁盘的使用率。<br>  样例：[{&quot;Name&quot;:&quot;diskname&quot;, &quot;Value&quot;:&quot;vdb&quot;}]</li></ul>
        /// </summary>
        [JsonProperty("Dimensions")]
        public Dimension[] Dimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
        }
    }
}

