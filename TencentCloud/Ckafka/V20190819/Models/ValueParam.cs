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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueParam : AbstractModel
    {
        
        /// <summary>
        /// 处理模式，REPLACE替换，SUBSTR截取，DATE日期转换，TRIM去除前后空格，REGEX_REPLACE正则替换，URL_DECODE，LOWERCASE转换为小写
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 替换，TYPE=REPLACE时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replace")]
        public ReplaceParam Replace{ get; set; }

        /// <summary>
        /// 截取，TYPE=SUBSTR时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Substr")]
        public SubstrParam Substr{ get; set; }

        /// <summary>
        /// 时间转换，TYPE=DATE时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public DateParam Date{ get; set; }

        /// <summary>
        /// 正则替换，TYPE=REGEX_REPLACE时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegexReplace")]
        public RegexReplaceParam RegexReplace{ get; set; }

        /// <summary>
        /// 值支持一拆多，TYPE=SPLIT时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Split")]
        public SplitParam Split{ get; set; }

        /// <summary>
        /// key-value二次解析，TYPE=KV时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KV")]
        public KVParam KV{ get; set; }

        /// <summary>
        /// 处理结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// JsonPath替换，TYPE=JSON_PATH_REPLACE时必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JsonPathReplace")]
        public JsonPathReplaceParam JsonPathReplace{ get; set; }

        /// <summary>
        /// Url解析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlDecode")]
        public UrlDecodeParam UrlDecode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Replace.", this.Replace);
            this.SetParamObj(map, prefix + "Substr.", this.Substr);
            this.SetParamObj(map, prefix + "Date.", this.Date);
            this.SetParamObj(map, prefix + "RegexReplace.", this.RegexReplace);
            this.SetParamObj(map, prefix + "Split.", this.Split);
            this.SetParamObj(map, prefix + "KV.", this.KV);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamObj(map, prefix + "JsonPathReplace.", this.JsonPathReplace);
            this.SetParamObj(map, prefix + "UrlDecode.", this.UrlDecode);
        }
    }
}

