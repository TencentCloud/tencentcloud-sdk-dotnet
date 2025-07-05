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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomRecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("StopTime")]
        public ulong? StopTime{ get; set; }

        /// <summary>
        /// 总时长
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 文件格式
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// 流url
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// 流大小
        /// </summary>
        [JsonProperty("RecordSize")]
        public ulong? RecordSize{ get; set; }

        /// <summary>
        /// 流ID
        /// </summary>
        [JsonProperty("VideoId")]
        public string VideoId{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "RecordSize", this.RecordSize);
            this.SetParamSimple(map, prefix + "VideoId", this.VideoId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

