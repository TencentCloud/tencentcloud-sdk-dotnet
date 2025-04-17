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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Ios应用的唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 应用类型，formal： 正式应用，test：测试应用
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// license数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Licenses")]
        public License[] Licenses{ get; set; }

        /// <summary>
        /// license 秘钥
        /// </summary>
        [JsonProperty("LicenseKey")]
        public string LicenseKey{ get; set; }

        /// <summary>
        /// 安卓应用的唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 用户应用Id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public ulong? ApplicationId{ get; set; }

        /// <summary>
        /// 视立方下载license的url
        /// </summary>
        [JsonProperty("LicenseUrl")]
        public string LicenseUrl{ get; set; }

        /// <summary>
        /// 优图美视信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("XMagics")]
        public XMagicInfo[] XMagics{ get; set; }

        /// <summary>
        /// Mac  进程名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MacBundleId")]
        public string MacBundleId{ get; set; }

        /// <summary>
        /// windows 进程名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WinProcessName")]
        public string WinProcessName{ get; set; }

        /// <summary>
        /// web端Domain列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 账号AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 扩展包名数量上限
        /// </summary>
        [JsonProperty("NameLimit")]
        public ulong? NameLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamArrayObj(map, prefix + "Licenses.", this.Licenses);
            this.SetParamSimple(map, prefix + "LicenseKey", this.LicenseKey);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "LicenseUrl", this.LicenseUrl);
            this.SetParamArrayObj(map, prefix + "XMagics.", this.XMagics);
            this.SetParamSimple(map, prefix + "MacBundleId", this.MacBundleId);
            this.SetParamSimple(map, prefix + "WinProcessName", this.WinProcessName);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NameLimit", this.NameLimit);
        }
    }
}

