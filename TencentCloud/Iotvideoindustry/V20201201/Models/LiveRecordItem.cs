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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveRecordItem : AbstractModel
    {
        
        /// <summary>
        /// 录制文件自增ID
        /// </summary>
        [JsonProperty("IntID")]
        public long? IntID{ get; set; }

        /// <summary>
        /// 直播频道ID
        /// </summary>
        [JsonProperty("LiveChannelId")]
        public string LiveChannelId{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpectDeleteTime")]
        public long? ExpectDeleteTime{ get; set; }

        /// <summary>
        /// 录制时长
        /// </summary>
        [JsonProperty("RecordTimeLen")]
        public long? RecordTimeLen{ get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// 录制文件url
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 录制计划ID
        /// </summary>
        [JsonProperty("RecordPlanId")]
        public string RecordPlanId{ get; set; }

        /// <summary>
        /// 录制开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 录制结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntID", this.IntID);
            this.SetParamSimple(map, prefix + "LiveChannelId", this.LiveChannelId);
            this.SetParamSimple(map, prefix + "ExpectDeleteTime", this.ExpectDeleteTime);
            this.SetParamSimple(map, prefix + "RecordTimeLen", this.RecordTimeLen);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "RecordPlanId", this.RecordPlanId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

