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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamAddress : AbstractModel
    {
        
        /// <summary>
        /// 流ID
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// rtsp流地址
        /// </summary>
        [JsonProperty("RtspAddr")]
        public string RtspAddr{ get; set; }

        /// <summary>
        /// rtmp流地址
        /// </summary>
        [JsonProperty("RtmpAddr")]
        public string RtmpAddr{ get; set; }

        /// <summary>
        /// hls流地址
        /// </summary>
        [JsonProperty("HlsAddr")]
        public string HlsAddr{ get; set; }

        /// <summary>
        /// flv流地址
        /// </summary>
        [JsonProperty("FlvAddr")]
        public string FlvAddr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "RtspAddr", this.RtspAddr);
            this.SetParamSimple(map, prefix + "RtmpAddr", this.RtmpAddr);
            this.SetParamSimple(map, prefix + "HlsAddr", this.HlsAddr);
            this.SetParamSimple(map, prefix + "FlvAddr", this.FlvAddr);
        }
    }
}

