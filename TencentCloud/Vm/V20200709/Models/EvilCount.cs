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

namespace TencentCloud.Vm.V20200709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EvilCount : AbstractModel
    {
        
        /// <summary>
        /// 违规类型：
        /// Terror	24001
        /// Porn	20002
        /// Polity	20001
        /// Ad	20105
        /// Abuse	20007	
        /// Illegal	20006	
        /// Spam	25001	
        /// Moan	26001
        /// </summary>
        [JsonProperty("EvilType")]
        public string EvilType{ get; set; }

        /// <summary>
        /// 分布类型总量
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

