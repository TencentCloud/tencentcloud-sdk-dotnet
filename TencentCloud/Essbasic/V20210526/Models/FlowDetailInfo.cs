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
        /// 合同流程ID，为32位字符串。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程的类别分类（如销售合同/入职合同等）。
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 合同流程当前的签署状态, 会存在下列的状态值
        /// <ul><li> **INIT** :合同创建</li>
        /// <li> **PART** :合同签署中(至少有一个签署方已经签署)</li>
        /// <li> **REJECT** :合同拒签</li>
        /// <li> **ALL** :合同签署完成</li>
        /// <li> **DEADLINE** :合同流签(合同过期)</li>
        /// <li> **CANCEL** :合同撤回</li>
        /// <li> **RELIEVED** :解除协议（已解除）</li></ul>
        ///  
        /// </summary>
        [JsonProperty("FlowStatus")]
        public string FlowStatus{ get; set; }

        /// <summary>
        /// 当合同流程状态为已拒签（即 FlowStatus=REJECT）或已撤销（即 FlowStatus=CANCEL ）时，此字段 FlowMessage 为拒签或撤销原因。
        /// </summary>
        [JsonProperty("FlowMessage")]
        public string FlowMessage{ get; set; }

        /// <summary>
        /// 合同流程的创建时间戳，格式为Unix标准时间戳（秒）。
        /// </summary>
        [JsonProperty("CreateOn")]
        public long? CreateOn{ get; set; }

        /// <summary>
        /// 签署流程的签署截止时间, 值为unix时间戳, 精确到秒。
        /// </summary>
        [JsonProperty("DeadLine")]
        public long? DeadLine{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此字段的值)，并以base64方式编码，支持的最大数据大小为 1000长度。
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。
        /// </summary>
        [JsonProperty("CustomData")]
        public string CustomData{ get; set; }

        /// <summary>
        /// 合同流程的签署方数组
        /// </summary>
        [JsonProperty("FlowApproverInfos")]
        public FlowApproverDetail[] FlowApproverInfos{ get; set; }

        /// <summary>
        /// 合同流程的关注方信息数组
        /// </summary>
        [JsonProperty("CcInfos")]
        public FlowApproverDetail[] CcInfos{ get; set; }

        /// <summary>
        /// 是否需要发起前审批
        /// <ul><li>当NeedCreateReview为true，表明当前流程是需要发起前审核的合同，可能无法进行查看，签署操作，需要等审核完成后，才可以继续后续流程</li>
        /// <li>当NeedCreateReview为false，不需要发起前审核的合同</li></ul>
        /// </summary>
        [JsonProperty("NeedCreateReview")]
        public bool? NeedCreateReview{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "NeedCreateReview", this.NeedCreateReview);
        }
    }
}

