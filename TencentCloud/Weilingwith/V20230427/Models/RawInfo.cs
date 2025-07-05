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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RawInfo : AbstractModel
    {
        
        /// <summary>
        /// 加密向量（如果视频网关选择流为非加密传输这个参数可忽略）
        /// </summary>
        [JsonProperty("SM4Vector")]
        public string SM4Vector{ get; set; }

        /// <summary>
        /// 专线ip (非专线接入可忽略)
        /// </summary>
        [JsonProperty("NATIP")]
        public string NATIP{ get; set; }

        /// <summary>
        /// 客户端握手鉴权参数
        /// </summary>
        [JsonProperty("StreamToken")]
        public string StreamToken{ get; set; }

        /// <summary>
        /// 拉流端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 视频流加密key,目前为AES128加密KEY（如果视频网关选择流为非加密传输这个参数可忽略）
        /// </summary>
        [JsonProperty("StreamEnKey")]
        public string StreamEnKey{ get; set; }

        /// <summary>
        /// 拉流公网地址（非公网接入时，这个地址是内网地址）
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 拉流内网地址
        /// </summary>
        [JsonProperty("InnerIP")]
        public string InnerIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SM4Vector", this.SM4Vector);
            this.SetParamSimple(map, prefix + "NATIP", this.NATIP);
            this.SetParamSimple(map, prefix + "StreamToken", this.StreamToken);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "StreamEnKey", this.StreamEnKey);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "InnerIP", this.InnerIP);
        }
    }
}

