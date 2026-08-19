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

    public class DescribeTaskPredictCostQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务模式</p>
        /// </summary>
        [JsonProperty("TaskMode")]
        public ulong? TaskMode{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>自定义规则列表</p>
        /// </summary>
        [JsonProperty("RuleIDs")]
        public string[] RuleIDs{ get; set; }

        /// <summary>
        /// <p>规范ID</p>
        /// </summary>
        [JsonProperty("StandardIDs")]
        public ulong?[] StandardIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "RuleIDs.", this.RuleIDs);
            this.SetParamArraySimple(map, prefix + "StandardIDs.", this.StandardIDs);
        }
    }
}

