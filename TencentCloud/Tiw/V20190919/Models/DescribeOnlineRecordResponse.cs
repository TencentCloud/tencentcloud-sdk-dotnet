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

    public class DescribeOnlineRecordResponse : AbstractModel
    {
        
        /// <summary>
        /// 录制结束原因，
        /// - AUTO: 房间内长时间没有音视频上行及白板操作导致自动停止录制
        /// - USER_CALL: 主动调用了停止录制接口
        /// - EXCEPTION: 录制异常结束
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// 需要查询结果的录制任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 录制任务状态
        /// - PREPARED: 表示录制正在准备中（进房/启动录制服务等操作）
        /// - RECORDING: 表示录制已开始
        /// - PAUSED: 表示录制已暂停
        /// - STOPPED: 表示录制已停止，正在处理并上传视频
        /// - FINISHED: 表示视频处理并上传完成，成功生成录制结果
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 白板的群组 Id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 录制用户Id
        /// </summary>
        [JsonProperty("RecordUserId")]
        public string RecordUserId{ get; set; }

        /// <summary>
        /// 实际开始录制时间，Unix 时间戳，单位秒
        /// </summary>
        [JsonProperty("RecordStartTime")]
        public long? RecordStartTime{ get; set; }

        /// <summary>
        /// 实际停止录制时间，Unix 时间戳，单位秒
        /// </summary>
        [JsonProperty("RecordStopTime")]
        public long? RecordStopTime{ get; set; }

        /// <summary>
        /// 回放视频总时长（单位：毫秒）
        /// </summary>
        [JsonProperty("TotalTime")]
        public long? TotalTime{ get; set; }

        /// <summary>
        /// 录制过程中出现异常的次数
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// 拼接视频中被忽略的时间段，只有开启视频拼接功能的时候，这个参数才是有效的
        /// </summary>
        [JsonProperty("OmittedDurations")]
        public OmittedDuration[] OmittedDurations{ get; set; }

        /// <summary>
        /// 录制视频列表
        /// </summary>
        [JsonProperty("VideoInfos")]
        public VideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "RecordUserId", this.RecordUserId);
            this.SetParamSimple(map, prefix + "RecordStartTime", this.RecordStartTime);
            this.SetParamSimple(map, prefix + "RecordStopTime", this.RecordStopTime);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamArrayObj(map, prefix + "OmittedDurations.", this.OmittedDurations);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

