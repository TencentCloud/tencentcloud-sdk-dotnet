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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IVRKeyPressedElement : AbstractModel
    {
        
        /// <summary>
        /// 命中的关键字或者按键
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 按键关联的标签
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Unix 毫秒时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 节点标签
        /// </summary>
        [JsonProperty("NodeLabel")]
        public string NodeLabel{ get; set; }

        /// <summary>
        /// 用户原始输入
        /// </summary>
        [JsonProperty("OriginalContent")]
        public string OriginalContent{ get; set; }

        /// <summary>
        /// TTS 提示音内容
        /// </summary>
        [JsonProperty("TTSPrompt")]
        public string TTSPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "NodeLabel", this.NodeLabel);
            this.SetParamSimple(map, prefix + "OriginalContent", this.OriginalContent);
            this.SetParamSimple(map, prefix + "TTSPrompt", this.TTSPrompt);
        }
    }
}

