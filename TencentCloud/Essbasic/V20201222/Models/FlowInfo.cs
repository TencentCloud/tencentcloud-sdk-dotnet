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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同名字
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 签署截止时间戳，超过有效签署时间则该签署流程失败
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 合同描述
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同类型：
        /// 1. “劳务”
        /// 2. “销售”
        /// 3. “租赁”
        /// 4. “其他”
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 用户自定义数据
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
        }
    }
}

