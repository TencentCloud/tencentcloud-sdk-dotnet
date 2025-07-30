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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleDataTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态.
        /// init：未执行
        /// running：执行中，finished：已完成
        /// ,failed：失败
        /// ,stopping：停止中,stopped：已停止
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 文件总数
        /// </summary>
        [JsonProperty("FileTotalCount")]
        public ulong? FileTotalCount{ get; set; }

        /// <summary>
        /// 处理成功文件数量
        /// </summary>
        [JsonProperty("FileSuccessedCount")]
        public ulong? FileSuccessedCount{ get; set; }

        /// <summary>
        /// 当前已经失败的文件数
        /// </summary>
        [JsonProperty("FileFailedCount")]
        public ulong? FileFailedCount{ get; set; }

        /// <summary>
        /// 文件容量，单位Byte
        /// 
        /// </summary>
        [JsonProperty("FileTotalSize")]
        public ulong? FileTotalSize{ get; set; }

        /// <summary>
        /// 已处理完成的文件容量，单位Byte
        /// 
        /// </summary>
        [JsonProperty("FileSuccessedSize")]
        public ulong? FileSuccessedSize{ get; set; }

        /// <summary>
        /// 已处理失败文件容量，单位Byte
        /// </summary>
        [JsonProperty("FileFailedSize")]
        public ulong? FileFailedSize{ get; set; }

        /// <summary>
        /// 总文件列表
        /// </summary>
        [JsonProperty("FileTotalList")]
        public string FileTotalList{ get; set; }

        /// <summary>
        /// 成功的文件列表
        /// </summary>
        [JsonProperty("FileSuccessedList")]
        public string FileSuccessedList{ get; set; }

        /// <summary>
        /// 失败文件的列表
        /// </summary>
        [JsonProperty("FileFailedList")]
        public string FileFailedList{ get; set; }

        /// <summary>
        /// FileSystemId
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务路径
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// 任务类型,archive:表示沉降任务，restore：表示拉取任务
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据流动Id
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "FileTotalCount", this.FileTotalCount);
            this.SetParamSimple(map, prefix + "FileSuccessedCount", this.FileSuccessedCount);
            this.SetParamSimple(map, prefix + "FileFailedCount", this.FileFailedCount);
            this.SetParamSimple(map, prefix + "FileTotalSize", this.FileTotalSize);
            this.SetParamSimple(map, prefix + "FileSuccessedSize", this.FileSuccessedSize);
            this.SetParamSimple(map, prefix + "FileFailedSize", this.FileFailedSize);
            this.SetParamSimple(map, prefix + "FileTotalList", this.FileTotalList);
            this.SetParamSimple(map, prefix + "FileSuccessedList", this.FileSuccessedList);
            this.SetParamSimple(map, prefix + "FileFailedList", this.FileFailedList);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskPath", this.TaskPath);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataFlowId", this.DataFlowId);
        }
    }
}

