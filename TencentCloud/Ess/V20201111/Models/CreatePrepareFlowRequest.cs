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

    public class CreatePrepareFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 资源Id，通过多文件上传（UploadFiles）接口获得
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 是否顺序签署(true:无序签,false:顺序签)
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 签署流程的签署截止时间。
        /// 值为unix时间戳,精确到秒,不传默认为当前时间一年后
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 用户自定义合同类型
        /// </summary>
        [JsonProperty("UserFlowTypeId")]
        public string UserFlowTypeId{ get; set; }

        /// <summary>
        /// 签署流程参与者信息，最大限制50方
        /// </summary>
        [JsonProperty("Approvers")]
        public FlowCreateApprover[] Approvers{ get; set; }

        /// <summary>
        /// 打开智能添加填写区(默认开启，打开:"OPEN" 关闭："CLOSE")
        /// </summary>
        [JsonProperty("IntelligentStatus")]
        public string IntelligentStatus{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填	
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UserFlowTypeId", this.UserFlowTypeId);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "IntelligentStatus", this.IntelligentStatus);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

