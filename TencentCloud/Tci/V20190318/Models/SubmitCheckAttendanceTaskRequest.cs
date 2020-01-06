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

    public class SubmitCheckAttendanceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入数据
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 视频流类型，vod_url表示点播URL，live_url表示直播URL，默认vod_url
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 人员库 ID列表
        /// </summary>
        [JsonProperty("LibraryIds")]
        public string[] LibraryIds{ get; set; }

        /// <summary>
        /// 确定出勤阈值；默认为0.92
        /// </summary>
        [JsonProperty("AttendanceThreshold")]
        public float? AttendanceThreshold{ get; set; }

        /// <summary>
        /// 是否开启陌生人模式，陌生人模式是指在任务中发现的非注册人脸库中的人脸也返回相关统计信息，默认不开启
        /// </summary>
        [JsonProperty("EnableStranger")]
        public bool? EnableStranger{ get; set; }

        /// <summary>
        /// 考勤结束时间（到视频的第几秒结束考勤），单位秒；默认为900 
        /// 对于直播场景，使用绝对时间戳，单位秒，默认当前时间往后12小时
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 通知回调地址，要求方法为post，application/json格式
        /// </summary>
        [JsonProperty("NoticeUrl")]
        public string NoticeUrl{ get; set; }

        /// <summary>
        /// 考勤开始时间（从视频的第几秒开始考勤），单位秒；默认为0 
        /// 对于直播场景，使用绝对时间戳，单位秒，默认当前时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 识别阈值；默认为0.8
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "LibraryIds.", this.LibraryIds);
            this.SetParamSimple(map, prefix + "AttendanceThreshold", this.AttendanceThreshold);
            this.SetParamSimple(map, prefix + "EnableStranger", this.EnableStranger);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NoticeUrl", this.NoticeUrl);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

