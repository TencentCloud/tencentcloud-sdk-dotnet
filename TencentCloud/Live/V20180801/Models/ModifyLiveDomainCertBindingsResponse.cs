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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveDomainCertBindingsResponse : AbstractModel
    {
        
        /// <summary>
        /// DomainNames 入参中，与证书不匹配的域名列表，将会跳过处理。
        /// </summary>
        [JsonProperty("MismatchedDomainNames")]
        public string[] MismatchedDomainNames{ get; set; }

        /// <summary>
        /// 操作失败的域名及错误码，错误信息，包括MismatchedDomainNames中的域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Errors")]
        public BatchDomainOperateErrors[] Errors{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MismatchedDomainNames.", this.MismatchedDomainNames);
            this.SetParamArrayObj(map, prefix + "Errors.", this.Errors);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

