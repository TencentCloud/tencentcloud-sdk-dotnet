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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCallOutSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 客服用户 ID，一般为客服邮箱，确保已经绑定了手机号 https://cloud.tencent.com/document/product/679/76067#.E6.AD.A5.E9.AA.A42.EF.BC.9A.E5.AE.8C.E5.96.84.E8.B4.A6.E5.8F.B7.E4.BF.A1.E6.81.AF
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 被叫号码，须带 0086 前缀
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 主叫号码（废弃，使用Callers），须带 0086 前缀
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// 指定主叫号码列表，如果前面的号码失败了会自动换成下一个号码，须带 0086 前缀
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 是否强制使用手机外呼，当前只支持 true，若为 true 请确保已配置白名单 https://cloud.tencent.com/document/product/679/76744#.E6.93.8D.E4.BD.9C.E6.AD.A5.E9.AA.A4
        /// </summary>
        [JsonProperty("IsForceUseMobile")]
        public bool? IsForceUseMobile{ get; set; }

        /// <summary>
        /// 自定义数据，长度限制 1024 字节
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// 自定义数据，长度限制 1024 字节
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "IsForceUseMobile", this.IsForceUseMobile);
            this.SetParamSimple(map, prefix + "Uui", this.Uui);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
        }
    }
}

