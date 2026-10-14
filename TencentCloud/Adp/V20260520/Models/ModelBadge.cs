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
        /// <p>展示文案（已渲染为最终文案）</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>样式主题</p><table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>MODEL_BADGE_THEME_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>MODEL_BADGE_THEME_INFO</td><td>1</td><td>信息（蓝色）</td></tr><tr><td>MODEL_BADGE_THEME_SUCCESS</td><td>2</td><td>成功（绿色）</td></tr><tr><td>MODEL_BADGE_THEME_WARNING</td><td>3</td><td>警告（橙色）</td></tr><tr><td>MODEL_BADGE_THEME_DANGER</td><td>4</td><td>危险（红色）</td></tr></table>
        /// </summary>
        [JsonProperty("Theme")]
        public long? Theme{ get; set; }

        /// <summary>
        /// <p>tooltip 文案（已渲染为最终文案），为空则不展示</p>
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// <p>徽章类型</p><table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>MODEL_BADGE_TYPE_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>MODEL_BADGE_TYPE_FREE_TRIAL</td><td>1</td><td>限时免费</td></tr><tr><td>MODEL_BADGE_TYPE_DEPRECATING</td><td>2</td><td>即将下线</td></tr><tr><td>MODEL_BADGE_TYPE_NEW</td><td>3</td><td>新模型</td></tr><tr><td>MODEL_BADGE_TYPE_HOT</td><td>4</td><td>热门</td></tr></table>
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

