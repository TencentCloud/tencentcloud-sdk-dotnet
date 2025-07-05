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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyDSPADiscoveryRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 只能取and 、or两个值其中之一，and：字段和内容同时满足，or：字段和内容满足其一
        /// </summary>
        [JsonProperty("MatchOperator")]
        public string MatchOperator{ get; set; }

        /// <summary>
        /// 字段名包含规则，最大支持选择9项
        /// </summary>
        [JsonProperty("MetaRule")]
        public DataRules MetaRule{ get; set; }

        /// <summary>
        /// 内容包含规则，最大支持选择9项
        /// </summary>
        [JsonProperty("ContentRule")]
        public DataRules ContentRule{ get; set; }

        /// <summary>
        /// 验证规则字段名，最大长度为1024个字符
        /// </summary>
        [JsonProperty("VerifyMeta")]
        public string VerifyMeta{ get; set; }

        /// <summary>
        /// 验证规则数据内容，最大长度为1024个字符
        /// </summary>
        [JsonProperty("VerifyContent")]
        public string VerifyContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "MatchOperator", this.MatchOperator);
            this.SetParamObj(map, prefix + "MetaRule.", this.MetaRule);
            this.SetParamObj(map, prefix + "ContentRule.", this.ContentRule);
            this.SetParamSimple(map, prefix + "VerifyMeta", this.VerifyMeta);
            this.SetParamSimple(map, prefix + "VerifyContent", this.VerifyContent);
        }
    }
}

