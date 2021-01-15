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

    public class StartWhiteboardPushRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 需要推流白板的房间号，取值范围: (1, 4294967295)
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 用于白板推流服务进房进行推流的用户ID，
        /// 该ID必须是一个单独的未在SDK中使用的ID，白板推流服务使用这个用户ID进入房间进行白板音视频推流，若该ID和SDK中使用的ID重复，会导致SDK和白板推流服务互踢，影响正常推流。
        /// </summary>
        [JsonProperty("PushUserId")]
        public string PushUserId{ get; set; }

        /// <summary>
        /// 与PushUserId对应的签名
        /// </summary>
        [JsonProperty("PushUserSig")]
        public string PushUserSig{ get; set; }

        /// <summary>
        /// 白板参数，例如白板宽高、背景颜色等
        /// </summary>
        [JsonProperty("Whiteboard")]
        public Whiteboard Whiteboard{ get; set; }

        /// <summary>
        /// 自动停止推流超时时间，单位秒，取值范围[300, 259200], 默认值为1800秒。
        /// 
        /// 当白板超过设定时间没有操作的时候，白板推流服务会自动停止白板推流。
        /// </summary>
        [JsonProperty("AutoStopTimeout")]
        public long? AutoStopTimeout{ get; set; }

        /// <summary>
        /// 对主白板推流任务进行操作时，是否同时同步操作备份任务
        /// </summary>
        [JsonProperty("AutoManageBackup")]
        public bool? AutoManageBackup{ get; set; }

        /// <summary>
        /// 备份白板推流相关参数。
        /// 
        /// 指定了备份参数的情况下，白板推流服务会在房间内新增一路白板画面视频流，即同一个房间内会有两路白板画面推流。
        /// </summary>
        [JsonProperty("Backup")]
        public WhiteboardPushBackupParam Backup{ get; set; }

        /// <summary>
        /// 在实时音视频云端录制模式选择为 `指定用户录制` 模式的时候是否自动录制白板推流。
        /// 
        /// 默认在实时音视频的云端录制模式选择为 `指定用户录制` 模式的情况下，不会自动进行白板推流录制，如果希望进行白板推流录制，请将此参数设置为true。
        /// 
        /// 如果实时音视频的云端录制模式选择为 `全局自动录制` 模式，可忽略此参数。
        /// </summary>
        [JsonProperty("AutoRecord")]
        public bool? AutoRecord{ get; set; }

        /// <summary>
        /// 内部参数，不需要关注此参数
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "PushUserId", this.PushUserId);
            this.SetParamSimple(map, prefix + "PushUserSig", this.PushUserSig);
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamSimple(map, prefix + "AutoStopTimeout", this.AutoStopTimeout);
            this.SetParamSimple(map, prefix + "AutoManageBackup", this.AutoManageBackup);
            this.SetParamObj(map, prefix + "Backup.", this.Backup);
            this.SetParamSimple(map, prefix + "AutoRecord", this.AutoRecord);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
        }
    }
}

