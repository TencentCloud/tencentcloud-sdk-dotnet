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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HitSnippetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>命中的文本片段（明文），已还原到预处理前的原文，注意该字段内容在原文中可能不连续，需要结合HitSnippetInfos[].Positions来还原出所在原文位置</p>
        /// </summary>
        [JsonProperty("Snippet")]
        public string Snippet{ get; set; }

        /// <summary>
        /// <p>原子能力类型，如果是业务自定义库命中，会给出词库名称</p>
        /// </summary>
        [JsonProperty("AtomicName")]
        public string AtomicName{ get; set; }

        /// <summary>
        /// <p>原子能力ID，如果是业务自定义库导致命中本次审核标签，该值是词库ID</p>
        /// </summary>
        [JsonProperty("AtomicId")]
        public string AtomicId{ get; set; }

        /// <summary>
        /// <p>该命中片段在原文中的位置列表，由于文本片段在原文中可能不连续，它可能是有多段位置信息</p>
        /// </summary>
        [JsonProperty("Positions")]
        public HitPosition[] Positions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Snippet", this.Snippet);
            this.SetParamSimple(map, prefix + "AtomicName", this.AtomicName);
            this.SetParamSimple(map, prefix + "AtomicId", this.AtomicId);
            this.SetParamArrayObj(map, prefix + "Positions.", this.Positions);
        }
    }
}

