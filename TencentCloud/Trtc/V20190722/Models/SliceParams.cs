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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SliceParams : AbstractModel
    {
        
        /// <summary>
        /// 切片任务类型:
        /// 1:音频切片；
        /// 2:视频截帧；
        /// 3:音视切片+视频截帧
        /// 示例值：1 
        /// </summary>
        [JsonProperty("SliceType")]
        public ulong? SliceType{ get; set; }

        /// <summary>
        /// 房间内持续没有主播的状态超过MaxIdleTime的时长，自动停止录制，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。
        /// 示例值：30
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 音频切片时长，默认15s 示例值：15
        /// 取值范围15-60s
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// 视频截帧间隔时长，默认5s， 示例值：5 取值范围5-60s
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// 指定订阅流白名单或者黑名单。
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// 已废弃，从控制台配置回调url
        /// </summary>
        [JsonProperty("SliceCallbackUrl")]
        public string SliceCallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SliceType", this.SliceType);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SliceAudio", this.SliceAudio);
            this.SetParamSimple(map, prefix + "SliceVideo", this.SliceVideo);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
            this.SetParamSimple(map, prefix + "SliceCallbackUrl", this.SliceCallbackUrl);
        }
    }
}

