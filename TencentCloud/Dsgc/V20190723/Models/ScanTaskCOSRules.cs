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

    public class ScanTaskCOSRules : AbstractModel
    {
        
        /// <summary>
        /// regex规则内容
        /// </summary>
        [JsonProperty("RegexRule")]
        public COSDataRule RegexRule{ get; set; }

        /// <summary>
        /// 规则状态；0 不启用, 1 启用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 关键词规则内容组，最大支持5个关键词。
        /// </summary>
        [JsonProperty("KeywordRule")]
        public COSDataRule KeywordRule{ get; set; }

        /// <summary>
        /// 忽略词规则内容组，最大支持5个忽略词。
        /// </summary>
        [JsonProperty("IgnoreStringRule")]
        public COSDataRule IgnoreStringRule{ get; set; }

        /// <summary>
        /// 最大匹配距离，默认值为100。上限为500.
        /// </summary>
        [JsonProperty("MaxMatch")]
        public long? MaxMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RegexRule.", this.RegexRule);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "KeywordRule.", this.KeywordRule);
            this.SetParamObj(map, prefix + "IgnoreStringRule.", this.IgnoreStringRule);
            this.SetParamSimple(map, prefix + "MaxMatch", this.MaxMatch);
        }
    }
}

