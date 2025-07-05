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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Step : AbstractModel
    {
        
        /// <summary>
        /// 执行步骤名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行动作。
        /// </summary>
        [JsonProperty("ExecutionStep")]
        public Execution ExecutionStep{ get; set; }

        /// <summary>
        /// 执行失败策略。
        /// 1. TERMINATE_CLUSTER 执行失败时退出并销毁集群。
        /// 2. CONTINUE 执行失败时跳过并执行后续步骤。
        /// </summary>
        [JsonProperty("ActionOnFailure")]
        public string ActionOnFailure{ get; set; }

        /// <summary>
        /// 指定执行Step时的用户名，非必须，默认为hadoop。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "ExecutionStep.", this.ExecutionStep);
            this.SetParamSimple(map, prefix + "ActionOnFailure", this.ActionOnFailure);
            this.SetParamSimple(map, prefix + "User", this.User);
        }
    }
}

