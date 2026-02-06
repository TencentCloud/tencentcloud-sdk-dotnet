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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RulePayloadItem : AbstractModel
    {
        
        /// <summary>
        /// 字段Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldKey")]
        public string FieldKey{ get; set; }

        /// <summary>
        /// 选项（eq:等于,neq:不等于,like,nlike,gt:大于,lt:小于,egt:大于等于,elt:小于等于）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Option")]
        public string Option{ get; set; }

        /// <summary>
        /// 值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }

        /// <summary>
        /// 嵌套条件组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Groups")]
        public RulePayloadItem[] Groups{ get; set; }

        /// <summary>
        /// RelateOption 关系操作符（and/or），用于根级别条件关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelateOption")]
        public string RelateOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldKey", this.FieldKey);
            this.SetParamSimple(map, prefix + "Option", this.Option);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "RelateOption", this.RelateOption);
        }
    }
}

