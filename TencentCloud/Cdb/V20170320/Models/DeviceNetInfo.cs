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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceNetInfo : AbstractModel
    {
        
        /// <summary>
        /// tcp连接数
        /// </summary>
        [JsonProperty("Conn")]
        public long?[] Conn{ get; set; }

        /// <summary>
        /// 网卡入包量，单位：个/秒
        /// </summary>
        [JsonProperty("PackageIn")]
        public long?[] PackageIn{ get; set; }

        /// <summary>
        /// 网卡出包量，单位：个/秒
        /// </summary>
        [JsonProperty("PackageOut")]
        public long?[] PackageOut{ get; set; }

        /// <summary>
        /// 入流量，单位：kbps
        /// </summary>
        [JsonProperty("FlowIn")]
        public long?[] FlowIn{ get; set; }

        /// <summary>
        /// 出流量，单位：kbps
        /// </summary>
        [JsonProperty("FlowOut")]
        public long?[] FlowOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Conn.", this.Conn);
            this.SetParamArraySimple(map, prefix + "PackageIn.", this.PackageIn);
            this.SetParamArraySimple(map, prefix + "PackageOut.", this.PackageOut);
            this.SetParamArraySimple(map, prefix + "FlowIn.", this.FlowIn);
            this.SetParamArraySimple(map, prefix + "FlowOut.", this.FlowOut);
        }
    }
}

