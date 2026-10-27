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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvocationOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>任务的标准输出。</p>
        /// </summary>
        [JsonProperty("Lines")]
        public string[] Lines{ get; set; }

        /// <summary>
        /// <p>本次返回的输出第一行对应的索引编号。</p>
        /// </summary>
        [JsonProperty("LinesOffset")]
        public ulong? LinesOffset{ get; set; }

        /// <summary>
        /// <p>本次返回的输出的行数。</p>
        /// </summary>
        [JsonProperty("LinesNum")]
        public ulong? LinesNum{ get; set; }

        /// <summary>
        /// <p>输出的编码方式：<br>&lt;li&gt;PlainText 未经过Base64编码。</p>
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// <p>当前有效的输出起始编号，从0开始。输出过多，会冲掉旧的输出。</p>
        /// </summary>
        [JsonProperty("AllLinesOffset")]
        public ulong? AllLinesOffset{ get; set; }

        /// <summary>
        /// <p>当前有效的标准输出总行数。</p>
        /// </summary>
        [JsonProperty("AllLinesNum")]
        public ulong? AllLinesNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Lines.", this.Lines);
            this.SetParamSimple(map, prefix + "LinesOffset", this.LinesOffset);
            this.SetParamSimple(map, prefix + "LinesNum", this.LinesNum);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "AllLinesOffset", this.AllLinesOffset);
            this.SetParamSimple(map, prefix + "AllLinesNum", this.AllLinesNum);
        }
    }
}

