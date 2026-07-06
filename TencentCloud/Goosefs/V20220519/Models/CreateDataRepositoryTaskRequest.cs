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

    public class CreateDataRepositoryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据流通任务类型, FS_TO_COS(文件系统到COS Bucket),或者COS_TO_FS(COS Bucket到文件系统)</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>COS存储桶名</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>文件系统ID</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>对于FS_TO_COS, TaskPath是Bucket映射目录的相对路径, 对于COS_TO_FS是COS上的路径。如果置为空, 则表示全部数据</p>
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务路径是否表示绝对路径（暂时仅支持沉降使用）</p>
        /// </summary>
        [JsonProperty("IsTaskPathAbsolute")]
        public bool? IsTaskPathAbsolute{ get; set; }

        /// <summary>
        /// <p>数据流通方式 MSP_AFM 手动加载  RAW_AFM 按需加载</p>
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// <p>文件列表下载地址，以http开头</p>
        /// </summary>
        [JsonProperty("TextLocation")]
        public string TextLocation{ get; set; }

        /// <summary>
        /// <p>是否开启自定义路径(暂时仅供预热使用)</p>
        /// </summary>
        [JsonProperty("EnableDataFlowSubPath")]
        [System.Obsolete]
        public bool? EnableDataFlowSubPath{ get; set; }

        /// <summary>
        /// <p>自定义路径(暂时仅供预热使用)</p>
        /// </summary>
        [JsonProperty("DataFlowSubPath")]
        [System.Obsolete]
        public string DataFlowSubPath{ get; set; }

        /// <summary>
        /// <p>是否开启自定义目的路径（预热任务表示本地路径，沉降任务表示COS桶前缀）</p>
        /// </summary>
        [JsonProperty("EnableCustomDestPath")]
        public bool? EnableCustomDestPath{ get; set; }

        /// <summary>
        /// <p>自定义目的路径（预热任务表示本地路径，沉降任务表示COS桶前缀）</p>
        /// </summary>
        [JsonProperty("CustomDestPath")]
        public string CustomDestPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "TaskPath", this.TaskPath);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "IsTaskPathAbsolute", this.IsTaskPathAbsolute);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "TextLocation", this.TextLocation);
            this.SetParamSimple(map, prefix + "EnableDataFlowSubPath", this.EnableDataFlowSubPath);
            this.SetParamSimple(map, prefix + "DataFlowSubPath", this.DataFlowSubPath);
            this.SetParamSimple(map, prefix + "EnableCustomDestPath", this.EnableCustomDestPath);
            this.SetParamSimple(map, prefix + "CustomDestPath", this.CustomDestPath);
        }
    }
}

