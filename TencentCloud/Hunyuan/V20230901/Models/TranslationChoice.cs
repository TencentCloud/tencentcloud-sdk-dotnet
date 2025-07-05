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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranslationChoice : AbstractModel
    {
        
        /// <summary>
        /// 结束标志位，可能为 stop、 sensitive。
        /// stop 表示输出正常结束。
        /// sensitive 只在开启流式输出审核时会出现，表示安全审核未通过。
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// 索引值，流式调用时使用该字段。
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }

        /// <summary>
        /// 增量返回值，流式调用时使用该字段。
        /// </summary>
        [JsonProperty("Delta")]
        public TranslationDelta Delta{ get; set; }

        /// <summary>
        /// 返回值，非流式调用时使用该字段。
        /// </summary>
        [JsonProperty("Message")]
        public TranslationMessage Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamObj(map, prefix + "Delta.", this.Delta);
            this.SetParamObj(map, prefix + "Message.", this.Message);
        }
    }
}

