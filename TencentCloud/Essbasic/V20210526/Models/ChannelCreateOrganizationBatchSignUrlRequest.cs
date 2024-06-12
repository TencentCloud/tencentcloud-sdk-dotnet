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

    public class ChannelCreateOrganizationBatchSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括子客企业及应用编、号等详细内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 请指定需执行批量签署的流程ID，数量范围为1-100。 您可登录腾讯电子签控制台，浏览 "合同"->"合同中心" 以查阅某一合同的FlowId（在页面中显示为合同ID）。 用户将利用链接对这些合同实施批量操作。	
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 第三方应用平台的用户openid。 您可登录腾讯电子签控制台，在 "更多能力"->"组织管理" 中查阅某位员工的OpenId。 OpenId必须是传入合同（FlowId）中的签署人。
        /// 
        /// <ul>
        /// <li>1. 若OpenId为空，Name和Mobile 必须提供。</li>
        /// <li>2. 若OpenId 与 Name，Mobile均存在，将优先采用OpenId对应的员工。	</li>
        /// </ul>
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// 
        /// 注：`请确保和合同中填入的一致`
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 员工手机号，必须与姓名一起使用。 如果OpenId为空，则此字段不能为空。同时，姓名和手机号码必须与传入合同（FlowId）中的签署人信息一致。	
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
        }
    }
}

