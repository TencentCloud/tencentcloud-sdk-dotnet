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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SupportDownloadType : AbstractModel
    {
        
        /// <summary>
        /// 是否可以下载nginx可用格式
        /// </summary>
        [JsonProperty("NGINX")]
        public bool? NGINX{ get; set; }

        /// <summary>
        /// 是否可以下载apache可用格式
        /// </summary>
        [JsonProperty("APACHE")]
        public bool? APACHE{ get; set; }

        /// <summary>
        /// 是否可以下载tomcat可用格式
        /// </summary>
        [JsonProperty("TOMCAT")]
        public bool? TOMCAT{ get; set; }

        /// <summary>
        /// 是否可以下载iis可用格式
        /// </summary>
        [JsonProperty("IIS")]
        public bool? IIS{ get; set; }

        /// <summary>
        /// 是否可以下载JKS可用格式
        /// </summary>
        [JsonProperty("JKS")]
        public bool? JKS{ get; set; }

        /// <summary>
        /// 是否可以下载其他格式
        /// </summary>
        [JsonProperty("OTHER")]
        public bool? OTHER{ get; set; }

        /// <summary>
        /// 是否可以下载根证书
        /// </summary>
        [JsonProperty("ROOT")]
        public bool? ROOT{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NGINX", this.NGINX);
            this.SetParamSimple(map, prefix + "APACHE", this.APACHE);
            this.SetParamSimple(map, prefix + "TOMCAT", this.TOMCAT);
            this.SetParamSimple(map, prefix + "IIS", this.IIS);
            this.SetParamSimple(map, prefix + "JKS", this.JKS);
            this.SetParamSimple(map, prefix + "OTHER", this.OTHER);
            this.SetParamSimple(map, prefix + "ROOT", this.ROOT);
        }
    }
}

