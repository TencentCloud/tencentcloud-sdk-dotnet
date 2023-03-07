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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportBaselineItemDetectListRequest : AbstractModel
    {
        
        /// <summary>
        /// <li>HostId - string - 是否必填：否 - 主机Id</i>
        /// <li>RuleId - int64 - 是否必填：否 - 规则Id</i>
        /// <li>IsPassed - int - 是否必填：否 - 是否通过</li>
        /// <li>RiskTier - int - 是否必填：否 - 风险等级</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 0:过滤的结果导出；1:全部导出
        /// </summary>
        [JsonProperty("ExportAll")]
        public long? ExportAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ExportAll", this.ExportAll);
        }
    }
}

