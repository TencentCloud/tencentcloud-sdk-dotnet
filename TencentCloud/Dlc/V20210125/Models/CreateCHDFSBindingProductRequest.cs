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

    public class CreateCHDFSBindingProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要绑定的元数据加速桶名
        /// </summary>
        [JsonProperty("MountPoint")]
        public string MountPoint{ get; set; }

        /// <summary>
        /// 桶的类型，分为cos和lakefs
        /// </summary>
        [JsonProperty("BucketType")]
        public string BucketType{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 引擎名称，ProductName选择DLC产品时，必传此参数。其他产品可不传
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// vpc信息，产品名称为other时必传此参数
        /// </summary>
        [JsonProperty("VpcInfo")]
        public VpcInfo[] VpcInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MountPoint", this.MountPoint);
            this.SetParamSimple(map, prefix + "BucketType", this.BucketType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
        }
    }
}

