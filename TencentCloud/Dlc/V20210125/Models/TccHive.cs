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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TccHive : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 终端节点服务ID
        /// </summary>
        [JsonProperty("EndpointServiceId")]
        public string EndpointServiceId{ get; set; }

        /// <summary>
        /// thrift连接地址
        /// </summary>
        [JsonProperty("MetaStoreUrl")]
        public string MetaStoreUrl{ get; set; }

        /// <summary>
        /// hive版本
        /// </summary>
        [JsonProperty("HiveVersion")]
        public string HiveVersion{ get; set; }

        /// <summary>
        /// 网络信息
        /// </summary>
        [JsonProperty("TccConnection")]
        public NetWork TccConnection{ get; set; }

        /// <summary>
        /// Hms终端节点服务ID
        /// </summary>
        [JsonProperty("HmsEndpointServiceId")]
        public string HmsEndpointServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "EndpointServiceId", this.EndpointServiceId);
            this.SetParamSimple(map, prefix + "MetaStoreUrl", this.MetaStoreUrl);
            this.SetParamSimple(map, prefix + "HiveVersion", this.HiveVersion);
            this.SetParamObj(map, prefix + "TccConnection.", this.TccConnection);
            this.SetParamSimple(map, prefix + "HmsEndpointServiceId", this.HmsEndpointServiceId);
        }
    }
}

