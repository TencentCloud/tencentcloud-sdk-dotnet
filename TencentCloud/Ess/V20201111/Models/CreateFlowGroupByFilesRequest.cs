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

    public class CreateFlowGroupByFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同（流程）组名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowGroupName")]
        public string FlowGroupName{ get; set; }

        /// <summary>
        /// 合同（流程）组的子合同信息，支持2-50个子合同
        /// </summary>
        [JsonProperty("FlowGroupInfos")]
        public FlowGroupInfo[] FlowGroupInfos{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同（流程）组的配置项信息。
        /// 其中包括：
        /// <ul>
        /// <li>是否通知本企业签署方</li>
        /// <li>是否通知其他签署方</li>
        /// </ul>
        /// </summary>
        [JsonProperty("FlowGroupOptions")]
        public FlowGroupOptions FlowGroupOptions{ get; set; }

        /// <summary>
        /// 用户自定义合同类型。
        /// 
        /// 自定义合同类型配置的地方如链接图所示。[点击查看自定义合同类型管理的位置](https://qcloudimg.tencent-cloud.cn/raw/36582cea03ae6a2559894844942b5d5c.png)
        /// 
        /// 注意：
        /// 如果传递了自定义合同类型，则每一个子合同设置的自定义合同类型将会失效，已最外层定义的为准。
        /// 例如：
        /// 这份合同组有三个子合同，设置合同类型为<font color="blue">人事/劳务</font>
        /// 第一份子合同设置的合同自定义合同类型是<font color="blue">采购</font>
        /// 第二份和第三份子合同设置的合同自定义合同类型是<font color="blue">人事/劳务</font>
        /// 但最终这个合同组的合同类型是<font color="blue">人事/劳务</font>
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        [JsonProperty("UserFlowType")]
        public UserFlowType UserFlowType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowGroupName", this.FlowGroupName);
            this.SetParamArrayObj(map, prefix + "FlowGroupInfos.", this.FlowGroupInfos);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "FlowGroupOptions.", this.FlowGroupOptions);
            this.SetParamObj(map, prefix + "UserFlowType.", this.UserFlowType);
        }
    }
}

