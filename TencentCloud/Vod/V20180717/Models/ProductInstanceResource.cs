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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductInstanceResource : AbstractModel
    {
        
        /// <summary>
        /// <p>资源类型。</p><p>枚举值：</p><ul><li>Storage： 存储资源</li><li>Traffic： 流量资源</li><li>Transcode： 转码资源</li><li>TESHD： 极速高清转码资源</li><li>Review： 音视频审核资源</li><li>MediaProcess： 媒体处理资源</li><li>MLLMMediaProcess： 大模型媒体处理资源</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>资源包额度。</p><li>音视频存储资源包，单位为字节。</li><li>音视频转码资源包，单位为秒。</li><li>音视频审核资源包，单位为秒。</li><li>音视频极速高清资源包，单位为秒。</li><li>音视频加速资源包，单位为字节。</li><li>媒体处理时长资源包，单位为秒。</li>
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// <p>资源包余量。</p><li>音视频存储资源包，单位为字节。</li><li>音视频转码资源包，单位为秒。</li><li>音视频审核资源包，单位为秒。</li><li>音视频极速高清资源包，单位为秒。</li><li>音视频加速资源包，单位为字节。</li><li>媒体处理时长资源包，单位为秒。</li>
        /// </summary>
        [JsonProperty("Left")]
        public long? Left{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "Left", this.Left);
        }
    }
}

