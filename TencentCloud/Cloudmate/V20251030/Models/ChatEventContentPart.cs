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

namespace TencentCloud.Cloudmate.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatEventContentPart : AbstractModel
    {
        
        /// <summary>
        /// 文本内容（流式或完整）
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 函数调用信息
        /// </summary>
        [JsonProperty("FunctionCall")]
        public string FunctionCall{ get; set; }

        /// <summary>
        /// 函数返回结果
        /// </summary>
        [JsonProperty("FunctionResponse")]
        public string FunctionResponse{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "FunctionCall", this.FunctionCall);
            this.SetParamSimple(map, prefix + "FunctionResponse", this.FunctionResponse);
        }
    }
}

