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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeMountInfo : AbstractModel
    {
        
        /// <summary>
        /// 挂载数据卷名称
        /// </summary>
        [JsonProperty("VolumeMountName")]
        public string VolumeMountName{ get; set; }

        /// <summary>
        /// 挂载路径
        /// </summary>
        [JsonProperty("VolumeMountPath")]
        public string VolumeMountPath{ get; set; }

        /// <summary>
        /// 挂载子路径
        /// </summary>
        [JsonProperty("VolumeMountSubPath")]
        public string VolumeMountSubPath{ get; set; }

        /// <summary>
        /// 读写，1：读 2：读写
        /// </summary>
        [JsonProperty("ReadOrWrite")]
        public string ReadOrWrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeMountName", this.VolumeMountName);
            this.SetParamSimple(map, prefix + "VolumeMountPath", this.VolumeMountPath);
            this.SetParamSimple(map, prefix + "VolumeMountSubPath", this.VolumeMountSubPath);
            this.SetParamSimple(map, prefix + "ReadOrWrite", this.ReadOrWrite);
        }
    }
}

