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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据卷类型
        /// </summary>
        [JsonProperty("VolumeType")]
        public string VolumeType{ get; set; }

        /// <summary>
        /// 数据卷名称
        /// </summary>
        [JsonProperty("VolumeName")]
        public string VolumeName{ get; set; }

        /// <summary>
        /// 数据卷配置
        /// </summary>
        [JsonProperty("VolumeConfig")]
        public string VolumeConfig{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("ConfigMapOptions")]
        public ConfigMapOption[] ConfigMapOptions{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("EmptyDirOption")]
        public EmptyDirOption EmptyDirOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeType", this.VolumeType);
            this.SetParamSimple(map, prefix + "VolumeName", this.VolumeName);
            this.SetParamSimple(map, prefix + "VolumeConfig", this.VolumeConfig);
            this.SetParamArrayObj(map, prefix + "ConfigMapOptions.", this.ConfigMapOptions);
            this.SetParamObj(map, prefix + "EmptyDirOption.", this.EmptyDirOption);
        }
    }
}

