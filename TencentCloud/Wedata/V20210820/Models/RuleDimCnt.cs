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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleDimCnt : AbstractModel
    {
        
        /// <summary>
        /// 1：准确性，2：唯一性，3：完整性，4：一致性，5：及时性，6：有效性
        /// </summary>
        [JsonProperty("Dim")]
        public ulong? Dim{ get; set; }

        /// <summary>
        /// count 数
        /// </summary>
        [JsonProperty("Cnt")]
        public ulong? Cnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dim", this.Dim);
            this.SetParamSimple(map, prefix + "Cnt", this.Cnt);
        }
    }
}

