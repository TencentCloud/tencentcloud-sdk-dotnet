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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCasterPvwResponse : AbstractModel
    {
        
        /// <summary>
        /// 预监任务的画面rtmp协议预览地址。
        /// 注：该预览地址仅供画面预览，不可分发。
        /// </summary>
        [JsonProperty("PvwPlayUrl")]
        public string PvwPlayUrl{ get; set; }

        /// <summary>
        /// 预监任务的webrtc协议预览画面。
        /// 注：
        /// 1. 该预览地址仅供预览，不可分发。
        /// 2. webrtc播放地址，需配合腾讯云快直播播放sdk使用
        /// </summary>
        [JsonProperty("PvwWebRTCPlayUrl")]
        public string PvwWebRTCPlayUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PvwPlayUrl", this.PvwPlayUrl);
            this.SetParamSimple(map, prefix + "PvwWebRTCPlayUrl", this.PvwWebRTCPlayUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

