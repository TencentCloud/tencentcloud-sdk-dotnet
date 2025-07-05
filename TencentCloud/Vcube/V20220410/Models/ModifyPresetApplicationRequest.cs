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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPresetApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用Id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public ulong? ApplicationId{ get; set; }

        /// <summary>
        /// 您的app名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// ios包名
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 安卓包名
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

