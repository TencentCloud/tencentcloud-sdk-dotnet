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

    public class DescribeContractReviewTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 用于审查任务的审查清单ID。
        /// </summary>
        [JsonProperty("ChecklistId")]
        public string ChecklistId{ get; set; }

        /// <summary>
        /// 合同审查任务创建时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 合同审查任务完成时间。
        /// </summary>
        [JsonProperty("FinishedOn")]
        public long? FinishedOn{ get; set; }

        /// <summary>
        /// 合同审查的审查立场方。
        /// 
        /// 审查立场方如下：
        /// <ul>
        ///     <li>**0** - 【严格】以保护己方利益为核心，对合同条款进行严格把控，尽可能争取对己方有利的条款，同时对对方提出的不合理条款可进行坚决修改或删除。</li> 
        ///     <li>**1** - 【中立】以公平合理为原则，平衡双方的权利义务，既不过分强调己方利益，也不过度让步，力求达成双方均可接受的条款。</li>   
        ///     <li>**2** - 【宽松】以促成交易为核心，对合同条款的修改要求较为宽松，倾向于接受对方提出的条款，以尽快达成合作。</li>  
        /// </ul>
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// 合同审查的PDF文件资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 合同审查识别出的PDF文件风险信息，如果是空数组表示无风险。
        /// 
        /// 注意：`审查结果由AI生成，仅供参考。请结合相关法律法规和公司制度要求综合判断。`
        /// </summary>
        [JsonProperty("Risks")]
        public OutputRisk[] Risks{ get; set; }

        /// <summary>
        /// 合同审查中的角色信息。
        /// </summary>
        [JsonProperty("Role")]
        public RiskIdentificationRoleInfo Role{ get; set; }

        /// <summary>
        /// 合同审查任务状态。
        /// 状态如下：
        /// <ul>
        ///     <li>**1** - 合同审查任务创建成功</li>   
        ///     <li>**2** - 合同审查任务排队中</li>  
        ///     <li>**3** - 合同审查任务执行中</li>   
        ///     <li>**4** - 合同审查任务执行成功</li>
        ///     <li>**4** - 合同审查任务执行失败</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 合同审查任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChecklistId", this.ChecklistId);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "FinishedOn", this.FinishedOn);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArrayObj(map, prefix + "Risks.", this.Risks);
            this.SetParamObj(map, prefix + "Role.", this.Role);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

