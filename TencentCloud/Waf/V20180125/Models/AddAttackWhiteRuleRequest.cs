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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddAttackWhiteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 匹配规则项列表
        /// </summary>
        [JsonProperty("Rules")]
        public UserWhiteRuleItem[] Rules{ get; set; }

        /// <summary>
        /// 规则序号
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("SignatureId")]
        public string SignatureId{ get; set; }

        /// <summary>
        /// 加白的规则ID列表
        /// </summary>
        [JsonProperty("SignatureIds")]
        public string[] SignatureIds{ get; set; }

        /// <summary>
        /// 加白的大类规则ID
        /// </summary>
        [JsonProperty("TypeIds")]
        public string[] TypeIds{ get; set; }

        /// <summary>
        /// 0:按照特定规则ID加白, 1:按照规则类型加白
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "SignatureId", this.SignatureId);
            this.SetParamArraySimple(map, prefix + "SignatureIds.", this.SignatureIds);
            this.SetParamArraySimple(map, prefix + "TypeIds.", this.TypeIds);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

