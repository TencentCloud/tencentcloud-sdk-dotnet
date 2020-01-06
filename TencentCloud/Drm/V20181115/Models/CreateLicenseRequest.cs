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

namespace TencentCloud.Drm.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// DRM方案类型，接口取值：WIDEVINE，FAIRPLAY。
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// Base64编码的终端设备License Request数据。
        /// </summary>
        [JsonProperty("LicenseRequest")]
        public string LicenseRequest{ get; set; }

        /// <summary>
        /// 内容类型，接口取值：VodVideo,LiveVideo。
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 授权播放的Track列表。
        /// 该值为空时，默认授权所有track播放。
        /// </summary>
        [JsonProperty("Tracks")]
        public string[] Tracks{ get; set; }

        /// <summary>
        /// 播放策略参数。
        /// </summary>
        [JsonProperty("PlaybackPolicy")]
        public PlaybackPolicy PlaybackPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "LicenseRequest", this.LicenseRequest);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamArraySimple(map, prefix + "Tracks.", this.Tracks);
            this.SetParamObj(map, prefix + "PlaybackPolicy.", this.PlaybackPolicy);
        }
    }
}

