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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ISPCounter : AbstractModel
    {
        
        /// <summary>
        /// 运营商名称
        /// </summary>
        [JsonProperty("ProviderName")]
        public string ProviderName{ get; set; }

        /// <summary>
        /// 节点数量
        /// </summary>
        [JsonProperty("ProviderNodeNum")]
        public long? ProviderNodeNum{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("ProvederInstanceNum")]
        public long? ProvederInstanceNum{ get; set; }

        /// <summary>
        /// Zone实例信息结构体数组
        /// </summary>
        [JsonProperty("ZoneInstanceInfoSet")]
        public ZoneInstanceInfo[] ZoneInstanceInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProviderName", this.ProviderName);
            this.SetParamSimple(map, prefix + "ProviderNodeNum", this.ProviderNodeNum);
            this.SetParamSimple(map, prefix + "ProvederInstanceNum", this.ProvederInstanceNum);
            this.SetParamArrayObj(map, prefix + "ZoneInstanceInfoSet.", this.ZoneInstanceInfoSet);
        }
    }
}

