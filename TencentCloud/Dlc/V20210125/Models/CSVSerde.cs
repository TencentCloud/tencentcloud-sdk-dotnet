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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CSVSerde : AbstractModel
    {
        
        /// <summary>
        /// CSV序列化转义符，默认为"\\"，最长8个字符，如 Escape: "/\"
        /// </summary>
        [JsonProperty("Escape")]
        public string Escape{ get; set; }

        /// <summary>
        /// CSV序列化字段域符，默认为"'"，最长8个字符, 如 Quote: "\""
        /// </summary>
        [JsonProperty("Quote")]
        public string Quote{ get; set; }

        /// <summary>
        /// CSV序列化分隔符，默认为"\t"，最长8个字符, 如 Separator: "\t"
        /// </summary>
        [JsonProperty("Separator")]
        public string Separator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Escape", this.Escape);
            this.SetParamSimple(map, prefix + "Quote", this.Quote);
            this.SetParamSimple(map, prefix + "Separator", this.Separator);
        }
    }
}

