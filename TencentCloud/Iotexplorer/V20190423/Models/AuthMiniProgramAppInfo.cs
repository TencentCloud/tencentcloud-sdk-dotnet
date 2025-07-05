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

    public class AuthMiniProgramAppInfo : AbstractModel
    {
        
        /// <summary>
        /// 小程序APPID
        /// </summary>
        [JsonProperty("MiniProgramAppId")]
        public string MiniProgramAppId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("MiniProgramName")]
        public string MiniProgramName{ get; set; }

        /// <summary>
        /// 激活码数
        /// </summary>
        [JsonProperty("LicenseNum")]
        public long? LicenseNum{ get; set; }

        /// <summary>
        /// 应用ID 
        /// </summary>
        [JsonProperty("IotAppId")]
        public string IotAppId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("IotAppName")]
        public string IotAppName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniProgramAppId", this.MiniProgramAppId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MiniProgramName", this.MiniProgramName);
            this.SetParamSimple(map, prefix + "LicenseNum", this.LicenseNum);
            this.SetParamSimple(map, prefix + "IotAppId", this.IotAppId);
            this.SetParamSimple(map, prefix + "IotAppName", this.IotAppName);
        }
    }
}

