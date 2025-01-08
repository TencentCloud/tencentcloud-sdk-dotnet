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

    public class FlowApproverDetail : AbstractModel
    {
        
        /// <summary>
        /// 签署时的相关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveMessage")]
        public string ApproveMessage{ get; set; }

        /// <summary>
        /// 签署方姓名
        /// </summary>
        [JsonProperty("ApproveName")]
        public string ApproveName{ get; set; }

        /// <summary>
        /// 签署方的签署状态
        /// 0：还没有发起
        /// 1：流程中 没有开始处理
        /// 2：待签署
        /// 3：已签署
        /// 4：已拒绝
        /// 5：已过期
        /// 6：已撤销
        /// 7：还没有预发起
        /// 8：待填写
        /// 9：因为各种原因而终止
        /// 10：填写完成
        /// 15：已解除
        /// 19：转他人处理
        /// </summary>
        [JsonProperty("ApproveStatus")]
        public long? ApproveStatus{ get; set; }

        /// <summary>
        /// 模板配置中的参与方ID,与控件绑定
        /// </summary>
        [JsonProperty("ReceiptId")]
        [System.Obsolete]
        public string ReceiptId{ get; set; }

        /// <summary>
        /// 客户自定义的用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomUserId")]
        public string CustomUserId{ get; set; }

        /// <summary>
        /// 签署人手机号
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 签署顺序，如果是有序签署，签署顺序从小到大
        /// </summary>
        [JsonProperty("SignOrder")]
        public long? SignOrder{ get; set; }

        /// <summary>
        /// 签署人签署时间，时间戳，单位秒
        /// </summary>
        [JsonProperty("ApproveTime")]
        public long? ApproveTime{ get; set; }

        /// <summary>
        /// 签署方类型，ORGANIZATION-企业员工，PERSON-个人，ENTERPRISESERVER-企业静默签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// 签署方侧用户来源，如WEWORKAPP-企业微信等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproverSource")]
        public string ApproverSource{ get; set; }

        /// <summary>
        /// 客户自定义签署方标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomApproverTag")]
        public string CustomApproverTag{ get; set; }

        /// <summary>
        /// 签署方企业Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 签署方企业名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 签署参与人在本流程中的编号ID（每个流程不同），可用此ID来定位签署参与人在本流程的签署节点，也可用于后续创建签署链接等操作。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 自定义签署人角色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproverRoleName")]
        public string ApproverRoleName{ get; set; }

        /// <summary>
        /// 模板配置中的参与方ID,与控件绑定
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproveMessage", this.ApproveMessage);
            this.SetParamSimple(map, prefix + "ApproveName", this.ApproveName);
            this.SetParamSimple(map, prefix + "ApproveStatus", this.ApproveStatus);
            this.SetParamSimple(map, prefix + "ReceiptId", this.ReceiptId);
            this.SetParamSimple(map, prefix + "CustomUserId", this.CustomUserId);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "SignOrder", this.SignOrder);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "ApproverSource", this.ApproverSource);
            this.SetParamSimple(map, prefix + "CustomApproverTag", this.CustomApproverTag);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "ApproverRoleName", this.ApproverRoleName);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
        }
    }
}

