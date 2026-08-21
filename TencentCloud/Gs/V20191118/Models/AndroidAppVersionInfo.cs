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
        /// <p>安卓应用版本</p>
        /// </summary>
        [JsonProperty("AndroidAppVersion")]
        public string AndroidAppVersion{ get; set; }

        /// <summary>
        /// <p>安卓应用版本创建状态，取值：NORMAL：无（默认）、UPLOADING：上传中、CREATING： 创建中、CREATE_FAIL：创建失败、PACKAGE_NAME_MISMATCH：包名不匹配、VERSION_ALREADY_EXISTS：版本已存在、APP_PARSE_FAIL： app 解析失败、APP_EXISTS_SECURITY_RISK：app 存在安全风险、CREATE_SUCCESS：创建成功</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>安卓应用版本创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>shell 安装命令（支持多条命令执行，通过 &amp;&amp; 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）</p>
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// <p>shell 卸载命令（支持多条命令执行，通过 &amp;&amp; 组合；只在应用 AppMode 为 ADVANCED 高级模式下 才会生效）</p>
        /// </summary>
        [JsonProperty("UninstallCommand")]
        public string UninstallCommand{ get; set; }

        /// <summary>
        /// <p>应用资源清理模式（实例安装应用所用资源），取值：CLEANUP_ON_UNINSTALL（默认值），卸载 App 时清理；CLEANUP_AFTER_INSTALL，安装 App 后立即清理。普通应用只有 CLEANUP_AFTER_INSTALL 模式。</p>
        /// </summary>
        [JsonProperty("CleanupMode")]
        public string CleanupMode{ get; set; }

        /// <summary>
        /// <p>安卓应用版本名称（版本描述、备注）</p>
        /// </summary>
        [JsonProperty("AndroidAppVersionName")]
        public string AndroidAppVersionName{ get; set; }

        /// <summary>
        /// <p>安卓应用启动页</p>
        /// </summary>
        [JsonProperty("Activity")]
        public string Activity{ get; set; }

        /// <summary>
        /// <p>应用版本号（Version Name）</p>
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// <p>应用包 MD5</p>
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }

        /// <summary>
        /// <p>应用包文件大小（字节）</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// <p>安卓应用包名</p>
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


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
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

