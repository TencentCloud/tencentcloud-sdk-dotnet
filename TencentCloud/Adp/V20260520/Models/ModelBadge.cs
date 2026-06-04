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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelBadge : AbstractModel
    {
        
        /// <summary>
        /// 展示文案
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 样式主题。1-信息（蓝色）, 2-成功（绿色）, 3-警告（橙色）, 4-危险（红色）
        /// </summary>
        [JsonProperty("Theme")]
        public long? Theme{ get; set; }

        /// <summary>
        /// tooltip文案，为空则不展示
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// 徽章类型。1-限时免费, 2-即将下线, 3-新模型, 4-热门
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Theme", this.Theme);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

