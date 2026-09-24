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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LakeHouseConnection : AbstractModel
    {
        
        /// <summary>
        /// <p>元数据服务id</p>
        /// </summary>
        [JsonProperty("MetastoreEndpointServiceId")]
        public string MetastoreEndpointServiceId{ get; set; }

        /// <summary>
        /// <p>endpoint服务id</p>
        /// </summary>
        [JsonProperty("EndpointServiceId")]
        public string EndpointServiceId{ get; set; }

        /// <summary>
        /// <p>元数据url</p>
        /// </summary>
        [JsonProperty("MetaStoreUrl")]
        public string MetaStoreUrl{ get; set; }

        /// <summary>
        /// <p>ranger信息</p>
        /// </summary>
        [JsonProperty("RangerConnection")]
        public RangerConnection RangerConnection{ get; set; }

        /// <summary>
        /// <p>hive版本</p>
        /// </summary>
        [JsonProperty("HiveVersion")]
        public string HiveVersion{ get; set; }

        /// <summary>
        /// <p>存储位置</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>网络信息</p>
        /// </summary>
        [JsonProperty("NetWork")]
        public NetWork NetWork{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetastoreEndpointServiceId", this.MetastoreEndpointServiceId);
            this.SetParamSimple(map, prefix + "EndpointServiceId", this.EndpointServiceId);
            this.SetParamSimple(map, prefix + "MetaStoreUrl", this.MetaStoreUrl);
            this.SetParamObj(map, prefix + "RangerConnection.", this.RangerConnection);
            this.SetParamSimple(map, prefix + "HiveVersion", this.HiveVersion);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamObj(map, prefix + "NetWork.", this.NetWork);
        }
    }
}

