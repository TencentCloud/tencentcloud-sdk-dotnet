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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BoundK8SInfo : AbstractModel
    {
        
        /// <summary>
        /// 绑定的kubernetes集群ID
        /// </summary>
        [JsonProperty("BoundClusterId")]
        public string BoundClusterId{ get; set; }

        /// <summary>
        /// 绑定的kubernetes的集群类型，分tke和eks两种
        /// </summary>
        [JsonProperty("BoundClusterType")]
        public string BoundClusterType{ get; set; }

        /// <summary>
        /// 服务同步模式，all为全量同步，demand为按需同步
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// 绑定的kubernetes集群所在地域
        /// </summary>
        [JsonProperty("BindRegion")]
        public string BindRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BoundClusterId", this.BoundClusterId);
            this.SetParamSimple(map, prefix + "BoundClusterType", this.BoundClusterType);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "BindRegion", this.BindRegion);
        }
    }
}

