/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyAndroidAppVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 安卓应用 Id
        /// </summary>
        [JsonProperty("AndroidAppId")]
        public string AndroidAppId{ get; set; }

        /// <summary>
        /// 安卓应用版本 Id
        /// </summary>
        [JsonProperty("AndroidAppVersion")]
        public string AndroidAppVersion{ get; set; }

        /// <summary>
        /// 安卓应用版本名称
        /// </summary>
        [JsonProperty("AndroidAppVersionName")]
        public string AndroidAppVersionName{ get; set; }

        /// <summary>
        /// 应用 shell 安装命令（支持多条命令执行，通过 && 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 应用 shell 卸载命令（支持多条命令执行，通过 && 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）
        /// </summary>
        [JsonProperty("UninstallCommand")]
        public string UninstallCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidAppId", this.AndroidAppId);
            this.SetParamSimple(map, prefix + "AndroidAppVersion", this.AndroidAppVersion);
            this.SetParamSimple(map, prefix + "AndroidAppVersionName", this.AndroidAppVersionName);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "UninstallCommand", this.UninstallCommand);
        }
    }
}

