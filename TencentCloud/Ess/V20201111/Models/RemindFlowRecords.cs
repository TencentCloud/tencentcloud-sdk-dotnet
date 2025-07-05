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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemindFlowRecords : AbstractModel
    {
        
        /// <summary>
        /// 合同流程是否可以催办：
        /// true - 可以，false - 不可以。
        /// 若无法催办，将返回RemindMessage以解释原因。
        /// </summary>
        [JsonProperty("CanRemind")]
        public bool? CanRemind{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 在合同流程无法催办的情况下，系统将返回RemindMessage以阐述原因。
        /// </summary>
        [JsonProperty("RemindMessage")]
        public string RemindMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanRemind", this.CanRemind);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "RemindMessage", this.RemindMessage);
        }
    }
}

