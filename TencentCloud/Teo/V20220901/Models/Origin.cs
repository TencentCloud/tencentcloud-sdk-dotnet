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

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// 主源站列表。
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// 备源站列表。
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// 回源协议配置，取值有：
        /// <li>http：强制 http 回源；</li>
        /// <li>follow：协议跟随回源；</li>
        /// <li>https：强制 https 回源。</li>
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// 源站为腾讯云 COS 时，是否为私有访问 bucket，取值有：
        /// <li>on：私有访问；</li>
        /// <li>off：公共访问。</li>
        /// </summary>
        [JsonProperty("CosPrivateAccess")]
        public string CosPrivateAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamSimple(map, prefix + "CosPrivateAccess", this.CosPrivateAccess);
        }
    }
}

