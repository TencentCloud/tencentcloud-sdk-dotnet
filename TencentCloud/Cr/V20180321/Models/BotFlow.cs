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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotFlow : AbstractModel
    {
        
        /// <summary>
        /// 对话流ID
        /// </summary>
        [JsonProperty("BotFlowId")]
        public string BotFlowId{ get; set; }

        /// <summary>
        /// 对话流名称
        /// </summary>
        [JsonProperty("BotFlowName")]
        public string BotFlowName{ get; set; }

        /// <summary>
        /// 号码组信息列表
        /// </summary>
        [JsonProperty("PhonePoolList")]
        public PhonePool[] PhonePoolList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotFlowId", this.BotFlowId);
            this.SetParamSimple(map, prefix + "BotFlowName", this.BotFlowName);
            this.SetParamArrayObj(map, prefix + "PhonePoolList.", this.PhonePoolList);
        }
    }
}

