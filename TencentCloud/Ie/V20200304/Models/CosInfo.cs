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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosInfo : AbstractModel
    {
        
        /// <summary>
        /// cos 区域值。例如：ap-beijing。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// cos 存储桶，格式为BuketName-AppId。例如：test-123456。
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// cos 路径。 
        /// 对于写表示目录，例如：/test； 
        /// 对于读表示文件路径，例如：/test/test.mp4。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// cos 授权信息，不填默认为公有权限。
        /// </summary>
        [JsonProperty("CosAuthMode")]
        public CosAuthMode CosAuthMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamObj(map, prefix + "CosAuthMode.", this.CosAuthMode);
        }
    }
}

