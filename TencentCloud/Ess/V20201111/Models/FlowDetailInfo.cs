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

    public class FlowDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同(流程)的ID
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 流程状态
        /// - 0 还没有发起
        /// - 1 待签署
        /// - 2 部分签署
        /// - 3 已拒签
        /// - 4 已签署
        /// - 5 已过期
        /// - 6 已撤销
        /// - 7 还没有预发起
        /// - 8 等待填写
        /// - 9 部分填写
        /// - 10 拒填
        /// - 21 已解除
        /// </summary>
        [JsonProperty("FlowStatus")]
        public long? FlowStatus{ get; set; }

        /// <summary>
        /// 合同(流程)的信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowMessage")]
        public string FlowMessage{ get; set; }

        /// <summary>
        /// 流程的描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同(流程)的创建时间戳，单位秒
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 合同(流程)的签署方数组
        /// </summary>
        [JsonProperty("FlowApproverInfos")]
        public FlowApproverDetail[] FlowApproverInfos{ get; set; }

        /// <summary>
        /// 合同(流程)的关注方信息列表
        /// </summary>
        [JsonProperty("CcInfos")]
        public FlowApproverDetail[] CcInfos{ get; set; }

        /// <summary>
        /// 合同发起人UserId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }


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
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamArrayObj(map, prefix + "FlowApproverInfos.", this.FlowApproverInfos);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
        }
    }
}

