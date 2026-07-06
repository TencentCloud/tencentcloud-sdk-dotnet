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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelSpec : AbstractModel
    {
        
        /// <summary>
        /// 每分钟处理 Token 数（Tokens Per Minute）。
        /// </summary>
        [JsonProperty("TPM")]
        public string TPM{ get; set; }

        /// <summary>
        /// 每分钟请求数（Queries Per Minute）。
        /// </summary>
        [JsonProperty("QPM")]
        public string QPM{ get; set; }

        /// <summary>
        /// 最大输入 Token 长度。
        /// </summary>
        [JsonProperty("MaxInputToken")]
        public string MaxInputToken{ get; set; }

        /// <summary>
        /// 最大输出 Token 长度。
        /// </summary>
        [JsonProperty("MaxOutputToken")]
        public string MaxOutputToken{ get; set; }

        /// <summary>
        /// 上下文窗口长度。
        /// </summary>
        [JsonProperty("ContextLength")]
        public string ContextLength{ get; set; }

        /// <summary>
        /// 并发数。
        /// </summary>
        [JsonProperty("Concurrency")]
        public string Concurrency{ get; set; }

        /// <summary>
        /// 输入要求描述。
        /// </summary>
        [JsonProperty("InputDescription")]
        public string InputDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamSimple(map, prefix + "QPM", this.QPM);
            this.SetParamSimple(map, prefix + "MaxInputToken", this.MaxInputToken);
            this.SetParamSimple(map, prefix + "MaxOutputToken", this.MaxOutputToken);
            this.SetParamSimple(map, prefix + "ContextLength", this.ContextLength);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
            this.SetParamSimple(map, prefix + "InputDescription", this.InputDescription);
        }
    }
}

