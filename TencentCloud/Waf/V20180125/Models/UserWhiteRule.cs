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

    public class UserWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// 白名单的id
        /// </summary>
        [JsonProperty("WhiteRuleId")]
        public ulong? WhiteRuleId{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("SignatureId")]
        public string SignatureId{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 匹配域
        /// </summary>
        [JsonProperty("MatchField")]
        public string MatchField{ get; set; }

        /// <summary>
        /// 匹配方法
        /// </summary>
        [JsonProperty("MatchMethod")]
        public string MatchMethod{ get; set; }

        /// <summary>
        /// 匹配内容
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhiteRuleId", this.WhiteRuleId);
            this.SetParamSimple(map, prefix + "SignatureId", this.SignatureId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MatchField", this.MatchField);
            this.SetParamSimple(map, prefix + "MatchMethod", this.MatchMethod);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

