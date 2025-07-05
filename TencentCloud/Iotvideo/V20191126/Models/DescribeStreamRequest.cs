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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备TID
        /// </summary>
        [JsonProperty("Tid")]
        public string Tid{ get; set; }

        /// <summary>
        /// 终端用户ID
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// 直播协议, 可选值：RTSP、RTMP、HLS、HLS-fmp4
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 音视频流地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 设备访问token，访问用户未绑定的设备时，需提供该参数
        /// </summary>
        [JsonProperty("AccessToken")]
        public string AccessToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "AccessToken", this.AccessToken);
        }
    }
}

