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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIAnalysisDataScope : AbstractModel
    {
        
        /// <summary>
        /// <p>告警AI诊断时查询的数据范围（查询哪些日志主题）</p>
        /// </summary>
        [JsonProperty("DataScopeEntry")]
        public AIAnalysisDataScopeEntry[] DataScopeEntry{ get; set; }

        /// <summary>
        /// <p>告警AI诊断的数据范围类型</p><p>枚举值：</p><ul><li>CLSLogTopic： 日志主题</li></ul><p>默认值：CLSLogTopic</p>
        /// </summary>
        [JsonProperty("DataScopeType")]
        public string DataScopeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DataScopeEntry.", this.DataScopeEntry);
            this.SetParamSimple(map, prefix + "DataScopeType", this.DataScopeType);
        }
    }
}

