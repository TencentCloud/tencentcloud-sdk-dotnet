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

    public class ReleasedApprover : AbstractModel
    {
        
        /// <summary>
        /// 签署人在原合同签署人列表中的顺序序号(从0开始，按顺序依次递增)。
        /// 可以通过<a href="https://qian.tencent.com/developers/partnerApis/flows/DescribeFlowDetailInfo" target="_blank">DescribeFlowDetailInfo</a>接口查看原流程中的签署人列表。
        /// </summary>
        [JsonProperty("ApproverNumber")]
        public ulong? ApproverNumber{ get; set; }

        /// <summary>
        /// 指定签署人类型，目前支持
        /// <ul><li> **ORGANIZATION**：企业(默认值)</li>
        /// <li> **ENTERPRISESERVER**：企业静默签</li></ul>
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 签署人在原合同中的RecipientId，可以通过<a href="https://qian.tencent.com/developers/partnerApis/flows/DescribeFlowDetailInfo" target="_blank">DescribeFlowDetailInfo</a>接口查看原流程中的签署人信息，可参考返回结构体<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#flowapproverdetail" target="_blank">FlowApproverDetail</a>中的RecipientId。
        /// **注意**：当指定了此参数后，ApproverNumber即失效，会以本参数作为原合同参与人的选取。与ApproverNumber二选一。
        /// </summary>
        [JsonProperty("ReleasedApproverRecipientId")]
        public string ReleasedApproverRecipientId{ get; set; }

        /// <summary>
        /// 签署人姓名，最大长度50个字。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署方经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证(默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成(如存在X，请大写)。</li>
        /// <li>港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给香港居民，“M”字头签发给澳门居民；第2位至第11位为数字。
        /// </li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 签署人手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 组织机构名称。
        /// 请确认该名称与企业营业执照中注册的名称一致。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// 如果签署方是企业签署方(approverType = 0 或者 approverType = 3)， 则企业名称必填。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识，定义Agent中的ProxyOrganizationOpenId一样, 可以参考<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#agent" target="_blank">Agent结构体</a>。
        /// 当为子客企业指定经办人时，此OrganizationOpenId必传。
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业员工的唯一标识，长度不能超过64，只能由字母和数字组成。
        /// 当签署方为同一第三方平台下的员工时，此OpenId必传。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 签署控件类型，支持自定义企业签署方的签署控件类型
        /// <ul><li> **SIGN_SEAL**：默认为印章控件类型(默认值)</li>
        /// <li> **SIGN_SIGNATURE**：手写签名控件类型</li></ul>
        /// </summary>
        [JsonProperty("ApproverSignComponentType")]
        public string ApproverSignComponentType{ get; set; }

        /// <summary>
        /// 参与方在合同中的角色是按照创建合同的时候来排序的，解除协议默认会将第一个参与人叫`甲方`,第二个叫`乙方`,  第三个叫`丙方`，以此类推。
        /// 如果需改动此参与人的角色名字，可用此字段指定，由汉字,英文字符,数字组成，最大20个字。
        /// </summary>
        [JsonProperty("ApproverSignRole")]
        public string ApproverSignRole{ get; set; }

        /// <summary>
        /// 印章Id，签署控件类型为印章时，用于指定本企业签署方在解除协议中使用那个印章进行签署
        /// </summary>
        [JsonProperty("ApproverSignSealId")]
        public string ApproverSignSealId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverNumber", this.ApproverNumber);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "ReleasedApproverRecipientId", this.ReleasedApproverRecipientId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ApproverSignComponentType", this.ApproverSignComponentType);
            this.SetParamSimple(map, prefix + "ApproverSignRole", this.ApproverSignRole);
            this.SetParamSimple(map, prefix + "ApproverSignSealId", this.ApproverSignSealId);
        }
    }
}

