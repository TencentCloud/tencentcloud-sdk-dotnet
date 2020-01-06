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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHardwareSpecificationResponse : AbstractModel
    {
        
        /// <summary>
        /// CPU型号列表
        /// </summary>
        [JsonProperty("CpuInfoSet")]
        public CpuInfo[] CpuInfoSet{ get; set; }

        /// <summary>
        /// 内存的取值，单位为G
        /// </summary>
        [JsonProperty("MemSet")]
        public ulong?[] MemSet{ get; set; }

        /// <summary>
        /// 硬盘型号列表
        /// </summary>
        [JsonProperty("DiskInfoSet")]
        public DiskInfo[] DiskInfoSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CpuInfoSet.", this.CpuInfoSet);
            this.SetParamArraySimple(map, prefix + "MemSet.", this.MemSet);
            this.SetParamArrayObj(map, prefix + "DiskInfoSet.", this.DiskInfoSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

