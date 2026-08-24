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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskInfo : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘ID
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 云盘的镜像格式。QCOW2:  qcow2格式，这种格式的云盘不能用于容灾；RAW：raw格式，可以用于容灾。
        /// </summary>
        [JsonProperty("ImageFormat")]
        public string ImageFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "ImageFormat", this.ImageFormat);
        }
    }
}

