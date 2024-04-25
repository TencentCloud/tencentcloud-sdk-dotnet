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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFormat : AbstractModel
    {
        
        /// <summary>
        /// 日志投递的预设输出格式类型，取值有：
        /// <li>json：使用预设日志输出格式 JSON Lines，单条日志中的字段以键值对方式呈现；</li>
        /// <li>csv：使用预设日志输出格式 csv，单条日志中仅呈现字段值，不呈现字段名称。</li>
        /// </summary>
        [JsonProperty("FormatType")]
        public string FormatType{ get; set; }

        /// <summary>
        /// 在每个日志投递批次之前添加的字符串。每个日志投递批次可能包含多条日志记录。
        /// </summary>
        [JsonProperty("BatchPrefix")]
        public string BatchPrefix{ get; set; }

        /// <summary>
        /// 在每个日志投递批次后附加的字符串。
        /// </summary>
        [JsonProperty("BatchSuffix")]
        public string BatchSuffix{ get; set; }

        /// <summary>
        /// 在每条日志记录之前添加的字符串。
        /// </summary>
        [JsonProperty("RecordPrefix")]
        public string RecordPrefix{ get; set; }

        /// <summary>
        /// 在每条日志记录后附加的字符串。
        /// </summary>
        [JsonProperty("RecordSuffix")]
        public string RecordSuffix{ get; set; }

        /// <summary>
        /// 插入日志记录之间作为分隔符的字符串，取值有：
        /// <li>\n：换行符；</li>
        /// <li>\t：制表符；</li>
        /// <li>，：半角逗号。</li>
        /// </summary>
        [JsonProperty("RecordDelimiter")]
        public string RecordDelimiter{ get; set; }

        /// <summary>
        /// 单条日志记录内，插入字段之间作为分隔符的字符串，取值有：
        /// <li>\t：制表符；</li>
        /// <li>，：半角逗号；</li>
        /// <li>;：半角分号。</li>
        /// </summary>
        [JsonProperty("FieldDelimiter")]
        public string FieldDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FormatType", this.FormatType);
            this.SetParamSimple(map, prefix + "BatchPrefix", this.BatchPrefix);
            this.SetParamSimple(map, prefix + "BatchSuffix", this.BatchSuffix);
            this.SetParamSimple(map, prefix + "RecordPrefix", this.RecordPrefix);
            this.SetParamSimple(map, prefix + "RecordSuffix", this.RecordSuffix);
            this.SetParamSimple(map, prefix + "RecordDelimiter", this.RecordDelimiter);
            this.SetParamSimple(map, prefix + "FieldDelimiter", this.FieldDelimiter);
        }
    }
}

