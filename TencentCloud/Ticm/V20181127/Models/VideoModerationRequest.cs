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

namespace TencentCloud.Ticm.V20181127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要审核的视频的URL地址
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 开发者标识
        /// </summary>
        [JsonProperty("DeveloperId")]
        public string DeveloperId{ get; set; }

        /// <summary>
        /// 审核完成后回调地址
        /// </summary>
        [JsonProperty("CBUrl")]
        public string CBUrl{ get; set; }

        /// <summary>
        /// 透传字段，透传简单信息。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "DeveloperId", this.DeveloperId);
            this.SetParamSimple(map, prefix + "CBUrl", this.CBUrl);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

