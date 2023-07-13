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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowOption : AbstractModel
    {
        
        /// <summary>
        /// 是否允许修改合同信息，true-是，false-否
        /// </summary>
        [JsonProperty("CanEditFlow")]
        public bool? CanEditFlow{ get; set; }

        /// <summary>
        /// 是否允许发起合同弹窗隐藏合同名称
        /// </summary>
        [JsonProperty("HideShowFlowName")]
        public bool? HideShowFlowName{ get; set; }

        /// <summary>
        /// 是否允许发起合同弹窗隐藏合同类型
        /// </summary>
        [JsonProperty("HideShowFlowType")]
        public bool? HideShowFlowType{ get; set; }

        /// <summary>
        /// 是否允许发起合同弹窗隐藏合同到期时间
        /// </summary>
        [JsonProperty("HideShowDeadline")]
        public bool? HideShowDeadline{ get; set; }

        /// <summary>
        /// 是否允许发起合同步骤跳过指定签署方步骤
        /// </summary>
        [JsonProperty("CanSkipAddApprover")]
        public bool? CanSkipAddApprover{ get; set; }

        /// <summary>
        /// 定制化发起合同页合同描述信息
        /// </summary>
        [JsonProperty("CustomCreateFlowDescription")]
        public string CustomCreateFlowDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanEditFlow", this.CanEditFlow);
            this.SetParamSimple(map, prefix + "HideShowFlowName", this.HideShowFlowName);
            this.SetParamSimple(map, prefix + "HideShowFlowType", this.HideShowFlowType);
            this.SetParamSimple(map, prefix + "HideShowDeadline", this.HideShowDeadline);
            this.SetParamSimple(map, prefix + "CanSkipAddApprover", this.CanSkipAddApprover);
            this.SetParamSimple(map, prefix + "CustomCreateFlowDescription", this.CustomCreateFlowDescription);
        }
    }
}

