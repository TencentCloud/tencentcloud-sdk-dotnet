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

    public class FlowDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同(流程)的Id
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同(流程)的名字
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同(流程)的类型
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 合同(流程)的状态
        /// </summary>
        [JsonProperty("FlowStatus")]
        public string FlowStatus{ get; set; }

        /// <summary>
        /// 合同(流程)的信息
        /// </summary>
        [JsonProperty("FlowMessage")]
        public string FlowMessage{ get; set; }

        /// <summary>
        /// 合同(流程)的创建时间戳
        /// </summary>
        [JsonProperty("CreateOn")]
        public long? CreateOn{ get; set; }

        /// <summary>
        /// 合同(流程)的签署截止时间戳
        /// </summary>
        [JsonProperty("DeadLine")]
        public long? DeadLine{ get; set; }

        /// <summary>
        /// 用户自定义数据
        /// </summary>
        [JsonProperty("CustomData")]
        public string CustomData{ get; set; }

        /// <summary>
        /// 合同(流程)的签署人数组
        /// </summary>
        [JsonProperty("FlowApproverInfos")]
        public FlowApproverDetail[] FlowApproverInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "FlowStatus", this.FlowStatus);
            this.SetParamSimple(map, prefix + "FlowMessage", this.FlowMessage);
            this.SetParamSimple(map, prefix + "CreateOn", this.CreateOn);
            this.SetParamSimple(map, prefix + "DeadLine", this.DeadLine);
            this.SetParamSimple(map, prefix + "CustomData", this.CustomData);
            this.SetParamArrayObj(map, prefix + "FlowApproverInfos.", this.FlowApproverInfos);
        }
    }
}

