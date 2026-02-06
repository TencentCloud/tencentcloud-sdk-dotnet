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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallAndroidInstancesAppWithURLRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("AndroidInstanceIds")]
        public string[] AndroidInstanceIds{ get; set; }

        /// <summary>
        /// 安卓应用下载 URL
        /// </summary>
        [JsonProperty("AndroidAppURL")]
        public string AndroidAppURL{ get; set; }

        /// <summary>
        /// 安卓应用MD5码值（32位小写十六进制字符串）
        /// </summary>
        [JsonProperty("AndroidAppMD5")]
        public string AndroidAppMD5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AndroidInstanceIds.", this.AndroidInstanceIds);
            this.SetParamSimple(map, prefix + "AndroidAppURL", this.AndroidAppURL);
            this.SetParamSimple(map, prefix + "AndroidAppMD5", this.AndroidAppMD5);
        }
    }
}

