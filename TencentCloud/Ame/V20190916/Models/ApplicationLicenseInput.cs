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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationLicenseInput : AbstractModel
    {
        
        /// <summary>
        /// 应用名称，注：后面三个字段AndroidPackageName、IOSBundleId、PcIdentifier，三者选填一个
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// app的安卓包名
        /// </summary>
        [JsonProperty("AndroidPackageName")]
        public string AndroidPackageName{ get; set; }

        /// <summary>
        /// app的IOS的BundleId名
        /// </summary>
        [JsonProperty("IOSBundleId")]
        public string IOSBundleId{ get; set; }

        /// <summary>
        /// PC标识名
        /// </summary>
        [JsonProperty("PcIdentifier")]
        public string PcIdentifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AndroidPackageName", this.AndroidPackageName);
            this.SetParamSimple(map, prefix + "IOSBundleId", this.IOSBundleId);
            this.SetParamSimple(map, prefix + "PcIdentifier", this.PcIdentifier);
        }
    }
}

