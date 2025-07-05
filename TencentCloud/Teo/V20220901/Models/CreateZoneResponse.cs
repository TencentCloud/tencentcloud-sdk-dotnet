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

    public class CreateZoneResponse : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点归属权验证信息。站点完成创建后，您还需要完成归属权校验，站点才能正常服务。
        /// 
        /// Type = partial 时，您需要参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789) 前往您的域名解析服务商添加 TXT 记录或者前往根域名服务器添加文件，再调用接口 [VerifyOwnership]() 完成验证；
        /// 
        /// Type = full 时，您需要参考 [修改 DNS 服务器](https://cloud.tencent.com/document/product/1552/90452) 切换 DNS 服务器即可，可通过接口 [VerifyOwnership]() 查询 DNS 是否切换成功；
        /// 
        /// Type = noDomainAccess 时，该值为空，不需要进行任何操作。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

