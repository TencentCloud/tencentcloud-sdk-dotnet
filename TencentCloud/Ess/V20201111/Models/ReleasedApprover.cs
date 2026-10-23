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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleasedApprover : AbstractModel
    {
        
        /// <summary>
        /// <p>签署人姓名，最大长度50个字。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>签署人手机号。</p>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// <p>要更换的原合同参与人RecipientId编号。(可通过接口<a href="https://qian.tencent.com/developers/companyApis/queryFlows/DescribeFlowInfo/">DescribeFlowInfo</a>查询签署人的RecipientId编号)<br></p>
        /// </summary>
        [JsonProperty("RelievedApproverReceiptId")]
        [System.Obsolete]
        public string RelievedApproverReceiptId{ get; set; }

        /// <summary>
        /// <p>指定签署人类型，目前仅支持<ul><li> <strong>ORGANIZATION</strong>：企业（默认值）</li><li> <strong>ENTERPRISESERVER</strong>：本方企业“授权签”</li><li> <strong>ORGANIZATION_PIN_CODE_SIGN</strong>：本方企业PIN码签署</li></ul></p>
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// <p>签署控件类型，支持自定义企业签署方的签署控件类型</p><ul><li> **SIGN_SEAL**：默认为印章控件类型（默认值）</li><li> **SIGN_SIGNATURE**：手写签名控件类型</li></ul>
        /// </summary>
        [JsonProperty("ApproverSignComponentType")]
        public string ApproverSignComponentType{ get; set; }

        /// <summary>
        /// <p>参与方在合同中的角色是按照创建合同的时候来排序的，解除协议默认会将第一个参与人叫<code>甲方</code>,第二个叫<code>乙方</code>,  第三个叫<code>丙方</code>，以此类推。</p><p>如果需改动此参与人的角色名字，可用此字段指定，由汉字,英文字符,数字组成，最大20个字。</p><p><img src="https://qcloudimg.tencent-cloud.cn/raw/973a820ab66d1ce57082c160c2b2d44a.png" alt="image"></p>
        /// </summary>
        [JsonProperty("ApproverSignRole")]
        public string ApproverSignRole{ get; set; }

        /// <summary>
        /// <p>印章Id，签署控件类型为印章时，用于指定本企业签署方在解除协议中使用那个印章进行签署</p>
        /// </summary>
        [JsonProperty("ApproverSignSealId")]
        public string ApproverSignSealId{ get; set; }

        /// <summary>
        /// <p>要更换的原合同参与人RecipientId编号。(可通过接口<a href="https://qian.tencent.com/developers/companyApis/queryFlows/DescribeFlowInfo/">DescribeFlowInfo</a>查询签署人的RecipientId编号)<br></p>
        /// </summary>
        [JsonProperty("RelievedApproverRecipientId")]
        public string RelievedApproverRecipientId{ get; set; }

        /// <summary>
        /// <h2>PinCode计算规则</h2>  <p>当使用 PIN 码授权签进行身份验证时，需要按以下规则生成 <code>PinCode</code>。</p>  <h3 id="计算公式">计算公式</h3>  <pre><code class="language-text">PinCode = HMAC_SHA256(SHA256(PIN 码)，合同名称) </code></pre>  <p>示例： PinCode = HMAC_SHA256(SHA256("v0ZIwH8lRDLsWRHJWJT7PR05FoXdl4S2")，"给张三的入职合同")</p>  <table> <thead> <tr> <th>参数</th> <th>说明</th> </tr> </thead>  <tbody> <tr> <td><strong>PIN 码</strong></td> <td>企业员工、他方(合作方)企业、个人授权的 PIN 码</td> </tr>  <tr> <td><strong>合同名称</strong></td> <td>签署流程名称，即FlowName，<font color="#FF0000">需去除合同名称前后空格后再进行计算</font></td> </tr>   </tbody> </table>
        /// </summary>
        [JsonProperty("PinCode")]
        public string PinCode{ get; set; }


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
            this.SetParamSimple(map, prefix + "RelievedApproverRecipientId", this.RelievedApproverRecipientId);
            this.SetParamSimple(map, prefix + "PinCode", this.PinCode);
        }
    }
}

