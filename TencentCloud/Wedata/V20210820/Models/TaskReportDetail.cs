/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskReportDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例数据运行时间
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 实例实际下发时间
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 任务状态码。1 正在执行,2 成功,3 失败,4 等待终止,5 正在终止,6 已终止,7 终止失败,9 等待执行。
        /// </summary>
        [JsonProperty("TaskState")]
        public string TaskState{ get; set; }

        /// <summary>
        /// 总读取条数
        /// </summary>
        [JsonProperty("TotalReadRecords")]
        public ulong? TotalReadRecords{ get; set; }

        /// <summary>
        /// 总读取字节数
        /// </summary>
        [JsonProperty("TotalReadBytes")]
        public ulong? TotalReadBytes{ get; set; }

        /// <summary>
        /// 总写入条数
        /// </summary>
        [JsonProperty("TotalWriteRecords")]
        public ulong? TotalWriteRecords{ get; set; }

        /// <summary>
        /// 总写入字节数
        /// </summary>
        [JsonProperty("TotalWriteBytes")]
        public ulong? TotalWriteBytes{ get; set; }

        /// <summary>
        /// 写入速度（条/秒）
        /// </summary>
        [JsonProperty("RecordSpeed")]
        public ulong? RecordSpeed{ get; set; }

        /// <summary>
        /// 吞吐（Byte/秒）
        /// </summary>
        [JsonProperty("ByteSpeed")]
        public float? ByteSpeed{ get; set; }

        /// <summary>
        /// 脏数据条数
        /// </summary>
        [JsonProperty("TotalErrorRecords")]
        public ulong? TotalErrorRecords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "TaskState", this.TaskState);
            this.SetParamSimple(map, prefix + "TotalReadRecords", this.TotalReadRecords);
            this.SetParamSimple(map, prefix + "TotalReadBytes", this.TotalReadBytes);
            this.SetParamSimple(map, prefix + "TotalWriteRecords", this.TotalWriteRecords);
            this.SetParamSimple(map, prefix + "TotalWriteBytes", this.TotalWriteBytes);
            this.SetParamSimple(map, prefix + "RecordSpeed", this.RecordSpeed);
            this.SetParamSimple(map, prefix + "ByteSpeed", this.ByteSpeed);
            this.SetParamSimple(map, prefix + "TotalErrorRecords", this.TotalErrorRecords);
        }
    }
}

