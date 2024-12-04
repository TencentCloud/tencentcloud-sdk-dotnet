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

    public class AudioData : AbstractModel
    {
        
        /// <summary>
        /// 音频识别文本结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioInfoSet")]
        public AudioInfo[] AudioInfoSet{ get; set; }

        /// <summary>
        /// 音频识别标签数据
        /// </summary>
        [JsonProperty("TextTagSet")]
        public MultiLevelTag TextTagSet{ get; set; }

        /// <summary>
        /// 音频下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebMediaURL")]
        public string WebMediaURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AudioInfoSet.", this.AudioInfoSet);
            this.SetParamObj(map, prefix + "TextTagSet.", this.TextTagSet);
            this.SetParamSimple(map, prefix + "WebMediaURL", this.WebMediaURL);
        }
    }
}

