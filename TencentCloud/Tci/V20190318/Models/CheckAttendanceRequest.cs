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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckAttendanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入数据
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 输入类型，picture_url:图片，vod_url:视频文件
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 人员库 ID
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// 人员 ID 列表
        /// </summary>
        [JsonProperty("PersonIdSet")]
        public string[] PersonIdSet{ get; set; }

        /// <summary>
        /// 确定出勤阀值；默认为0.92
        /// </summary>
        [JsonProperty("AttendanceThreshold")]
        public float? AttendanceThreshold{ get; set; }

        /// <summary>
        /// 考勤结束时间（到视频的第几秒结束考勤），单位秒；默认为900
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 考勤开始时间（从视频的第几秒开始考勤），单位秒；默认为0
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 识别阈值；默认为0.7
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamArraySimple(map, prefix + "PersonIdSet.", this.PersonIdSet);
            this.SetParamSimple(map, prefix + "AttendanceThreshold", this.AttendanceThreshold);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

