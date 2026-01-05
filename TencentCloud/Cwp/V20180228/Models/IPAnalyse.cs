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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPAnalyse : AbstractModel
    {
        
        /// <summary>
        /// 0 安全
        /// 1 可疑
        /// 2 恶意
        /// 3 未知
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 标签特征
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 家族信息
        /// </summary>
        [JsonProperty("Family")]
        public string[] Family{ get; set; }

        /// <summary>
        /// 画像
        /// </summary>
        [JsonProperty("Profile")]
        public string[] Profile{ get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Family.", this.Family);
            this.SetParamArraySimple(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
        }
    }
}

