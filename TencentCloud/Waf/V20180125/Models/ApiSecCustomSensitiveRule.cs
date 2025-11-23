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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiSecCustomSensitiveRule : AbstractModel
    {
        
        /// <summary>
        /// 参数位置
        /// </summary>
        [JsonProperty("Position")]
        public string[] Position{ get; set; }

        /// <summary>
        /// 匹配条件
        /// </summary>
        [JsonProperty("MatchKey")]
        public string MatchKey{ get; set; }

        /// <summary>
        /// 匹配值
        /// </summary>
        [JsonProperty("MatchValue")]
        public string[] MatchValue{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 匹配符号，当匹配条件为关键字匹配和字符匹配的时候传该值,可传多个
        /// </summary>
        [JsonProperty("MatchCond")]
        public string[] MatchCond{ get; set; }

        /// <summary>
        /// 规则是否泛化，默认0表示不泛化
        /// </summary>
        [JsonProperty("IsPan")]
        public long? IsPan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Position.", this.Position);
            this.SetParamSimple(map, prefix + "MatchKey", this.MatchKey);
            this.SetParamArraySimple(map, prefix + "MatchValue.", this.MatchValue);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "MatchCond.", this.MatchCond);
            this.SetParamSimple(map, prefix + "IsPan", this.IsPan);
        }
    }
}

