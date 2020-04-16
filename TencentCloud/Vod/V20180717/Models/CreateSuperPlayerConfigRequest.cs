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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSuperPlayerConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 播放器配置名称，长度限制：64 个字符。只允许出现 [0-9a-zA-Z] 及 _- 字符（如 test_ABC-123），同一个用户该名称唯一。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 播放 DRM 保护的自适应码流开关：
        /// <li>ON：开启，表示仅播放 DRM  保护的自适应码流输出；</li>
        /// <li>OFF：关闭，表示播放未加密的自适应码流输出。</li>
        /// 默认为 OFF。
        /// </summary>
        [JsonProperty("DrmSwitch")]
        public string DrmSwitch{ get; set; }

        /// <summary>
        /// 允许输出的未加密的自适应码流模板 ID，当 DrmSwitch 为 OFF 时必填。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingDefinition")]
        public ulong? AdaptiveDynamicStreamingDefinition{ get; set; }

        /// <summary>
        /// 允许输出的 DRM 自适应码流模板内容，当 DrmSwitch 为 ON 时必填。
        /// </summary>
        [JsonProperty("DrmStreamingsInfo")]
        public DrmStreamingsInfo DrmStreamingsInfo{ get; set; }

        /// <summary>
        /// 允许输出的雪碧图模板 ID。
        /// </summary>
        [JsonProperty("ImageSpriteDefinition")]
        public ulong? ImageSpriteDefinition{ get; set; }

        /// <summary>
        /// 播放器对不于不同分辨率的子流展示名字，不填或者填空数组则使用默认配置：
        /// <li>MinEdgeLength：240，Name：流畅；</li>
        /// <li>MinEdgeLength：480，Name：标清；</li>
        /// <li>MinEdgeLength：720，Name：高清；</li>
        /// <li>MinEdgeLength：1080，Name：全高清；</li>
        /// <li>MinEdgeLength：1440，Name：2K；</li>
        /// <li>MinEdgeLength：2160，Name：4K；</li>
        /// <li>MinEdgeLength：4320，Name：8K。</li>
        /// </summary>
        [JsonProperty("ResolutionNames")]
        public ResolutionNameInfo[] ResolutionNames{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DrmSwitch", this.DrmSwitch);
            this.SetParamSimple(map, prefix + "AdaptiveDynamicStreamingDefinition", this.AdaptiveDynamicStreamingDefinition);
            this.SetParamObj(map, prefix + "DrmStreamingsInfo.", this.DrmStreamingsInfo);
            this.SetParamSimple(map, prefix + "ImageSpriteDefinition", this.ImageSpriteDefinition);
            this.SetParamArrayObj(map, prefix + "ResolutionNames.", this.ResolutionNames);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

