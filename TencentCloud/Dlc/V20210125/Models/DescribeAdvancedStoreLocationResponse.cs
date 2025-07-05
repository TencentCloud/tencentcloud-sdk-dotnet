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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAdvancedStoreLocationResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否启用高级设置：0-否，1-是
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 查询结果保存cos路径
        /// </summary>
        [JsonProperty("StoreLocation")]
        public string StoreLocation{ get; set; }

        /// <summary>
        /// 是否有托管存储权限
        /// </summary>
        [JsonProperty("HasLakeFs")]
        public bool? HasLakeFs{ get; set; }

        /// <summary>
        /// 托管存储状态，HasLakeFs等于true时，该值才有意义
        /// </summary>
        [JsonProperty("LakeFsStatus")]
        public string LakeFsStatus{ get; set; }

        /// <summary>
        /// 托管存储桶类型
        /// </summary>
        [JsonProperty("BucketType")]
        public string BucketType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "StoreLocation", this.StoreLocation);
            this.SetParamSimple(map, prefix + "HasLakeFs", this.HasLakeFs);
            this.SetParamSimple(map, prefix + "LakeFsStatus", this.LakeFsStatus);
            this.SetParamSimple(map, prefix + "BucketType", this.BucketType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

