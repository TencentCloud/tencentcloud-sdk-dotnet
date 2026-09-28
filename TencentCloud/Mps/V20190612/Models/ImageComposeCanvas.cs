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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageComposeCanvas : AbstractModel
    {
        
        /// <summary>
        /// <p>画布宽度，取值范围 [1, 10240]，需与 Height 同时设置。</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>画布高度，取值范围 [1, 10240]，需与 Width 同时设置。</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>画布底色，统一为 8 位十六进制 #RRGGBBAA（含 alpha），原样作为画布底色。缺省 #00000000（全透明）。示例：#FFFFFFFF 不透明白、#FFFFFF80 半透明白。</p><p>输出格式不支持透明通道时（如 JPEG），透明区域按该底色的 RGB 塌陷；缺省值会得到黑底，需要白底请显式传    #FFFFFFFF。</p>
        /// </summary>
        [JsonProperty("Background")]
        public string Background{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Background", this.Background);
        }
    }
}

