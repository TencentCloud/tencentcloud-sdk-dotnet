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

    public class DeviceProfile : AbstractModel
    {
        
        /// <summary>
        /// 客户端设备类型。取值有：<li>iOS；</li><li>Android；</li><li>WebView。</li>
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// 判定请求为高风险的最低值，取值范围为 1～99。数值越大请求风险越高越接近 Bot 客户端发起的请求。默认值为 50，对应含义 51～100 为高风险。
        /// </summary>
        [JsonProperty("HighRiskMinScore")]
        public ulong? HighRiskMinScore{ get; set; }

        /// <summary>
        /// 高风险请求的处置方式。SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Redirect：重定向；</li><li>Challenge：挑战。</li>默认值为 Monitor。
        /// </summary>
        [JsonProperty("HighRiskRequestAction")]
        public SecurityAction HighRiskRequestAction{ get; set; }

        /// <summary>
        /// 判定请求为中风险的最低值，取值范围为 1～99。数值越大请求风险越高越接近 Bot 客户端发起的请求。默认值为 15，对应含义 16～50 为中风险。
        /// </summary>
        [JsonProperty("MediumRiskMinScore")]
        public ulong? MediumRiskMinScore{ get; set; }

        /// <summary>
        /// 中风险请求的处置方式。SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Redirect：重定向；</li><li>Challenge：挑战。</li>默认值为 Monitor。
        /// </summary>
        [JsonProperty("MediumRiskRequestAction")]
        public SecurityAction MediumRiskRequestAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "HighRiskMinScore", this.HighRiskMinScore);
            this.SetParamObj(map, prefix + "HighRiskRequestAction.", this.HighRiskRequestAction);
            this.SetParamSimple(map, prefix + "MediumRiskMinScore", this.MediumRiskMinScore);
            this.SetParamObj(map, prefix + "MediumRiskRequestAction.", this.MediumRiskRequestAction);
        }
    }
}

