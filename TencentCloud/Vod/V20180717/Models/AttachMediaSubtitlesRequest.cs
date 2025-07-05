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

    public class AttachMediaSubtitlesRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件唯一标识。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 操作。取值如下：
        /// <li>Attach：关联字幕。</li>
        /// <li>Detach：解除关联字幕。</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// [转自适应码流模板号](https://cloud.tencent.com/document/product/266/34071#zsy)。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingDefinition")]
        public ulong? AdaptiveDynamicStreamingDefinition{ get; set; }

        /// <summary>
        /// 字幕的唯一标识。
        /// </summary>
        [JsonProperty("SubtitleIds")]
        public string[] SubtitleIds{ get; set; }

        /// <summary>
        /// 默认字幕的唯一标识。不填则不设置默认字幕。
        /// </summary>
        [JsonProperty("DefaultSubtitleId")]
        public string DefaultSubtitleId{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "AdaptiveDynamicStreamingDefinition", this.AdaptiveDynamicStreamingDefinition);
            this.SetParamArraySimple(map, prefix + "SubtitleIds.", this.SubtitleIds);
            this.SetParamSimple(map, prefix + "DefaultSubtitleId", this.DefaultSubtitleId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

