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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePlanForZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 所要购买套餐的类型，取值有：
        /// <li> sta: 全球内容分发网络（不包括中国大陆）标准版套餐； </li>
        /// <li> sta_with_bot: 全球内容分发网络（不包括中国大陆）标准版套餐附带bot管理；</li>
        /// <li> sta_cm: 中国大陆内容分发网络标准版套餐； </li>
        /// <li> sta_cm_with_bot: 中国大陆内容分发网络标准版套餐附带bot管理；</li>
        /// <li> sta_global ：全球内容分发网络（包括中国大陆）标准版套餐； </li>
        /// <li> sta_global_with_bot ：全球内容分发网络（包括中国大陆）标准版套餐附带bot管理；</li>
        /// <li> ent: 全球内容分发网络（不包括中国大陆）企业版套餐； </li>
        /// <li> ent_with_bot: 全球内容分发网络（不包括中国大陆）企业版套餐附带bot管理；</li>
        /// <li> ent_cm: 中国大陆内容分发网络企业版套餐； </li>
        /// <li> ent_cm_with_bot: 中国大陆内容分发网络企业版套餐附带bot管理。</li>
        /// <li> ent_global ：全球内容分发网络（包括中国大陆）企业版套餐； </li>
        /// <li> ent_global_with_bot ：全球内容分发网络（包括中国大陆）企业版套餐附带bot管理。</li>当前账户可购买套餐类型请以<a href="https://tcloud4api.woa.com/document/product/1657/80124?!preview&!document=1">DescribeAvailablePlans</a>返回为准。
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
        }
    }
}

