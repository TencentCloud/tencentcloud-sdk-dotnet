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
        /// 需要推流的白板房间号，取值范围: (1, 4294967295)。
        /// 
        /// 在没有指定TRTCRoomId和TRTCRoomIdStr的情况下，默认会以RoomId作为白板流进行推流的TRTC房间号。
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 用于白板推流服务进入白板房间的用户ID。在没有进行额外指定的情况下，这个用户ID同时会用于IM登录、IM加群、TRTC进房推流等操作。
        /// 用户ID最大长度不能大于60个字节，该ID必须是一个单独的未在SDK中使用的ID，白板推流服务使用这个用户ID进入房间进行白板音视频推流，若该ID和SDK中使用的ID重复，会导致SDK和白板推流服务互踢，影响正常推流。
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
        /// 自动停止推流超时时间，单位秒，取值范围[300, 43200], 默认值为1800秒。
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
        /// TRTC高级权限控制参数，如果在实时音视频开启了高级权限控制功能，必须提供PrivateMapKey才能保证正常推流。
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }

        /// <summary>
        /// 白板推流视频帧率，取值范围[0, 30]，默认20fps
        /// </summary>
        [JsonProperty("VideoFPS")]
        public long? VideoFPS{ get; set; }

        /// <summary>
        /// 白板推流码率， 取值范围[0, 2000]，默认1200kbps。
        /// 
        /// 这里的码率设置是一个参考值，实际推流的时候使用的是动态码率，所以真实码率不会固定为指定值，会在指定值附近波动。
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

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
        /// 指定白板推流录制的RecordID，指定的RecordID会用于填充实时音视频云端录制完成后的回调消息中的 "userdefinerecordid" 字段内容，便于您更方便的识别录制回调，以及在点播媒体资源管理中查找相应的录制视频文件。
        /// 
        /// 限制长度为64字节，只允许包含大小写英文字母（a-zA-Z）、数字（0-9）及下划线和连词符。
        /// 
        /// 此字段设置后，不管`AutoRecord`字段取值如何，都将自动进行白板推流录制。
        /// 
        /// 默认RecordId生成规则如下：
        /// urlencode(SdkAppID_RoomID_PushUserID)
        /// 
        /// 例如：
        /// SdkAppID = 12345678，RoomID = 12345，PushUserID = push_user_1
        /// 那么：RecordId = 12345678_12345_push_user_1
        /// </summary>
        [JsonProperty("UserDefinedRecordId")]
        public string UserDefinedRecordId{ get; set; }

        /// <summary>
        /// 在实时音视频旁路推流模式选择为`指定用户旁路`模式的时候，是否自动旁路白板推流。
        /// 
        /// 默认在实时音视频的旁路推流模式选择为 `指定用户旁路` 模式的情况下，不会自动旁路白板推流，如果希望旁路白板推流，请将此参数设置为true。
        /// 
        /// 如果实时音视频的旁路推流模式选择为 `全局自动旁路` 模式，可忽略此参数。
        /// </summary>
        [JsonProperty("AutoPublish")]
        public bool? AutoPublish{ get; set; }

        /// <summary>
        /// 指定实时音视频在旁路白板推流时的StreamID，设置之后，您就可以在腾讯云直播 CDN 上通过标准直播方案（FLV或HLS）播放该用户的音视频流。
        /// 
        /// 限制长度为64字节，只允许包含大小写英文字母（a-zA-Z）、数字（0-9）及下划线和连词符。
        /// 
        /// 此字段设置后，不管`AutoPublish`字段取值如何，都将自动旁路白板推流。
        /// 
        /// 默认StreamID生成规则如下：
        /// urlencode(SdkAppID_RoomID_PushUserID_main)
        /// 
        /// 例如：
        /// SdkAppID = 12345678，RoomID = 12345，PushUserID = push_user_1
        /// 那么：StreamID = 12345678_12345_push_user_1_main
        /// </summary>
        [JsonProperty("UserDefinedStreamId")]
        public string UserDefinedStreamId{ get; set; }

        /// <summary>
        /// 内部参数，不需要关注此参数
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// TRTC数字类型房间号，取值范围: (1, 4294967295)。
        /// 
        /// 在同时指定了RoomId与TRTCRoomId的情况下，优先使用TRTCRoomId作为白板流进行推流的TRTC房间号。
        /// 
        /// 当指定了TRTCRoomIdStr的情况下，此字段将被忽略。
        /// </summary>
        [JsonProperty("TRTCRoomId")]
        public long? TRTCRoomId{ get; set; }

        /// <summary>
        /// TRTC字符串类型房间号。
        /// 
        /// 在指定了TRTCRoomIdStr的情况下，会优先使用TRTCRoomIdStr作为白板流进行推流的TRTC房间号。
        /// </summary>
        [JsonProperty("TRTCRoomIdStr")]
        public string TRTCRoomIdStr{ get; set; }

        /// <summary>
        /// 内测参数，需开通白名单进行体验。
        /// 
        /// IM鉴权信息参数，用于IM鉴权。
        /// 当白板信令所使用的IM应用与白板应用的SdkAppId不一致时，可以通过此参数提供对应IM应用鉴权信息。
        /// 
        /// 如果提供了此参数，白板推流服务会优先使用此参数指定的SdkAppId作为白板信令的传输通道，否则使用公共参数中的SdkAppId作为白板信令的传输通道。
        /// </summary>
        [JsonProperty("IMAuthParam")]
        public AuthParam IMAuthParam{ get; set; }

        /// <summary>
        /// 内测参数，需开通白名单进行体验。
        /// 
        /// TRTC鉴权信息参数，用于TRTC进房推流鉴权。
        /// 当需要推流到的TRTC房间所对应的TRTC应用与白板应用的SdkAppId不一致时，可以通过此参数提供对应的TRTC应用鉴权信息。
        /// 
        /// 如果提供了此参数，白板推流服务会优先使用此参数指定的SdkAppId作为白板推流的目标TRTC应用，否则使用公共参数中的SdkAppId作为白板推流的目标TRTC应用。
        /// </summary>
        [JsonProperty("TRTCAuthParam")]
        public AuthParam TRTCAuthParam{ get; set; }


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
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
            this.SetParamSimple(map, prefix + "VideoFPS", this.VideoFPS);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "AutoRecord", this.AutoRecord);
            this.SetParamSimple(map, prefix + "UserDefinedRecordId", this.UserDefinedRecordId);
            this.SetParamSimple(map, prefix + "AutoPublish", this.AutoPublish);
            this.SetParamSimple(map, prefix + "UserDefinedStreamId", this.UserDefinedStreamId);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "TRTCRoomId", this.TRTCRoomId);
            this.SetParamSimple(map, prefix + "TRTCRoomIdStr", this.TRTCRoomIdStr);
            this.SetParamObj(map, prefix + "IMAuthParam.", this.IMAuthParam);
            this.SetParamObj(map, prefix + "TRTCAuthParam.", this.TRTCAuthParam);
        }
    }
}

