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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefererAuthPolicy : AbstractModel
    {
        
        /// <summary>
        /// [Referer 防盗链](https://cloud.tencent.com/document/product/266/14046)设置状态，可选值：
        /// <li>Enabled: 启用；</li>
        /// <li>Disabled: 禁用。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Referer 校验类型，可选值：
        /// <li>Black: 黑名单方式校验；</li>
        /// <li>White:白名单方式校验。</li>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 用于校验的 Referer 名单。
        /// </summary>
        [JsonProperty("Referers")]
        public string[] Referers{ get; set; }

        /// <summary>
        /// 是否允许空 Referer 访问本域名，可选值：
        /// <li>Yes: 是；</li>
        /// <li>No: 否。</li>
        /// </summary>
        [JsonProperty("BlankRefererAllowed")]
        public string BlankRefererAllowed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamArraySimple(map, prefix + "Referers.", this.Referers);
            this.SetParamSimple(map, prefix + "BlankRefererAllowed", this.BlankRefererAllowed);
        }
    }
}

