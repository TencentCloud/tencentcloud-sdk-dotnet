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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreateSealPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// 
        /// 渠道应用标识: Agent.AppId
        /// 第三方平台子客企业标识: Agent.ProxyOrganizationOpenId
        /// 第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId
        /// 第三方平台子客企业和员工必须已经经过实名认证。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 电子印章ID，为32位字符串。
        /// 建议开发者保留此印章ID，后续指定签署区印章或者操作印章需此印章ID。
        /// 可登录腾讯电子签控制台，在 "印章"->"印章中心"选择查看的印章，在"印章详情" 中查看某个印章的SealId(在页面中展示为印章ID)。
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 
        /// 员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 可登录腾讯电子签控制台，在 "更多能力"->"组织管理" 中查看某位员工的UserId(在页面中展示为用户ID)。
        /// 员工在贵司业务系统中的唯一身份标识，用于与腾讯电子签账号进行映射，确保在同一企业内不会出现重复。
        /// 该标识最大长度为64位字符串，仅支持包含26个英文字母和数字0-9的字符。
        /// 指定待授权的用户ID数组,电子签的用户ID
        /// 可以填写OpenId，系统会通过组织+渠道+OpenId查询得到UserId进行授权。
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 操作人（用户）信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 企业机构信息，不用传
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
        }
    }
}

