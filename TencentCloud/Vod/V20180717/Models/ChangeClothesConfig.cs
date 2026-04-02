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

    public class ChangeClothesConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>输入需要更换的<strong>衣物</strong>图片列表。各类型最大支持衣物数量：</p><ul><li>change_clothes：4 张图片；</li><li>change_clothes_under：1 张图片；</li><li>change_clothes_full_wear：1 张图片；</li><li>change_clothes_top_wear：1 张图片；</li><li>change_clothes_bottom_wear：1 张图片；</li></ul>
        /// </summary>
        [JsonProperty("ClothesFileInfos")]
        public SceneAigcImageTaskInputFileInfo[] ClothesFileInfos{ get; set; }

        /// <summary>
        /// <p>AI换衣的提示词。<strong>仅Type为change_clothes有效。</strong></p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ClothesFileInfos.", this.ClothesFileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
        }
    }
}

