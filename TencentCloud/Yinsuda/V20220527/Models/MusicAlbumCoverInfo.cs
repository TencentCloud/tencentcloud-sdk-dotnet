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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MusicAlbumCoverInfo : AbstractModel
    {
        
        /// <summary>
        /// 尺寸规格，取值有：
        /// <li>Mini：150 x 150 尺寸；</li>
        /// <li>Small：240 x 240 尺寸；</li>
        /// <li>Medium：480 x 480 尺寸。</li>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 下载链接。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

