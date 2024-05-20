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

    public class StartAITranscriptionRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，使用该sdkappid开启任务。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC的[RoomId](https://cloud.tencent.com/document/product/647/46351#roomid)，使用该roomid开启任务。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 启动转录机器人和鉴权的参数。
        /// </summary>
        [JsonProperty("TranscriptionParams")]
        public TranscriptionParams TranscriptionParams{ get; set; }

        /// <summary>
        /// TRTC房间号的类型，0代表数字房间号，1代表字符串房间号。不填默认是数字房间号。
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 语音识别配置
        /// </summary>
        [JsonProperty("RecognizeConfig")]
        public RecognizeConfig RecognizeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamObj(map, prefix + "TranscriptionParams.", this.TranscriptionParams);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "RecognizeConfig.", this.RecognizeConfig);
        }
    }
}

