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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnitRuleTag : AbstractModel
    {
        
        /// <summary>
        /// 标签类型 : U(用户标签)
        /// </summary>
        [JsonProperty("TagType")]
        public string TagType{ get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("TagField")]
        public string TagField{ get; set; }

        /// <summary>
        /// 操作符:IN/NOT_IN/EQUAL/NOT_EQUAL/REGEX
        /// </summary>
        [JsonProperty("TagOperator")]
        public string TagOperator{ get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// 单元化规则项ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitRuleItemId")]
        public string UnitRuleItemId{ get; set; }

        /// <summary>
        /// 规则ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagType", this.TagType);
            this.SetParamSimple(map, prefix + "TagField", this.TagField);
            this.SetParamSimple(map, prefix + "TagOperator", this.TagOperator);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "UnitRuleItemId", this.UnitRuleItemId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

