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

    public class AppMemoryConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启长记忆
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 长记忆时长
        /// </summary>
        [JsonProperty("LongMemoryDay")]
        public ulong? LongMemoryDay{ get; set; }

        /// <summary>
        /// 模型配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Model")]
        public ModelDetailInfo Model{ get; set; }

        /// <summary>
        /// prompt内容
        /// </summary>
        [JsonProperty("PromptContent")]
        public string PromptContent{ get; set; }

        /// <summary>
        /// 提示词模式。枚举值: 1:自定义
        /// </summary>
        [JsonProperty("PromptMode")]
        public long? PromptMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "LongMemoryDay", this.LongMemoryDay);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamSimple(map, prefix + "PromptContent", this.PromptContent);
            this.SetParamSimple(map, prefix + "PromptMode", this.PromptMode);
        }
    }
}

