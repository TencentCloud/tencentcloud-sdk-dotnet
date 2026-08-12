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

    public class LuckyDrawEvent : AbstractModel
    {
        
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
        /// <p>邀请人ID</p>
        /// </summary>
        [JsonProperty("InviterUserId")]
        public string InviterUserId{ get; set; }

        /// <summary>
        /// <p>抽奖次数</p><p>单位：次数</p>
        /// </summary>
        [JsonProperty("LuckyDrawCount")]
        public long? LuckyDrawCount{ get; set; }

        /// <summary>
        /// <p>抽奖类型</p>
        /// </summary>
        [JsonProperty("LuckyDrawType")]
        public string LuckyDrawType{ get; set; }

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
            this.SetParamSimple(map, prefix + "PromotionId", this.PromotionId);
            this.SetParamSimple(map, prefix + "PromotionName", this.PromotionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InviterUserId", this.InviterUserId);
            this.SetParamSimple(map, prefix + "LuckyDrawCount", this.LuckyDrawCount);
            this.SetParamSimple(map, prefix + "LuckyDrawType", this.LuckyDrawType);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

