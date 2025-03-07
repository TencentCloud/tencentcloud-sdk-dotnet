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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例GPU个数。值小于1代表VGPU类型，大于1代表GPU直通类型。
        /// </summary>
        [JsonProperty("GPUCount")]
        public float? GPUCount{ get; set; }

        /// <summary>
        /// 实例GPU地址。
        /// </summary>
        [JsonProperty("GPUId")]
        public string[] GPUId{ get; set; }

        /// <summary>
        /// 实例GPU类型。
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GPUCount", this.GPUCount);
            this.SetParamArraySimple(map, prefix + "GPUId.", this.GPUId);
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
        }
    }
}

