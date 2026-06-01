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

    public class DataRetrievalTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>数据检索任务ID<br>示例值：dataretrievaltask-123456</p>
        /// </summary>
        [JsonProperty("DataRetrievalTaskID")]
        public string DataRetrievalTaskID{ get; set; }

        /// <summary>
        /// <p>迁移任务id<br>示例值：migrate-001</p>
        /// </summary>
        [JsonProperty("DataRetrievalId")]
        public string DataRetrievalId{ get; set; }

        /// <summary>
        /// <p>文件系统实例 ID，通过查询文件系统 DescribeCfsFileSystems 获取示例值：cfs-xxxxxx</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>聚合检索条件<br>示例值：from entries|where size &gt;4096</p>
        /// </summary>
        [JsonProperty("CompoundCondition")]
        public string CompoundCondition{ get; set; }

        /// <summary>
        /// <p>列表检索条件</p>
        /// </summary>
        [JsonProperty("QueryCondition")]
        public string QueryCondition{ get; set; }

        /// <summary>
        /// <p>创建时间<br>示例值：2023-01-09 15:03:57</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务状态<br>已完成：completed<br>排队中：waiting<br>进行中：running<br>失败：failed</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>文件数量<br>示例：1000</p>
        /// </summary>
        [JsonProperty("FileNum")]
        public ulong? FileNum{ get; set; }

        /// <summary>
        /// <p>目录数量<br>示例：1000</p>
        /// </summary>
        [JsonProperty("DirNum")]
        public ulong? DirNum{ get; set; }

        /// <summary>
        /// <p>总文件大小，单位KiB<br>示例：1024</p>
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// <p>文件清单下载地址<br>示例值：https://xx-12345.cos.ap-shanghai.myqcloud.com/list.csv</p>
        /// </summary>
        [JsonProperty("FileList")]
        public string FileList{ get; set; }

        /// <summary>
        /// <p>检索错误提示。默认：Null，当Status为failed时，将提示信息展示给用户。</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataRetrievalTaskID", this.DataRetrievalTaskID);
            this.SetParamSimple(map, prefix + "DataRetrievalId", this.DataRetrievalId);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "CompoundCondition", this.CompoundCondition);
            this.SetParamSimple(map, prefix + "QueryCondition", this.QueryCondition);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "FileNum", this.FileNum);
            this.SetParamSimple(map, prefix + "DirNum", this.DirNum);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "FileList", this.FileList);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
        }
    }
}

