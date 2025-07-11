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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点接入类型。该参数取值如下，不填写时默认为 partial：
        /// <li>partial：CNAME 接入；</li>
        /// <li>full：NS 接入；</li>
        /// <li>noDomainAccess：无域名接入；</li>
        /// <li>dnsPodAccess：DNSPod 托管接入，该接入模式要求您的域名已托管在 DNSPod 内。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 站点名称。CNAME/NS 接入的时，请传入二级域名（example.com）作为站点名称；无域名接入时，该值请保留为空。
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Type 取值为 partial/full 时，七层域名的加速区域。以下为该参数取值，不填写时该值默认为 overseas。Type 取值为 noDomainAccess 时该值请保留为空：
        /// <li> global: 全球可用区；</li>
        /// <li> mainland: 中国大陆可用区；</li>
        /// <li> overseas: 全球可用区（不含中国大陆）。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 待绑定的目标套餐 ID。当您账号下已存在套餐时，可以填写此参数，直接将站点绑定至该套餐。若您当前没有可绑定的套餐时，可通过 [CreatePlan](https://cloud.tencent.com/document/product/1552/105771) 购买套餐。
        /// 注意：如果不填写此参数，将创建一个处于“init”状态的站点，该站点为未激活状态，并不会显示在控制台上。您可以通过访问 [BindZoneToPlan](https://cloud.tencent.com/document/product/1552/83042) 来绑定套餐并激活站点，激活后站点可以正常提供服务。
        /// 
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 同名站点标识。限制输入数字、英文、"." 、"-" 和 "_"，长度 200 个字符以内。详情参考 [同名站点标识](https://cloud.tencent.com/document/product/1552/70202)，无此使用场景时，该字段保留为空即可。
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// 标签。该参数用于对站点进行分权限管控、分账。需要先前往 [标签控制台](https://console.cloud.tencent.com/tag/taglist) 创建对应的标签才可以在此处传入对应的标签键和标签值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否允许重复接入。
        /// <li> true：允许重复接入；</li>
        /// <li> false：不允许重复接入。</li>不填写使用默认值false。
        /// </summary>
        [JsonProperty("AllowDuplicates")]
        [System.Obsolete]
        public bool? AllowDuplicates{ get; set; }

        /// <summary>
        /// 是否跳过站点现有的DNS记录扫描。默认值：false。
        /// </summary>
        [JsonProperty("JumpStart")]
        [System.Obsolete]
        public bool? JumpStart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AllowDuplicates", this.AllowDuplicates);
            this.SetParamSimple(map, prefix + "JumpStart", this.JumpStart);
        }
    }
}

