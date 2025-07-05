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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallExtractResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 提取的类型是文本
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 提取的内型是选项
        /// </summary>
        [JsonProperty("Chosen")]
        public string[] Chosen{ get; set; }

        /// <summary>
        /// 提取类型是布尔值
        /// </summary>
        [JsonProperty("Boolean")]
        public bool? Boolean{ get; set; }

        /// <summary>
        /// 提取类型是数字
        /// </summary>
        [JsonProperty("Number")]
        public float? Number{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArraySimple(map, prefix + "Chosen.", this.Chosen);
            this.SetParamSimple(map, prefix + "Boolean", this.Boolean);
            this.SetParamSimple(map, prefix + "Number", this.Number);
        }
    }
}

