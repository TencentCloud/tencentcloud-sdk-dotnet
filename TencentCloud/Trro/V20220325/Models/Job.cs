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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>任务类型：1 单视频，2 批量</p><p>枚举值：</p><ul><li>1： 单视频</li><li>2： 批量</li></ul>
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// <p>标注模式：3 精标注</p><p>枚举值：</p><ul><li>3： 精标注</li></ul>
        /// </summary>
        [JsonProperty("AnnotationType")]
        public long? AnnotationType{ get; set; }

        /// <summary>
        /// <p>任务状态：1 处理中，2 异常，3 成功</p><p>枚举值：</p><ul><li>1： 处理中</li><li>2： 异常</li><li>3： 成功</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>文件列举状态：0 列举中，1 全部加载，2 超过数量上限截断（仅批量任务）</p><p>枚举值：</p><ul><li>0： 列举中</li><li>1： 全部加载</li><li>2： 超过数量上限截断（仅批量任务）</li></ul>
        /// </summary>
        [JsonProperty("IngestStatus")]
        public long? IngestStatus{ get; set; }

        /// <summary>
        /// <p>输入路径（S3源为桶名/对象路径：批量任务为目录前缀，单文件为文件完整路径；HTTP源为完整URL）</p>
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }

        /// <summary>
        /// <p>处理项总数</p>
        /// </summary>
        [JsonProperty("TotalNumber")]
        public long? TotalNumber{ get; set; }

        /// <summary>
        /// <p>创建时间，Unix 时间戳（秒）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>完成时间，Unix 时间戳（秒），未完成为 0</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "AnnotationType", this.AnnotationType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IngestStatus", this.IngestStatus);
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
            this.SetParamSimple(map, prefix + "TotalNumber", this.TotalNumber);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
        }
    }
}

