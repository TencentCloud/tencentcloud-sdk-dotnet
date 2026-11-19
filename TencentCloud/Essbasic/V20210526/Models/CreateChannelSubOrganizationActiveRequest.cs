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

    public class CreateChannelSubOrganizationActiveRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。</p><p>此接口下面信息必填。</p><ul><li>渠道应用标识:  Agent.AppId</li><li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li><li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li></ul>第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>要进行激活或者续期的子客企业OrganizationOpenId列表，请确保所有列出的子客企业均已完成认证。</p>
        /// </summary>
        [JsonProperty("SubOrganizationOpenIds")]
        public string[] SubOrganizationOpenIds{ get; set; }

        /// <summary>
        /// <p>操作类型，可以选择如下：</p><p><strong>false</strong>：（默认）激活子客企业<br><strong>true</strong>：续期子客企业</p>
        /// </summary>
        [JsonProperty("Renew")]
        public bool? Renew{ get; set; }

        /// <summary>
        /// <p>是否解绑子企业</p><p>枚举值：</p><ul><li>false： 否</li><li>true： 是：解绑后，份额将会返还，但是该子企业无法再次被激活</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("Unbind")]
        public bool? Unbind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "SubOrganizationOpenIds.", this.SubOrganizationOpenIds);
            this.SetParamSimple(map, prefix + "Renew", this.Renew);
            this.SetParamSimple(map, prefix + "Unbind", this.Unbind);
        }
    }
}

