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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateNetworkInterfaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡实例ID，例如：eni-m6dyj72l。可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/product/215/15817)接口获取。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 弹性网卡当前绑定的CVM实例ID。形如：ins-r8hr2upy。可通过[DescribeInstances](https://cloud.tencent.com/document/product/213/15728)接口获取。
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// 待迁移的目的CVM实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/product/213/15728)接口获取。
        /// </summary>
        [JsonProperty("DestinationInstanceId")]
        public string DestinationInstanceId{ get; set; }

        /// <summary>
        /// 网卡绑定类型：0 标准型 1 扩展型。默认：0。
        /// </summary>
        [JsonProperty("AttachType")]
        public ulong? AttachType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "DestinationInstanceId", this.DestinationInstanceId);
            this.SetParamSimple(map, prefix + "AttachType", this.AttachType);
        }
    }
}

