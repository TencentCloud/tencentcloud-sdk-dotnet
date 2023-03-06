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

    public class DescribeFlowDetailInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 第三方平台应用号Id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业OpenId
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenId")]
        public string ProxyOrganizationOpenId{ get; set; }

        /// <summary>
        /// 合同(签署流程)的具体详细描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowInfo")]
        public FlowDetailInfo[] FlowInfo{ get; set; }

        /// <summary>
        /// 合同组编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 合同组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowGroupName")]
        public string FlowGroupName{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenId", this.ProxyOrganizationOpenId);
            this.SetParamArrayObj(map, prefix + "FlowInfo.", this.FlowInfo);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "FlowGroupName", this.FlowGroupName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

