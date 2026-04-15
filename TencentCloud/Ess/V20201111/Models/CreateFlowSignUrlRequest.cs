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

    public class CreateFlowSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>合同流程ID为32位字符串。</p><p>您可以登录腾讯电子签控制台，在 &quot;合同&quot; -&gt; &quot;合同中心&quot; 中查看某个合同的FlowId（在页面中展示为合同ID）。<a href="https://qcloudimg.tencent-cloud.cn/raw/0a83015166cfe1cb043d14f9ec4bd75e.png">点击查看FlowId在控制台中的位置</a>。</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>执行本接口操作的员工信息。<br>注: <code>在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</code></p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>代理企业和员工的信息。<br>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>流程签署人列表中，结构体的ApproverName、ApproverMobile和ApproverType为必传字段。如果是企业签署人，还需传递OrganizationName。</p><p>此结构体和CreateFlow发起接口参与方结构体复用，除了上述参数外，可传递的参数有：</p><ol><li>RecipientId: 发起合同会返回，可以直接用于指定需要生成链接的签署方。</li><li>ApproverSignTypes: 指定签署方签署时候的认证方式，仅此链接生效。</li><li>SignTypeSelector: 可以指定签署方签署合同的认证校验方式的选择模式。</li><li>Intention: 指定H5签署视频核身的意图配置，仅视频签署需要使用。</li></ol><p>注：</p><ol><li>签署人<b>只能使用手写签名、时间类型、印章类型、签批类型的签署控件和内容填写控件</b>，其他类型的签署控件暂时不支持。</li><li>生成发起方预览链接时，该字段（FlowApproverInfos）可以传空或者不传。</li></ol>
        /// </summary>
        [JsonProperty("FlowApproverInfos")]
        public FlowCreateApprover[] FlowApproverInfos{ get; set; }

        /// <summary>
        /// <p>用于指定进入视频签署的限制次数，次数取值范围：1 - 10，不设置则默认为5次，仅视频签署时生效。</p>
        /// </summary>
        [JsonProperty("VideoVerifyTimesLimit")]
        public long? VideoVerifyTimesLimit{ get; set; }

        /// <summary>
        /// <p>机构信息，暂未开放</p>
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }

        /// <summary>
        /// <p>签署完之后的H5页面的跳转链接，最大长度1000个字符。链接类型请参考 <a href="https://qian.tencent.com/developers/company/openqianh5" target="_blank">跳转电子签H5</a></p>
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// <p>链接类型支持以下指定类型：</p><ul><li><b>0</b>: 签署链接（默认值），进入后可以填写或签署合同。</li><li><b>1 </b>: 预览链接，进入后可以预览合同当前的样子。</li></ul><p>注：</p><ol><li>当指定链接类型为1时，链接为预览链接，打开链接后无法进行签署操作，仅支持预览和查看当前合同状态。</li><li>如需生成发起方预览链接，则签署方信息应传空，即FlowApproverInfos传空或者不传。</li></ol>
        /// </summary>
        [JsonProperty("UrlType")]
        public long? UrlType{ get; set; }

        /// <summary>
        /// <p>链接的有效时间，单位为秒。取值范围为 30分钟（1800）-90天（7776000）。如果不传，默认有效期为30分钟。</p><p>注意：</p><ol><li><code>出于安全性考虑，若有效期大于30分钟，同设备24小时内点击链接查看合同需要进行手机验证码校验。</code></li><li><code>若生成合同发起方预览链接，有效期大于30分钟，则需要进行验证码校验的手机号为发起方账号绑定的手机号。</code></li></ol>
        /// </summary>
        [JsonProperty("ExpiredOn")]
        public long? ExpiredOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "FlowApproverInfos.", this.FlowApproverInfos);
            this.SetParamSimple(map, prefix + "VideoVerifyTimesLimit", this.VideoVerifyTimesLimit);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "UrlType", this.UrlType);
            this.SetParamSimple(map, prefix + "ExpiredOn", this.ExpiredOn);
        }
    }
}

