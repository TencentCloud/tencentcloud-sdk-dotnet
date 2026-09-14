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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyQAListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>所属知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>待修改的 QA ID 列表（数量：1~20）</p>
        /// </summary>
        [JsonProperty("QaIdList")]
        public string[] QaIdList{ get; set; }

        /// <summary>
        /// <p>分类 ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>生效作用域<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_NONE</td><td>1</td><td>停用</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_DEV</td><td>2</td><td>仅开发域</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_RELEASE</td><td>3</td><td>仅发布域</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_ALL</td><td>4</td><td>全域</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("EffectiveDomain")]
        public long? EffectiveDomain{ get; set; }

        /// <summary>
        /// <p>过期策略（有效时间与超过有效时间后的行为）</p>
        /// </summary>
        [JsonProperty("ExpirationPolicy")]
        public ExpirationPolicy ExpirationPolicy{ get; set; }

        /// <summary>
        /// <p>是否采纳（校验通过）</p>
        /// </summary>
        [JsonProperty("IsAccepted")]
        public bool? IsAccepted{ get; set; }

        /// <summary>
        /// <p>适用范围（标签条件列表）</p>
        /// </summary>
        [JsonProperty("LabelRefList")]
        public LabelRefIdentityList LabelRefList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamArraySimple(map, prefix + "QaIdList.", this.QaIdList);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "EffectiveDomain", this.EffectiveDomain);
            this.SetParamObj(map, prefix + "ExpirationPolicy.", this.ExpirationPolicy);
            this.SetParamSimple(map, prefix + "IsAccepted", this.IsAccepted);
            this.SetParamObj(map, prefix + "LabelRefList.", this.LabelRefList);
        }
    }
}

