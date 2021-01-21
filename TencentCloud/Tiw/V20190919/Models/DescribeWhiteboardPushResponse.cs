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

    public class DescribeWhiteboardPushResponse : AbstractModel
    {
        
        /// <summary>
        /// 推流结束原因，
        /// - AUTO: 房间内长时间没有音视频上行及白板操作导致自动停止推流
        /// - USER_CALL: 主动调用了停止推流接口
        /// - EXCEPTION: 推流异常结束
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// 需要查询结果的白板推流任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 推流任务状态
        /// - PREPARED: 表示推流正在准备中（进房/启动推流服务等操作）
        /// - PUSHING: 表示推流已开始
        /// - STOPPED: 表示推流已停止
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
        /// 推流用户Id
        /// </summary>
        [JsonProperty("PushUserId")]
        public string PushUserId{ get; set; }

        /// <summary>
        /// 实际开始推流时间，Unix 时间戳，单位秒
        /// </summary>
        [JsonProperty("PushStartTime")]
        public long? PushStartTime{ get; set; }

        /// <summary>
        /// 实际停止推流时间，Unix 时间戳，单位秒
        /// </summary>
        [JsonProperty("PushStopTime")]
        public long? PushStopTime{ get; set; }

        /// <summary>
        /// 推流过程中出现异常的次数
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// 白板推流首帧对应的IM时间戳，可用于录制回放时IM聊天消息与白板推流视频进行同步对时。
        /// </summary>
        [JsonProperty("IMSyncTime")]
        public long? IMSyncTime{ get; set; }

        /// <summary>
        /// 备份推流任务结果信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Backup")]
        public string Backup{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PushUserId", this.PushUserId);
            this.SetParamSimple(map, prefix + "PushStartTime", this.PushStartTime);
            this.SetParamSimple(map, prefix + "PushStopTime", this.PushStopTime);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamSimple(map, prefix + "IMSyncTime", this.IMSyncTime);
            this.SetParamSimple(map, prefix + "Backup", this.Backup);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

