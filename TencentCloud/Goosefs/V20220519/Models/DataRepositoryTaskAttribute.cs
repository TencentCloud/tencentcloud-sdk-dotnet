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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataRepositoryTaskAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>数据流通任务类型, FS_TO_COS(文件系统到COS Bucket),或者Bucket到文件系统(COS_TO_FS)</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>bucket名</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>bucket路径</p>
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// <p>总的容量(单位Byte)</p>
        /// </summary>
        [JsonProperty("TotalCapacity")]
        public ulong? TotalCapacity{ get; set; }

        /// <summary>
        /// <p>已完成的数据量(单位Byte)</p>
        /// </summary>
        [JsonProperty("FinishedCapacity")]
        public ulong? FinishedCapacity{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// <p>任务开始执行时间</p>
        /// </summary>
        [JsonProperty("TaskStartTime")]
        public string TaskStartTime{ get; set; }

        /// <summary>
        /// <p>任务结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// <p>INIT(任务初始化中) RUNNING(任务执行中) SUCCESS(任务已完成) FAIL(任务失败)</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务失败原因</p>
        /// </summary>
        [JsonProperty("TaskFailMsg")]
        public string TaskFailMsg{ get; set; }

        /// <summary>
        /// <p>总共的文件个数</p>
        /// </summary>
        [JsonProperty("TotalFileNumber")]
        public ulong? TotalFileNumber{ get; set; }

        /// <summary>
        /// <p>已完成的文件个数</p>
        /// </summary>
        [JsonProperty("FinishedFileNumber")]
        public ulong? FinishedFileNumber{ get; set; }

        /// <summary>
        /// <p>列表地址</p>
        /// </summary>
        [JsonProperty("TextLocation")]
        public string TextLocation{ get; set; }

        /// <summary>
        /// <p>执行器类型</p>
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// <p>是否自定义路径</p>
        /// </summary>
        [JsonProperty("EnableDataFlowSubPath")]
        [System.Obsolete]
        public bool? EnableDataFlowSubPath{ get; set; }

        /// <summary>
        /// <p>自定义路径</p>
        /// </summary>
        [JsonProperty("DataFlowSubPath")]
        [System.Obsolete]
        public string DataFlowSubPath{ get; set; }

        /// <summary>
        /// <p>是否支持自定义目的路径（沉降表示桶前缀，预热表示本地路径）</p>
        /// </summary>
        [JsonProperty("EnableCustomDestPath")]
        public bool? EnableCustomDestPath{ get; set; }

        /// <summary>
        /// <p>自定义目的路径（沉降表示桶前缀，预热表示本地路径）</p>
        /// </summary>
        [JsonProperty("CustomDestPath")]
        public string CustomDestPath{ get; set; }

        /// <summary>
        /// <p>任务路径是否表示绝对路径（暂时仅支持沉降使用）</p>
        /// </summary>
        [JsonProperty("IsTaskPathAbsolute")]
        public bool? IsTaskPathAbsolute{ get; set; }

        /// <summary>
        /// <p>任务内容输出桶</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputBucket")]
        public string OutputBucket{ get; set; }

        /// <summary>
        /// <p>任务内容输出桶前缀</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputPrefix")]
        public string OutputPrefix{ get; set; }

        /// <summary>
        /// <p>是否支持自定义数据源路径(暂时仅支持清单过滤使用)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableCustomSrcPath")]
        public bool? EnableCustomSrcPath{ get; set; }

        /// <summary>
        /// <p>自定义数据源路径(暂时仅支持清单过滤使用)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomSrcPath")]
        public string CustomSrcPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "TaskPath", this.TaskPath);
            this.SetParamSimple(map, prefix + "TotalCapacity", this.TotalCapacity);
            this.SetParamSimple(map, prefix + "FinishedCapacity", this.FinishedCapacity);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "TaskStartTime", this.TaskStartTime);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskFailMsg", this.TaskFailMsg);
            this.SetParamSimple(map, prefix + "TotalFileNumber", this.TotalFileNumber);
            this.SetParamSimple(map, prefix + "FinishedFileNumber", this.FinishedFileNumber);
            this.SetParamSimple(map, prefix + "TextLocation", this.TextLocation);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "EnableDataFlowSubPath", this.EnableDataFlowSubPath);
            this.SetParamSimple(map, prefix + "DataFlowSubPath", this.DataFlowSubPath);
            this.SetParamSimple(map, prefix + "EnableCustomDestPath", this.EnableCustomDestPath);
            this.SetParamSimple(map, prefix + "CustomDestPath", this.CustomDestPath);
            this.SetParamSimple(map, prefix + "IsTaskPathAbsolute", this.IsTaskPathAbsolute);
            this.SetParamSimple(map, prefix + "OutputBucket", this.OutputBucket);
            this.SetParamSimple(map, prefix + "OutputPrefix", this.OutputPrefix);
            this.SetParamSimple(map, prefix + "EnableCustomSrcPath", this.EnableCustomSrcPath);
            this.SetParamSimple(map, prefix + "CustomSrcPath", this.CustomSrcPath);
        }
    }
}

