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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvitationEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>受邀请人ID</p>
        /// </summary>
        [JsonProperty("InviteeUserId")]
        public string InviteeUserId{ get; set; }

        /// <summary>
        /// <p>营销活动ID</p>
        /// </summary>
        [JsonProperty("PromotionId")]
        public string PromotionId{ get; set; }

        /// <summary>
        /// <p>营销活动名称</p>
        /// </summary>
        [JsonProperty("PromotionName")]
        public string PromotionName{ get; set; }

        /// <summary>
        /// <p>营销活动描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>受邀请人电话号码</p><p>参数格式：符合E.164标准的带“+”、地区编码和号码的格式</p>
        /// </summary>
        [JsonProperty("InviteePhone")]
        public string InviteePhone{ get; set; }

        /// <summary>
        /// <p>邀请码</p>
        /// </summary>
        [JsonProperty("InvitationCode")]
        public string InvitationCode{ get; set; }

        /// <summary>
        /// <p>邀请链接</p>
        /// </summary>
        [JsonProperty("InvitationUrl")]
        public string InvitationUrl{ get; set; }

        /// <summary>
        /// <p>邀请渠道，如微信、抖音、小红书等</p>
        /// </summary>
        [JsonProperty("InvitationChannel")]
        public string InvitationChannel{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InviteeUserId", this.InviteeUserId);
            this.SetParamSimple(map, prefix + "PromotionId", this.PromotionId);
            this.SetParamSimple(map, prefix + "PromotionName", this.PromotionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InviteePhone", this.InviteePhone);
            this.SetParamSimple(map, prefix + "InvitationCode", this.InvitationCode);
            this.SetParamSimple(map, prefix + "InvitationUrl", this.InvitationUrl);
            this.SetParamSimple(map, prefix + "InvitationChannel", this.InvitationChannel);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

