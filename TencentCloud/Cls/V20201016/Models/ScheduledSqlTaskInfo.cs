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

    public class ScheduledSqlTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>ScheduledSql任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>ScheduledSql任务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>源日志主题id</p>
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// <p>源日志主题名称</p>
        /// </summary>
        [JsonProperty("SrcTopicName")]
        public string SrcTopicName{ get; set; }

        /// <summary>
        /// <p>定时SQL分析目标主题</p>
        /// </summary>
        [JsonProperty("DstResource")]
        public ScheduledSqlResouceInfo DstResource{ get; set; }

        /// <summary>
        /// <p>任务创建时间。格式：yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务更新时间，格式：yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>任务状态，1:运行 2:停止 3:异常-找不到源日志主题 4:异常-找不到目标主题</p><p>5: 访问权限问题 6:内部故障 7:其他故障</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>任务启用状态，1开启,  2关闭</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// <p>查询语句</p>
        /// </summary>
        [JsonProperty("ScheduledSqlContent")]
        public string ScheduledSqlContent{ get; set; }

        /// <summary>
        /// <p>调度开始时间，格式：yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public string ProcessStartTime{ get; set; }

        /// <summary>
        /// <p>调度类型，1:持续运行 2:指定时间范围</p>
        /// </summary>
        [JsonProperty("ProcessType")]
        public long? ProcessType{ get; set; }

        /// <summary>
        /// <p>调度结束时间，格式：yyyy-MM-dd HH:mm:ss，当process_type=2时为必传字段</p>
        /// </summary>
        [JsonProperty("ProcessEndTime")]
        public string ProcessEndTime{ get; set; }

        /// <summary>
        /// <p>调度周期(分钟)，1~1440分钟</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>查询的时间窗口. @m-15m, @m，意为近15分钟</p>
        /// </summary>
        [JsonProperty("ProcessTimeWindow")]
        public string ProcessTimeWindow{ get; set; }

        /// <summary>
        /// <p>执行延迟(秒)，0~120秒，默认60秒</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>源topicId的地域信息，支持地域见 <a href="https://cloud.tencent.com/document/api/614/56474#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">地域列表</a> 文档。</p>
        /// </summary>
        [JsonProperty("SrcTopicRegion")]
        public string SrcTopicRegion{ get; set; }

        /// <summary>
        /// <p>语法规则，0：Lucene语法，1：CQL语法</p>
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// <p>是否开启投递服务日志。1：关闭，2：开启。</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>全文检索标记。1：关闭，2：打开。</p>
        /// </summary>
        [JsonProperty("FullQuery")]
        public ulong? FullQuery{ get; set; }

        /// <summary>
        /// <p>调度周期时间单位</p><p>取值范围：[1, 2]</p><p>默认值：1</p><p>默认值1（分钟），其他值2（秒）</p>
        /// </summary>
        [JsonProperty("ProcessPeriodUnit")]
        public long? ProcessPeriodUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "SrcTopicName", this.SrcTopicName);
            this.SetParamObj(map, prefix + "DstResource.", this.DstResource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ScheduledSqlContent", this.ScheduledSqlContent);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "ProcessEndTime", this.ProcessEndTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessTimeWindow", this.ProcessTimeWindow);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "SrcTopicRegion", this.SrcTopicRegion);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "FullQuery", this.FullQuery);
            this.SetParamSimple(map, prefix + "ProcessPeriodUnit", this.ProcessPeriodUnit);
        }
    }
}

