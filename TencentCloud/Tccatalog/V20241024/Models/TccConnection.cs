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

namespace TencentCloud.Tccatalog.V20241024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TccConnection : AbstractModel
    {
        
        /// <summary>
        /// 引擎终端节点服务Id
        /// </summary>
        [JsonProperty("EndpointServiceId")]
        public string EndpointServiceId{ get; set; }

        /// <summary>
        /// 元数据连接串
        /// </summary>
        [JsonProperty("MetaStoreUrl")]
        public string MetaStoreUrl{ get; set; }

        /// <summary>
        /// 网络信息
        /// </summary>
        [JsonProperty("NetWork")]
        public NetWork NetWork{ get; set; }

        /// <summary>
        /// hive版本
        /// </summary>
        [JsonProperty("HiveVersion")]
        public string HiveVersion{ get; set; }

        /// <summary>
        /// hive location
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// HMS终端节点服务
        /// </summary>
        [JsonProperty("HmsEndpointServiceId")]
        public string HmsEndpointServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointServiceId", this.EndpointServiceId);
            this.SetParamSimple(map, prefix + "MetaStoreUrl", this.MetaStoreUrl);
            this.SetParamObj(map, prefix + "NetWork.", this.NetWork);
            this.SetParamSimple(map, prefix + "HiveVersion", this.HiveVersion);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "HmsEndpointServiceId", this.HmsEndpointServiceId);
        }
    }
}

