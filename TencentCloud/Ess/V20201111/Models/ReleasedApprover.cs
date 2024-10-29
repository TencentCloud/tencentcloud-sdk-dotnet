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

    public class ReleasedApprover : AbstractModel
    {
        
        /// <summary>
        /// 签署人姓名，最大长度50个字。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署人手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 要更换的原合同参与人RecipientId编号。(可通过接口<a href="https://qian.tencent.com/developers/companyApis/queryFlows/DescribeFlowInfo/">DescribeFlowInfo</a>查询签署人的RecipientId编号)<br/>
        /// </summary>
        [JsonProperty("RelievedApproverReceiptId")]
        public string RelievedApproverReceiptId{ get; set; }

        /// <summary>
        /// 指定签署人类型，目前仅支持
        /// <ul><li> **ORGANIZATION**：企业（默认值）</li>
        /// <li> **ENTERPRISESERVER**：企业静默签</li></ul>
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 签署控件类型，支持自定义企业签署方的签署控件类型
        /// <ul><li> **SIGN_SEAL**：默认为印章控件类型（默认值）</li>
        /// <li> **SIGN_SIGNATURE**：手写签名控件类型</li></ul>
        /// </summary>
        [JsonProperty("ApproverSignComponentType")]
        public string ApproverSignComponentType{ get; set; }

        /// <summary>
        /// 参与方在合同中的角色是按照创建合同的时候来排序的，解除协议默认会将第一个参与人叫`甲方`,第二个叫`乙方`,  第三个叫`丙方`，以此类推。
        /// 
        /// 如果需改动此参与人的角色名字，可用此字段指定，由汉字,英文字符,数字组成，最大20个字。
        /// 
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/973a820ab66d1ce57082c160c2b2d44a.png)
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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "RelievedApproverReceiptId", this.RelievedApproverReceiptId);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "ApproverSignComponentType", this.ApproverSignComponentType);
            this.SetParamSimple(map, prefix + "ApproverSignRole", this.ApproverSignRole);
            this.SetParamSimple(map, prefix + "ApproverSignSealId", this.ApproverSignSealId);
        }
    }
}

