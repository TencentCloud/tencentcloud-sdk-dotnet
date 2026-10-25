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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>证书名称</p>
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// <p>证书序列号</p>
        /// </summary>
        [JsonProperty("CertSN")]
        public string CertSN{ get; set; }

        /// <summary>
        /// <p>证书颁发者名称（颁发机构的 CN）</p>
        /// </summary>
        [JsonProperty("IssuerName")]
        public string IssuerName{ get; set; }

        /// <summary>
        /// <p>证书主题，即证书持有者信息</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// <p>证书创建时间，Unix 时间戳，</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>证书生效时间，Unix 时间戳，</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public ulong? EffectiveTime{ get; set; }

        /// <summary>
        /// <p>证书过期时间，Unix 时间戳，</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// <p>证书内容，PEM 格式文本</p>
        /// </summary>
        [JsonProperty("CertText")]
        public string CertText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertSN", this.CertSN);
            this.SetParamSimple(map, prefix + "IssuerName", this.IssuerName);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CertText", this.CertText);
        }
    }
}

