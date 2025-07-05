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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetLayerVersionResponse : AbstractModel
    {
        
        /// <summary>
        /// 适配的运行时
        /// </summary>
        [JsonProperty("CompatibleRuntimes")]
        public string[] CompatibleRuntimes{ get; set; }

        /// <summary>
        /// 层中版本文件的SHA256编码
        /// </summary>
        [JsonProperty("CodeSha256")]
        public string CodeSha256{ get; set; }

        /// <summary>
        /// 层中版本文件的下载地址
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 版本的创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 版本的描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 许可证信息
        /// </summary>
        [JsonProperty("LicenseInfo")]
        public string LicenseInfo{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("LayerVersion")]
        public long? LayerVersion{ get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [JsonProperty("LayerName")]
        public string LayerName{ get; set; }

        /// <summary>
        /// 层的具体版本当前状态，状态值[参考此处](https://cloud.tencent.com/document/product/583/115197#.E5.B1.82.EF.BC.88Layer.EF.BC.89.E7.8A.B6.E6.80.81)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "CompatibleRuntimes.", this.CompatibleRuntimes);
            this.SetParamSimple(map, prefix + "CodeSha256", this.CodeSha256);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LicenseInfo", this.LicenseInfo);
            this.SetParamSimple(map, prefix + "LayerVersion", this.LayerVersion);
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

