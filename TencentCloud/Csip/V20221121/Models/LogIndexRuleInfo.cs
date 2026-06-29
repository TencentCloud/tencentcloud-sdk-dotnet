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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogIndexRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>全文索引</p>
        /// </summary>
        [JsonProperty("FullText")]
        public LogFullTextInfo FullText{ get; set; }

        /// <summary>
        /// <p>键值索引</p>
        /// </summary>
        [JsonProperty("KeyValue")]
        public LogRuleKeyValueInfo KeyValue{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tag")]
        public LogRuleKeyValueInfo Tag{ get; set; }

        /// <summary>
        /// <p>动态索引</p>
        /// </summary>
        [JsonProperty("DynamicIndex")]
        public LogDynamicIndex DynamicIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FullText.", this.FullText);
            this.SetParamObj(map, prefix + "KeyValue.", this.KeyValue);
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "DynamicIndex.", this.DynamicIndex);
        }
    }
}

