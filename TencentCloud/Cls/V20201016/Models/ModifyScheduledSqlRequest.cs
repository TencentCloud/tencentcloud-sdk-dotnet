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

    public class ModifyScheduledSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID，通过<a href="https://cloud.tencent.com/document/product/614/95519">获取定时SQL分析任务列表</a>获取</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>源日志主题，通过<a href="https://cloud.tencent.com/document/product/614/95519">获取定时SQL分析任务列表</a>获取</p>
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// <p>任务启动状态.   1开启,  2关闭</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// <p>定时SQL分析的目标日志主题</p>
        /// </summary>
        [JsonProperty("DstResource")]
        public ScheduledSqlResouceInfo DstResource{ get; set; }

        /// <summary>
        /// <p>查询语句</p>
        /// </summary>
        [JsonProperty("ScheduledSqlContent")]
        public string ScheduledSqlContent{ get; set; }

        /// <summary>
        /// <p>调度周期(分钟)，1~1440分钟</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>单次查询的时间窗口. 例子中为近15分钟</p>
        /// </summary>
        [JsonProperty("ProcessTimeWindow")]
        public string ProcessTimeWindow{ get; set; }

        /// <summary>
        /// <p>执行延迟(秒)，0~120秒，默认60秒</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>源topicId的地域信息,支持地域见 <a href="https://cloud.tencent.com/document/api/614/56474#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">地域列表</a> 文档</p>
        /// </summary>
        [JsonProperty("SrcTopicRegion")]
        public string SrcTopicRegion{ get; set; }

        /// <summary>
        /// <p>任务名称，0~255字符</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>语法规则。 默认值为0。 0：Lucene语法，1：CQL语法</p>
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// <p>是否开启投递服务日志。1：关闭，2：开启。</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>全文检索查询标记。1：关闭，2：打开。</p>
        /// </summary>
        [JsonProperty("FullQuery")]
        public ulong? FullQuery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamObj(map, prefix + "DstResource.", this.DstResource);
            this.SetParamSimple(map, prefix + "ScheduledSqlContent", this.ScheduledSqlContent);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessTimeWindow", this.ProcessTimeWindow);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "SrcTopicRegion", this.SrcTopicRegion);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "FullQuery", this.FullQuery);
        }
    }
}

