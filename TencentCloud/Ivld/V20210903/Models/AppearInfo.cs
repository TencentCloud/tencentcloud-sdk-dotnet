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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppearInfo : AbstractModel
    {
        
        /// <summary>
        /// 关键词在音频文本结果中的出现位置数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioAppearSet")]
        public TextAppearInfo[] AudioAppearSet{ get; set; }

        /// <summary>
        /// 关键词在可视文本结果中的出现位置数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextAppearSet")]
        public TextAppearInfo[] TextAppearSet{ get; set; }

        /// <summary>
        /// 关键词在视频信息中的出现位置数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoAppearSet")]
        public VideoAppearInfo[] VideoAppearSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AudioAppearSet.", this.AudioAppearSet);
            this.SetParamArrayObj(map, prefix + "TextAppearSet.", this.TextAppearSet);
            this.SetParamArrayObj(map, prefix + "VideoAppearSet.", this.VideoAppearSet);
        }
    }
}

