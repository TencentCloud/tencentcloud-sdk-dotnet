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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUArgs : AbstractModel
    {
        
        /// <summary>
        /// CUDA版本信息
        /// </summary>
        [JsonProperty("CUDA")]
        public DriverVersion CUDA{ get; set; }

        /// <summary>
        /// cuDNN版本信息
        /// </summary>
        [JsonProperty("CUDNN")]
        public CUDNN CUDNN{ get; set; }

        /// <summary>
        /// 自定义GPU驱动信息
        /// </summary>
        [JsonProperty("CustomDriver")]
        public CustomDriver CustomDriver{ get; set; }

        /// <summary>
        /// GPU驱动版本信息
        /// </summary>
        [JsonProperty("Driver")]
        public DriverVersion Driver{ get; set; }

        /// <summary>
        /// 是否启用MIG特性
        /// </summary>
        [JsonProperty("MIGEnable")]
        public bool? MIGEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CUDA.", this.CUDA);
            this.SetParamObj(map, prefix + "CUDNN.", this.CUDNN);
            this.SetParamObj(map, prefix + "CustomDriver.", this.CustomDriver);
            this.SetParamObj(map, prefix + "Driver.", this.Driver);
            this.SetParamSimple(map, prefix + "MIGEnable", this.MIGEnable);
        }
    }
}

