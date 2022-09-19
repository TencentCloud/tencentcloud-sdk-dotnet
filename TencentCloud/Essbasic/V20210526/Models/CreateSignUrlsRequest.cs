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

    public class CreateSignUrlsRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 签署流程编号数组，最多支持100个。(备注：该参数和合同组编号必须二选一)
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 合同组编号(备注：该参数和合同(流程)编号数组必须二选一)
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 签署链接类型：“WEIXINAPP”-短链直接跳小程序；“CHANNEL”-跳转H5页面；“APP”-第三方APP或小程序跳转电子签小程序；"LONGURL2WEIXINAPP"-长链接跳转小程序；默认“WEIXINAPP”类型，即跳转至小程序；
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 签署链接生成类型，默认是 "ALL"；
        /// "ALL"：全部签署方签署链接；
        /// "CHANNEL"：渠道合作企业；
        /// "NOT_CHANNEL"：非渠道合作企业；
        /// "PERSON"：个人；
        /// "FOLLOWER"：关注方，目前是合同抄送方；
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// 非渠道合作企业参与方的企业名称，GenerateType为"NOT_CHANNEL"时必填
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 参与人姓名，GenerateType为"PERSON"时必填
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参与人手机号；
        /// GenerateType为"PERSON"或"FOLLOWER"时必填
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 渠道合作企业的企业Id，GenerateType为"CHANNEL"时必填
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 渠道合作企业参与人OpenId，GenerateType为"CHANNEL"时可用，指定到具体参与人
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// Endpoint为"APP" 类型的签署链接，可以设置此值；支持调用方小程序打开签署链接，在电子签小程序完成签署后自动回跳至调用方小程序
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }

        /// <summary>
        /// 签署完之后的H5页面的跳转链接，针对Endpoint为CHANNEL时有效，最大长度1000个字符。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 操作者的信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

