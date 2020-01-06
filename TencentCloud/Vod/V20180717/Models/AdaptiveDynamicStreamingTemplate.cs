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

    public class AdaptiveDynamicStreamingTemplate : AbstractModel
    {
        
        /// <summary>
        /// 转自适应码流模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 模板类型，取值范围：
        /// <li>Preset：系统预置模板；</li>
        /// <li>Custom：用户自定义模板。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 转自适应码流模板名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 转自适应码流模板描述信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 打包类型，取值范围：
        /// <li>hls；</li>
        /// <li>dash。</li>
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// DRM 类型，取值范围：
        /// <li>FairPlay；</li>
        /// <li>SimpleAES；</li>
        /// <li>Widevine。</li>
        /// 如果取值为空字符串，代表不对视频做 DRM 保护。
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// 视频轨模板列表。
        /// </summary>
        [JsonProperty("VideoTrackTemplateSet")]
        public VideoTrackTemplateInfo[] VideoTrackTemplateSet{ get; set; }

        /// <summary>
        /// 音频轨模板列表。
        /// </summary>
        [JsonProperty("AudioTrackTemplateSet")]
        public AudioTrackTemplateInfo[] AudioTrackTemplateSet{ get; set; }

        /// <summary>
        /// 是否禁止视频低码率转高码率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// 是否禁止视频分辨率转高分辨率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamArrayObj(map, prefix + "VideoTrackTemplateSet.", this.VideoTrackTemplateSet);
            this.SetParamArrayObj(map, prefix + "AudioTrackTemplateSet.", this.AudioTrackTemplateSet);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

