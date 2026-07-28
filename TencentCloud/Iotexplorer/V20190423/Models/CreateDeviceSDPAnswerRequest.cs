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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDeviceSDPAnswerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>SDP提议</p>
        /// </summary>
        [JsonProperty("SDPOffer")]
        public string SDPOffer{ get; set; }

        /// <summary>
        /// <p>客户自定义拉流标识</p>
        /// </summary>
        [JsonProperty("RequesterTag")]
        public string RequesterTag{ get; set; }

        /// <summary>
        /// <p>默认值：0，如果需要webrtc推流拉流在同一个SDP中，需要值为1，常用于单PC模式</p><p>枚举值：</p><ul><li>0： 默认值，传统多pc推流模式</li><li>1： 单pc模式，如果需要webrtc单pc推拉流，采用此模式，此模式下注意SDP需要包含推拉流全部信息</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("EnableSubPub")]
        public ulong? EnableSubPub{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "SDPOffer", this.SDPOffer);
            this.SetParamSimple(map, prefix + "RequesterTag", this.RequesterTag);
            this.SetParamSimple(map, prefix + "EnableSubPub", this.EnableSubPub);
        }
    }
}

