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

    public class GlossaryEntry : AbstractModel
    {
        
        /// <summary>
        /// 源语言术语，限制1000字符
        /// </summary>
        [JsonProperty("SourceTerm")]
        public string SourceTerm{ get; set; }

        /// <summary>
        /// 目标语言术语，限制1000字符
        /// </summary>
        [JsonProperty("TargetTerm")]
        public string TargetTerm{ get; set; }

        /// <summary>
        /// 术语条目 ID
        /// </summary>
        [JsonProperty("EntryId")]
        public string EntryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceTerm", this.SourceTerm);
            this.SetParamSimple(map, prefix + "TargetTerm", this.TargetTerm);
            this.SetParamSimple(map, prefix + "EntryId", this.EntryId);
        }
    }
}

