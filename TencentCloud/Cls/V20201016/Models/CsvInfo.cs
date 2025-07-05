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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CsvInfo : AbstractModel
    {
        
        /// <summary>
        /// csv首行是否打印key
        /// </summary>
        [JsonProperty("PrintKey")]
        public bool? PrintKey{ get; set; }

        /// <summary>
        /// 每列key的名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// 各字段间的分隔符
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// 若字段内容中包含分隔符，则使用该转义符包裹改字段，只能填写单引号、双引号、空字符串
        /// </summary>
        [JsonProperty("EscapeChar")]
        public string EscapeChar{ get; set; }

        /// <summary>
        /// 对于上面指定的不存在字段使用该内容填充
        /// </summary>
        [JsonProperty("NonExistingField")]
        public string NonExistingField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrintKey", this.PrintKey);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "EscapeChar", this.EscapeChar);
            this.SetParamSimple(map, prefix + "NonExistingField", this.NonExistingField);
        }
    }
}

