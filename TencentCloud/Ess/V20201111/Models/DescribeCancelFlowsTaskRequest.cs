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

    public class DescribeCancelFlowsTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。<br><br>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>批量撤销任务编号，为32位字符串，通过接口<a href="https://qian.tencent.com/developers/companyApis/operateFlows/CreateBatchCancelFlowUrl">获取批量撤销签署流程腾讯电子签小程序链接</a>和接口<a href="https://qian.tencent.com/developers/companyApis/operateFlows/CancelOrganizationFlows">全量撤销企业合同</a>获得。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>代理企业和员工的信息。<br><br>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>撤销任务类型</p><p>枚举值：</p><ul><li>0： 默认类型，获取批量撤销合同小程序链接的批量撤销任务</li><li>1： 全量撤销任务</li></ul><p>枚举值：</p><ul><li>0： 默认类型，批量撤销合同任务或者获取批量撤销合同小程序链接的批量撤销任务</li><li>1： 全量撤销任务</li></ul><p>枚举值：</p><ul><li>0： 默认类型，获取批量撤销合同小程序链接的批量撤销任务</li><li>1： 全量撤销任务</li></ul>
        /// </summary>
        [JsonProperty("CancelType")]
        public ulong? CancelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "CancelType", this.CancelType);
        }
    }
}

