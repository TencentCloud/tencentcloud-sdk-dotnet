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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvatarBackgroundInfo : AbstractModel
    {
        
        /// <summary>
        /// 背景 ID。
        /// </summary>
        [JsonProperty("BackgroundId")]
        public string BackgroundId{ get; set; }

        /// <summary>
        /// 背景场景。如：带货，娱乐等。
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 竖屏背景图片 URL。
        /// </summary>
        [JsonProperty("VerticalImageUrl")]
        public string VerticalImageUrl{ get; set; }

        /// <summary>
        /// 横屏背景图片 URL。
        /// </summary>
        [JsonProperty("HorizontalImageUrl")]
        public string HorizontalImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackgroundId", this.BackgroundId);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "VerticalImageUrl", this.VerticalImageUrl);
            this.SetParamSimple(map, prefix + "HorizontalImageUrl", this.HorizontalImageUrl);
        }
    }
}

