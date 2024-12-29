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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCasterPlayUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 播放url。
        /// 当导播台不存在预监或主监时，若请求预监或主监的播放地址，该字段为空。
        /// </summary>
        [JsonProperty("PlayUrl")]
        public string PlayUrl{ get; set; }

        /// <summary>
        /// webrtc协议播放地址。
        /// 当导播台不存在预监或主监时，若请求预监或主监的webrtc播放地址，该字段为空。
        /// 注：webrtc协议播放地址需配合腾讯云快直播播放sdk方可使用。
        /// </summary>
        [JsonProperty("WebRTCPlayUrl")]
        public string WebRTCPlayUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "PlayUrl", this.PlayUrl);
            this.SetParamSimple(map, prefix + "WebRTCPlayUrl", this.WebRTCPlayUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

