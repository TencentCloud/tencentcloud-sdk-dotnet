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

    public class CreateCasterPgmFromPvwResponse : AbstractModel
    {
        
        /// <summary>
        /// 主监任务的rtmp协议预览地址。 
        /// 注：该地址仅供预览，不可分发。
        /// </summary>
        [JsonProperty("PgmPlayUrl")]
        public string PgmPlayUrl{ get; set; }

        /// <summary>
        /// 注：该字段已废弃，请结合腾讯云直播播放地址生成策略生成cdn播放地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdnPlayUrl")]
        public string CdnPlayUrl{ get; set; }

        /// <summary>
        /// 主监任务在腾讯云直播侧的流ID。
        /// </summary>
        [JsonProperty("CdnStreamId")]
        public string CdnStreamId{ get; set; }

        /// <summary>
        /// 主监任务的webrtc协议播放地址。 
        /// 注：
        /// 1.该预览地址仅作为预览，不可分发。
        /// 2.webrtc播放地址需配合腾讯云快直播播放sdk使用。
        /// </summary>
        [JsonProperty("PgmWebRTCPlayUrl")]
        public string PgmWebRTCPlayUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "PgmPlayUrl", this.PgmPlayUrl);
            this.SetParamSimple(map, prefix + "CdnPlayUrl", this.CdnPlayUrl);
            this.SetParamSimple(map, prefix + "CdnStreamId", this.CdnStreamId);
            this.SetParamSimple(map, prefix + "PgmWebRTCPlayUrl", this.PgmWebRTCPlayUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

