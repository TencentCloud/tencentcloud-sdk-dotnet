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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFormat : AbstractModel
    {
        
        /// <summary>
        /// <p>日志输出格式，取值有：</p><ul><li>json：使用预设日志输出格式 JSON Lines，单条日志中的字段以键值对方式呈现；</li><li>csv：使用预设日志输出格式 csv，单条日志中仅呈现字段值，不呈现字段名称。</li><li>template：使用用户自定义输出模板，单条日志中支持按照自定义模板进行自定义排版和拼接，需配合 RecordTemplate 字段使用。</li></ul>
        /// </summary>
        [JsonProperty("FormatType")]
        public string FormatType{ get; set; }

        /// <summary>
        /// <p>在每个日志投递批次之前添加的字符串。每个日志投递批次可能包含多条日志记录。</p>
        /// </summary>
        [JsonProperty("BatchPrefix")]
        public string BatchPrefix{ get; set; }

        /// <summary>
        /// <p>在每个日志投递批次后附加的字符串。</p>
        /// </summary>
        [JsonProperty("BatchSuffix")]
        public string BatchSuffix{ get; set; }

        /// <summary>
        /// <p>单条日志前缀，在每条日志记录之前添加的字符串。</p>
        /// </summary>
        [JsonProperty("RecordPrefix")]
        public string RecordPrefix{ get; set; }

        /// <summary>
        /// <p>单条日志后缀，在每条日志记录后附加的字符串。</p>
        /// </summary>
        [JsonProperty("RecordSuffix")]
        public string RecordSuffix{ get; set; }

        /// <summary>
        /// <p>日志分隔符，插入日志记录之间作为分隔的字符串，取值有：</p><ul><li>\n：换行符；</li><li>\t：制表符；</li><li>，：半角逗号。</li></ul>
        /// </summary>
        [JsonProperty("RecordDelimiter")]
        public string RecordDelimiter{ get; set; }

        /// <summary>
        /// <p>日志模板，单条日志的输出模板，长度限制 4KB，仅当 FormatType = template 生效。支持对配置的推送字段按照模板进行自定义排版和拼接。</p>
        /// </summary>
        [JsonProperty("RecordTemplate")]
        public string RecordTemplate{ get; set; }

        /// <summary>
        /// <p>字段分隔符，单条日志记录内，插入字段之间作为分隔符的字符串，仅当 FormatType = csv 生效。取值有：<ul><li>\t：制表符；</li><li>，：半角逗号；</li><li>;：半角分号。</li></ul></p>
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
            this.SetParamSimple(map, prefix + "RecordTemplate", this.RecordTemplate);
            this.SetParamSimple(map, prefix + "FieldDelimiter", this.FieldDelimiter);
        }
    }
}

