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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudStoragePackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 套餐包id
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 套餐包名字
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 套餐包数量
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 已使用数量
        /// </summary>
        [JsonProperty("UsedNum")]
        public long? UsedNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
        }
    }
}

