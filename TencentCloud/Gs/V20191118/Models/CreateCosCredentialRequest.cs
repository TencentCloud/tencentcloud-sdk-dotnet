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

    public class CreateCosCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// Cos 密钥类型，取值： Mobile 云手游、PC 云端游、AndroidApp 云手机应用管理、AndroidAppFile 云手机文件管理、AndroidAppBackup 云手机备份还原
        /// </summary>
        [JsonProperty("CosType")]
        public string CosType{ get; set; }

        /// <summary>
        /// 云手机应用管理 Cos 数据
        /// </summary>
        [JsonProperty("AndroidAppCosInfo")]
        public AndroidAppCosInfo AndroidAppCosInfo{ get; set; }

        /// <summary>
        /// 云手机文件管理 Cos 数据
        /// </summary>
        [JsonProperty("AndroidAppFileCosInfo")]
        public FileCosInfo AndroidAppFileCosInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosType", this.CosType);
            this.SetParamObj(map, prefix + "AndroidAppCosInfo.", this.AndroidAppCosInfo);
            this.SetParamObj(map, prefix + "AndroidAppFileCosInfo.", this.AndroidAppFileCosInfo);
        }
    }
}

