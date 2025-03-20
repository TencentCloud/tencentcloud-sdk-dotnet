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

    public class FlowApproverDetail : AbstractModel
    {
        
        /// <summary>
        /// 模板配置时候的签署人角色ID(用PDF文件发起也可以指定,如果不指定则自动生成此角色ID), 所有的填写控件和签署控件都归属不同的角色
        /// </summary>
        [JsonProperty("ReceiptId")]
        [System.Obsolete]
        public string ReceiptId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识，定义Agent中的ProxyOrganizationOpenId一样, 可以参考<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#agent" target="_blank">Agent结构体</a>
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenId")]
        public string ProxyOrganizationOpenId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业员工的唯一标识
        /// </summary>
        [JsonProperty("ProxyOperatorOpenId")]
        public string ProxyOperatorOpenId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业名称，与企业营业执照中注册的名称一致。
        /// </summary>
        [JsonProperty("ProxyOrganizationName")]
        public string ProxyOrganizationName{ get; set; }

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
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// </summary>
        [JsonProperty("ApproveName")]
        public string ApproveName{ get; set; }

        /// <summary>
        /// 当前签署人的状态, 状态如下
        /// <ul><li> **PENDING** :待签署</li>
        /// <li> **FILLPENDING** :待填写</li>
        /// <li> **FILLACCEPT** :填写完成</li>
        /// <li> **FILLREJECT** :拒绝填写</li>
        /// <li> **WAITPICKUP** :待领取</li>
        /// <li> **ACCEPT** :已签署</li>
        /// <li> **REJECT** :拒签</li>
        /// <li> **DEADLINE** :过期没人处理</li>
        /// <li> **CANCEL** :流程已撤回</li>
        /// <li> **FORWARD** :已经转他人处理</li>
        /// <li> **STOP** :流程已终止</li>
        /// <li> **RELIEVED** :解除协议（已解除）</li></ul>
        /// </summary>
        [JsonProperty("ApproveStatus")]
        public string ApproveStatus{ get; set; }

        /// <summary>
        /// 签署人拒签等情况的时候填写的原因
        /// </summary>
        [JsonProperty("ApproveMessage")]
        public string ApproveMessage{ get; set; }

        /// <summary>
        /// 签署人签署时间戳，单位秒
        /// </summary>
        [JsonProperty("ApproveTime")]
        public long? ApproveTime{ get; set; }

        /// <summary>
        /// 参与者类型 
        /// <ul><li> **ORGANIZATION** :企业签署人</li>
        /// <li> **PERSON** :个人签署人</li></ul>
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// 自定义签署人的角色名, 如: 收款人、开具人、见证人等
        /// </summary>
        [JsonProperty("ApproverRoleName")]
        public string ApproverRoleName{ get; set; }

        /// <summary>
        /// 签署参与人在本流程中的编号ID（每个流程不同），可用此ID来定位签署参与人在本流程的签署节点。
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 模板配置时候的签署人角色ID(用PDF文件发起也可以指定,如果不指定则自动生成此角色ID), 所有的填写控件和签署控件都归属不同的角色
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiptId", this.ReceiptId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenId", this.ProxyOrganizationOpenId);
            this.SetParamSimple(map, prefix + "ProxyOperatorOpenId", this.ProxyOperatorOpenId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationName", this.ProxyOrganizationName);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "SignOrder", this.SignOrder);
            this.SetParamSimple(map, prefix + "ApproveName", this.ApproveName);
            this.SetParamSimple(map, prefix + "ApproveStatus", this.ApproveStatus);
            this.SetParamSimple(map, prefix + "ApproveMessage", this.ApproveMessage);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "ApproverRoleName", this.ApproverRoleName);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
        }
    }
}

