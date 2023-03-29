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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordTaskResult : AbstractModel
    {
        
        /// <summary>
        /// AUTO - 自动停止录制， USER_CALL - 用户主动调用停止录制
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// 异常数
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 录制真实开始时间
        /// </summary>
        [JsonProperty("RecordStartTime")]
        public long? RecordStartTime{ get; set; }

        /// <summary>
        /// 录制结束时间
        /// </summary>
        [JsonProperty("RecordStopTime")]
        public long? RecordStopTime{ get; set; }

        /// <summary>
        /// 录制总时长
        /// </summary>
        [JsonProperty("TotalTime")]
        public long? TotalTime{ get; set; }

        /// <summary>
        /// 视频信息列表
        /// </summary>
        [JsonProperty("VideoInfos")]
        public VideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// 被忽略的视频时间段
        /// </summary>
        [JsonProperty("OmittedDurations")]
        public OmittedDuration[] OmittedDurations{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Details")]
        public string Details{ get; set; }

        /// <summary>
        /// 任务失败错误码
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "RecordStartTime", this.RecordStartTime);
            this.SetParamSimple(map, prefix + "RecordStopTime", this.RecordStopTime);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamArrayObj(map, prefix + "OmittedDurations.", this.OmittedDurations);
            this.SetParamSimple(map, prefix + "Details", this.Details);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
        }
    }
}

