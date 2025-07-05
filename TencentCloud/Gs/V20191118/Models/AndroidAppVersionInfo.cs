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

    public class AndroidAppVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// 安卓应用版本
        /// </summary>
        [JsonProperty("AndroidAppVersion")]
        public string AndroidAppVersion{ get; set; }

        /// <summary>
        /// 安卓应用版本创建状态（NORMAL：无、UPLOADING：上传中、
        /// CREATING： 创建中、
        /// CREATE_FAIL：创建失败、CREATE_SUCCESS：创建成功）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 安卓应用版本创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// shell 安装命令（支持多条命令执行，通过 && 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// shell 卸载命令（支持多条命令执行，通过 && 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）
        /// </summary>
        [JsonProperty("UninstallCommand")]
        public string UninstallCommand{ get; set; }

        /// <summary>
        /// 应用资源清理模式（实例安装应用所用资源），取值：CLEANUP_ON_UNINSTALL（默认值），卸载 App 时清理；CLEANUP_AFTER_INSTALL，安装 App 后立即清理。普通应用只有 CLEANUP_AFTER_INSTALL 模式。
        /// </summary>
        [JsonProperty("CleanupMode")]
        public string CleanupMode{ get; set; }

        /// <summary>
        /// 安卓应用版本名称（版本描述、备注）
        /// </summary>
        [JsonProperty("AndroidAppVersionName")]
        public string AndroidAppVersionName{ get; set; }

        /// <summary>
        /// 安卓应用启动页
        /// </summary>
        [JsonProperty("Activity")]
        public string Activity{ get; set; }

        /// <summary>
        /// 应用版本号（Version Name）
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidAppVersion", this.AndroidAppVersion);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "UninstallCommand", this.UninstallCommand);
            this.SetParamSimple(map, prefix + "CleanupMode", this.CleanupMode);
            this.SetParamSimple(map, prefix + "AndroidAppVersionName", this.AndroidAppVersionName);
            this.SetParamSimple(map, prefix + "Activity", this.Activity);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
        }
    }
}

