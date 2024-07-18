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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartStreamIngestRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和TRTC的房间所对应的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC的[RoomId](https://cloud.tencent.com/document/product/647/46351#roomid)，录制的TRTC房间所对应的RoomId。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// TRTC房间号的类型。
        /// 【*注意】必须和录制的房间所对应的RoomId类型相同:
        /// 0: 字符串类型的RoomId
        /// 1: 32位整型的RoomId（默认）
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 输入在线媒体流机器人的UserId，用于进房发起拉流转推任务。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 输入在线媒体流机器人UserId对应的校验签名，即UserId和UserSig相当于机器人进房的登录密码，具体计算方法请参考TRTC计算[UserSig](https://cloud.tencent.com/document/product/647/45910#UserSig)的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// 源流URL【必填】。如果是视频流，分辨率请保持不变。
        /// </summary>
        [JsonProperty("StreamUrl")]
        public string StreamUrl{ get; set; }

        /// <summary>
        /// TRTC房间权限加密串，只有在TRTC控制台启用了高级权限控制的时候需要携带，在TRTC控制台如果开启高级权限控制后，TRTC 的后台服务系统会校验一个叫做 [PrivateMapKey] 的“权限票据”，权限票据中包含了一个加密后的 RoomId 和一个加密后的“权限位列表”。由于 PrivateMapKey 中包含 RoomId，所以只提供了 UserSig 没有提供 PrivateMapKey 时，并不能进入指定的房间。
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }

        /// <summary>
        /// 【本字段已废弃】视频编码参数。可选，如果不填，保持原始流的参数。
        /// </summary>
        [JsonProperty("VideoEncodeParams")]
        [System.Obsolete]
        public VideoEncodeParams VideoEncodeParams{ get; set; }

        /// <summary>
        /// 【本字段已废弃】音频编码参数。可选，如果不填，保持原始流的参数。
        /// </summary>
        [JsonProperty("AudioEncodeParams")]
        [System.Obsolete]
        public AudioEncodeParams AudioEncodeParams{ get; set; }

        /// <summary>
        /// 【本字段已废弃，请使用 StreamUrl 字段】源流URL，支持一个地址。
        /// </summary>
        [JsonProperty("SourceUrl")]
        [System.Obsolete]
        public string[] SourceUrl{ get; set; }

        /// <summary>
        /// 指定视频从某个秒时间戳播放
        /// </summary>
        [JsonProperty("SeekSecond")]
        public long? SeekSecond{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "StreamUrl", this.StreamUrl);
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
            this.SetParamObj(map, prefix + "VideoEncodeParams.", this.VideoEncodeParams);
            this.SetParamObj(map, prefix + "AudioEncodeParams.", this.AudioEncodeParams);
            this.SetParamArraySimple(map, prefix + "SourceUrl.", this.SourceUrl);
            this.SetParamSimple(map, prefix + "SeekSecond", this.SeekSecond);
        }
    }
}

