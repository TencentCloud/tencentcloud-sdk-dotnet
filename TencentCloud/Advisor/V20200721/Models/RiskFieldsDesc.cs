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

namespace TencentCloud.Advisor.V20200721.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskFieldsDesc : AbstractModel
    {
        
        /// <summary>
        /// 字段ID
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// 字段类型, 
        /// string: 字符串类型，例如"aa"
        /// int: 整形，例如 111
        /// stringSlice : 字符串数组类型，例如["a", "b"]
        /// tags: 标签类型, 例如: [{"Key":"kkk","Value":"vvv"},{"Key":"kkk2","Value":"vvv2"}]
        /// </summary>
        [JsonProperty("FieldType")]
        public string FieldType{ get; set; }

        /// <summary>
        /// 字段值对应字典
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldDict")]
        public KeyValue[] FieldDict{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamArrayObj(map, prefix + "FieldDict.", this.FieldDict);
        }
    }
}

