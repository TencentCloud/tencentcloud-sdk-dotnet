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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AITransferItem : AbstractModel
    {
        
        /// <summary>
        /// 转人工的function calling 名称
        /// </summary>
        [JsonProperty("TransferFunctionName")]
        public string TransferFunctionName{ get; set; }

        /// <summary>
        /// TransferFunctionEnable为true时生效；transfer_to_human function calling的desc，默认为 "Transfer to human when the user has to transfer to human (like says transfer to human) or you are instructed to do so."
        /// </summary>
        [JsonProperty("TransferFunctionDesc")]
        public string TransferFunctionDesc{ get; set; }

        /// <summary>
        /// 转人工的技能组ID
        /// </summary>
        [JsonProperty("TransferSkillGroupId")]
        public ulong? TransferSkillGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransferFunctionName", this.TransferFunctionName);
            this.SetParamSimple(map, prefix + "TransferFunctionDesc", this.TransferFunctionDesc);
            this.SetParamSimple(map, prefix + "TransferSkillGroupId", this.TransferSkillGroupId);
        }
    }
}

