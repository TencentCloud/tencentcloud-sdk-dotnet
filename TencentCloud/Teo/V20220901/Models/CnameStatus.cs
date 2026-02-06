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

    public class CnameStatus : AbstractModel
    {
        
        /// <summary>
        /// 接入域名。
        /// </summary>
        [JsonProperty("RecordName")]
        public string RecordName{ get; set; }

        /// <summary>
        /// EdgeOne 分配给接入域名的 CNAME。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// CNAME 配置状态校验结果，取值有：
        /// <li>active：表示接入域名已正确配置到 EdgeOne 为其分配的指定 CNAME；</li>
        /// <li>moved：表示接入域名未配置到 EdgeOne 为其分配的指定 CNAME；</li>
        /// <li>invalid：表示接入域名配置的 CNAME 为 EdgeOne 为其他域名分配的 CNAME，会导致服务异常，请修改为 EdgeOne 为该接入域名提供的指定 CNAME，您可通过本结构体的 Cname 字段获取 EdgeOne 为该接入域名提供的 CNAME。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordName", this.RecordName);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

