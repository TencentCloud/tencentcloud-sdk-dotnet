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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FillError : AbstractModel
    {
        
        /// <summary>
        /// 为签署方经办人在签署合同中的参与方ID，与控件绑定，是控件的归属方，ID为32位字符串。与入参中补充的签署人角色ID对应，批量补充部分失败返回对应的错误信息。
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 补充失败错误说明
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。	
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
        }
    }
}

