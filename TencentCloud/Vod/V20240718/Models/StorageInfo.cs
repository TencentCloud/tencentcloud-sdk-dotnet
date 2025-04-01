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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageInfo : AbstractModel
    {
        
        /// <summary>
        /// 存储桶 ID。
        /// </summary>
        [JsonProperty("BucketId")]
        public string BucketId{ get; set; }

        /// <summary>
        /// 存储名称。
        /// </summary>
        [JsonProperty("StorageName")]
        public string StorageName{ get; set; }

        /// <summary>
        /// 存储所在区域。
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// 存储公网源站访问域名的状态，取值有：
        /// <li>ONLINE：已生效；</li>
        /// <li>DEPLOYING： 部署中。</li>
        /// </summary>
        [JsonProperty("InternetAccessDomainStatus")]
        public string InternetAccessDomainStatus{ get; set; }

        /// <summary>
        /// 存储公网源站访问域名。
        /// </summary>
        [JsonProperty("InternetAccessDomain")]
        public string InternetAccessDomain{ get; set; }

        /// <summary>
        /// 存储的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketId", this.BucketId);
            this.SetParamSimple(map, prefix + "StorageName", this.StorageName);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "InternetAccessDomainStatus", this.InternetAccessDomainStatus);
            this.SetParamSimple(map, prefix + "InternetAccessDomain", this.InternetAccessDomain);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

