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

    public class BaseFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同流程名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程类型
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 合同流程描述信息
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同流程截止时间，unix时间戳
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 是否顺序签署(true:无序签,false:顺序签)
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 打开智能添加填写区(默认开启，打开:"OPEN" 关闭："CLOSE")
        /// </summary>
        [JsonProperty("IntelligentStatus")]
        public string IntelligentStatus{ get; set; }

        /// <summary>
        /// 填写控件内容
        /// </summary>
        [JsonProperty("FormFields")]
        public FormField[] FormFields{ get; set; }

        /// <summary>
        /// 本企业(发起方企业)是否需要签署审批，true：开启本企业签署审批
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "IntelligentStatus", this.IntelligentStatus);
            this.SetParamArrayObj(map, prefix + "FormFields.", this.FormFields);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
        }
    }
}

