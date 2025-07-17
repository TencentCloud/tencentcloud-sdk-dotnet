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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccessKeyCheckTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 风险列表
        /// </summary>
        [JsonProperty("RiskIDList")]
        public long?[] RiskIDList{ get; set; }

        /// <summary>
        /// 访问密钥列表
        /// </summary>
        [JsonProperty("AccessKeyList")]
        public string[] AccessKeyList{ get; set; }

        /// <summary>
        /// 账号uin列表
        /// </summary>
        [JsonProperty("SubUinList")]
        public string[] SubUinList{ get; set; }

        /// <summary>
        /// 风险规则id列表
        /// </summary>
        [JsonProperty("RiskRuleIDList")]
        public long?[] RiskRuleIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "RiskIDList.", this.RiskIDList);
            this.SetParamArraySimple(map, prefix + "AccessKeyList.", this.AccessKeyList);
            this.SetParamArraySimple(map, prefix + "SubUinList.", this.SubUinList);
            this.SetParamArraySimple(map, prefix + "RiskRuleIDList.", this.RiskRuleIDList);
        }
    }
}

