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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RewriteLocationMap : AbstractModel
    {
        
        /// <summary>
        /// 源转发规则ID
        /// </summary>
        [JsonProperty("SourceLocationId")]
        public string SourceLocationId{ get; set; }

        /// <summary>
        /// 重定向目标转发规则的ID
        /// </summary>
        [JsonProperty("TargetLocationId")]
        public string TargetLocationId{ get; set; }

        /// <summary>
        /// 重定向状态码，可取值301,302,307
        /// </summary>
        [JsonProperty("RewriteCode")]
        public long? RewriteCode{ get; set; }

        /// <summary>
        /// 重定向是否携带匹配的url，配置RewriteCode时必填
        /// </summary>
        [JsonProperty("TakeUrl")]
        public bool? TakeUrl{ get; set; }

        /// <summary>
        /// 源转发的域名，必须是SourceLocationId对应的域名，配置RewriteCode时必填
        /// </summary>
        [JsonProperty("SourceDomain")]
        public string SourceDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceLocationId", this.SourceLocationId);
            this.SetParamSimple(map, prefix + "TargetLocationId", this.TargetLocationId);
            this.SetParamSimple(map, prefix + "RewriteCode", this.RewriteCode);
            this.SetParamSimple(map, prefix + "TakeUrl", this.TakeUrl);
            this.SetParamSimple(map, prefix + "SourceDomain", this.SourceDomain);
        }
    }
}

